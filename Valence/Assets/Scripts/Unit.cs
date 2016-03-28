using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Unit : MonoBehaviour {

	public string agentId;
	public string unitName;

	public Vector2 currentPosition, lastPosition;
	public ExploreMode_GameController _GameController;
	public GameObject _tile;

	public Vector3 facing;

	//GUI STUFF
	public bool canMove;
	public bool movePressed;
	public bool attackPressed;
	public bool grabPressed;
	public bool waitPressed;
	
	public bool turnComplete;
	public bool hasScrap;

	public bool isAttacking;

	/// //////////////////////////////////////////////

	public int actionPoints;
	
	public int health;

	public GameObject myWeapon;
	public string myWeaponName;

	public int strength;
	public int agility;
	public int perception;

	public int movement;
	public int attackRange;

	public int attackRating;
	public float aimRating;
	
	public bool moving, hasAttacked, isMoving;
	public Vector2 target;
	
	public float moveSpeed = 1;

	public List<ExploreMode_GameController.Node> currentPath = null;

	public bool isElite;
	public int EliteState;
	public List<Unit> FolkUnits;
	public List<Unit> FolkUnitsWithinView;
	public List<Vector2> knownPosition;

	public Vector2 lastKnownPosition;

	public List<Unit> AttackTargets;
	public int currentAttackTarget;

	public Vector2 startPosition;
	public string EliteBehaviour;
	public List<Vector2> PatrolPoints;
	public int currentPatrolPoint;

	public float fieldOfViewAngle = 90;

	public GameObject prefabUnit;

	public List<Vector3> transPath;
	public float journeyLength;
	public float startTime;
	public float speed = 1;

	public GameObject AlertObject, CautionObject;
	public GameObject ScrapObject;

	public EliteAnimCtrl myAnimCtrl;
	public FolkAnimCtrl myFAnimCtrl;

	public int movementRemaining;

	public GameObject myCam;
	// Use this for initialization
	void Start () {

		_GameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ExploreMode_GameController> ();
		agentId = "" + Random.Range (0, 9999);
		currentPosition = new Vector2( transform.position.x, transform.position.z );
		startPosition = currentPosition;
		moving = false;
		movePressed = false;
		attackPressed = false;
		grabPressed = false;
		waitPressed = false;
		turnComplete = false;
		hasAttacked = false;
		isMoving = false;

		currentPatrolPoint = 0;
		
		movement = 2 + (agility);
		movementRemaining = movement;
		attackRange = myWeapon.GetComponent<weaponScript> ().range;
		attackRating = myWeapon.GetComponent<weaponScript> ().damageModifier + (strength);
		aimRating = myWeapon.GetComponent<weaponScript> ().accuracy + (perception * 0.1f);

		foreach( Unit fU in _GameController.folk ){
			FolkUnits.Add (fU);
		}
		if (isElite) {
			myAnimCtrl = transform.GetComponent<EliteAnimCtrl> ();
		} else {
			myFAnimCtrl = transform.GetComponent<FolkAnimCtrl>();
		}
		_GameController.tiles [(int)currentPosition.x,(int)currentPosition.y] = 3;

		myWeaponName = myWeapon.gameObject.name;
		myCam = gameObject.GetComponentInChildren<Camera> ().gameObject;
		if (myCam != null) {
			myCam.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (_GameController.selectedUnit.agentId == agentId ) {
			if ((movementRemaining <= 0 && hasAttacked) || (movementRemaining <= 0 && !_GameController.attackButton.IsInteractable () && !isMoving) || waitPressed) {
				turnComplete = true;
			}
		}
		if(currentPath != null) {
			_GameController.tiles [(int)currentPosition.x,(int)currentPosition.y] = 1;
			int currNode = 0;
			
			while( currNode < currentPath.Count-1 ) {
				Vector3 start = new Vector3( currentPath[currNode].x +0.5f, 1, currentPath[currNode].y+0.5f );
				Vector3 end   = new Vector3( currentPath[currNode+1].x+0.5f,1, currentPath[currNode+1].y+0.5f );
				
				currNode++;
			}
			
		}

		if (!isElite && health <= 0) {
			if( hasScrap )
				ScrapObject.transform.SetParent( null );

			_GameController.tiles[(int)currentPosition.x, (int)currentPosition.y ] = 1;
			//int index = _GameController.folk.IndexOf(this);
			Destroy ( _GameController.PartyButtons[_GameController.PartyButtons.Count-1].gameObject ) ;
			_GameController.PartyButtons.Remove(_GameController.PartyButtons[_GameController.PartyButtons.Count-1]);
			_GameController.folk.Remove (this.gameObject.GetComponent<Unit>());
			gameObject.SetActive (false);
			PlayerData updateData = PlayerDataManager.playerDataManager.loadSaveData();
			foreach( serialAgent sA in updateData.currentParty ){
				if( sA.agentId == agentId )
					sA.health = 0;
			}
			PlayerDataManager.playerDataManager.writePlayerData(updateData);
		}

		if (isElite && FolkUnitsWithinView.Count > 0) {
			AlertObject.SetActive (true);
			CautionObject.SetActive (false);
			lastKnownPosition = knownPosition [knownPosition.Count - 1];
			Vector2 tempFacing = FolkUnitsWithinView[0].currentPosition - currentPosition;
			tempFacing.Normalize ();
			facing = new Vector3 (tempFacing.x, 0, tempFacing.y);
		} else if (isElite && knownPosition.Count > 0) {
			AlertObject.SetActive (false);
			CautionObject.SetActive (true);
			lastKnownPosition = knownPosition [knownPosition.Count - 1];
			Vector2 tempFacing = lastKnownPosition - currentPosition;
			tempFacing.Normalize ();
			facing = new Vector3 (tempFacing.x, 0, tempFacing.y);
		} else if (isElite) {
			AlertObject.SetActive (false);
			CautionObject.SetActive (false);
			lastKnownPosition = Vector2.zero;
		}
		MoveNextTile ();
		translateUnit ();
	}

	void FixedUpdate(){
		if (isElite) {
			EliteObserve ();
			EliteDetermineState ();
		}
	}

	public void translateUnit(){
		if ( transPath != null && transPath.Count > 1) {
			isMoving = true;
			Vector2 tempFacing = new Vector2( transPath[1].x, transPath[1].z ) - new Vector2(transPath[0].x, transPath[0].z);
			tempFacing.Normalize();
			facing = new Vector3( tempFacing.x, 0, tempFacing.y);
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;
			transform.position = Vector3.Lerp (transPath [0], transPath [1], fracJourney * moveSpeed);
			if( !isElite ){
				foreach( Unit eU in _GameController.elite ){
					eU.EliteObserve();
				}
			}
			if( Vector3.Distance( transform.position, transPath[1] ) < 0.001f ){
				transPath.Remove (transPath[0]);
				if( transPath.Count > 1 ){
					startTime = Time.time;
					journeyLength = Vector3.Distance(transPath[0], transPath[1]);
				} else {
					transform.position = transPath[0];
					transPath.Remove(transPath[0]);
					isMoving = false;
					Debug.Log ("no longer moving");
				}
			}
		}
	}
	public void MoveNextTile() {
		float remainingMovement = movement;
		int pathCount;
		if (currentPath != null) {
			pathCount = currentPath.Count;
		} else {
			pathCount = 0;
		}
		while(remainingMovement > 0) {
			if(currentPath==null)
				return;

			// Get cost from current tile to next tile
			remainingMovement -= _GameController.CostToEnterTile(currentPath[0].x, currentPath[0].y, currentPath[1].x, currentPath[1].y );

			transPath.Add (  new Vector3(currentPosition.x, 0, currentPosition.y) );

			// Move us to the next tile in the sequence
			currentPosition.x = currentPath[1].x;
			currentPosition.y = currentPath[1].y;
			movementRemaining--;

			//transform.position = new Vector3(currentPosition.x, 0, currentPosition.y);
			if( isElite) {
				foreach( Vector2 pos in knownPosition ){
					if( currentPosition == pos ){
						knownPosition.Remove (pos);
						if( knownPosition.Count > 0 )
							lastKnownPosition = knownPosition[knownPosition.Count-1];
					}
				}
			}
			if( isElite ){
				foreach( Unit eU in _GameController.elite ){
					eU.EliteObserve();
				}
			}
			// Remove the old "current" tile
			currentPath.RemoveAt(0);

			if(currentPath.Count == 1) {
				// We only have one tile left in the path, and that tile MUST be our ultimate
				// destination -- and we are standing on it!
				// So let's just clear our pathfinding info.
				startTime = Time.time;
				if( pathCount == 1 ){
					transPath.Add (new Vector3( currentPosition.x, 0, currentPosition.y));
				}
				transPath.Add (  new Vector3(currentPosition.x, 0, currentPosition.y) );

				journeyLength = Vector3.Distance(transPath[0], transPath[1]);
				_GameController.tiles [(int)currentPosition.x,(int)currentPosition.y] = 3;
				currentPath = null;
				canMove = false;
			}
		}

		currentPath = null;
		canMove = false;
	}
	
	public void Move( Vector2 targetPosition ){
		_GameController.GeneratePathTo ((int)targetPosition.x, (int)targetPosition.y);
	}

	public bool withinMoveRange( Vector2 targetPosition ){
		if (movementRemaining >= getDistance (currentPosition, targetPosition)) {
			return true;
		} else {
			return false;
		}
	}
	
	public int getDistance( Vector2 p1, Vector2 p2 ){
		int horD = (int) Mathf.FloorToInt( Vector2.Distance ( new Vector2( p2.x,0), new Vector2( p1.x,0) ) );
		int verD = (int) Mathf.FloorToInt( Vector2.Distance ( new Vector2( 0,p2.y), new Vector2( 0,p1.y) ) );
		int d = horD + verD;
		return d;
	}
	
	void MoveObject(Vector3 currentPos,  Vector3 endPos)
	{
		if (moving) {
			endPos = new Vector3 (endPos.x, 0, endPos.y);
			transform.position = Vector3.Lerp (currentPos, endPos, Time.deltaTime);
			if (transform.position == endPos) {
				moving = false;
			}
		}
	}

	public void EliteObserve(){
		int loopIndex = knownPosition.Count;
		foreach (Unit fU in FolkUnits) {
			if( raycastLineOfSight(fU,false) ){
				if( !FolkUnitsWithinView.Contains (fU) ){
					// ... the player is in sight.
					//Debug.Log ("SPOTTED");
					myAnimCtrl.InitAlertAnim();
					//myAnimCtrl.InitAttackAnim();
					FolkUnitsWithinView.Add (fU);
					//generateSound(currentPosition,3.0f);
					if( !knownPosition.Contains ( fU.currentPosition ) )
						knownPosition.Add( fU.currentPosition );
					// Set the last global sighting is the players current position.
					
				} else {
					// Set the last global sighting is the players current position.
					if( !knownPosition.Contains ( fU.currentPosition ) )
						knownPosition.Add( fU.currentPosition );
				} 
			} else {
				if( FolkUnitsWithinView.Contains (fU) )
					FolkUnitsWithinView.Remove (fU);
			}
			loopIndex++;
		}
		if (lastKnownPosition == currentPosition) {
			if( knownPosition.Count > 0 )
				lastKnownPosition = knownPosition[knownPosition.Count-1];
			else
				lastKnownPosition = new Vector2(-1,-1);
		}
		for (int i = 0; i < knownPosition.Count; i++) {
			if (currentPosition == knownPosition[i]) {
				knownPosition.Remove( knownPosition[i] );
				i--;
			}
		}

	}

	public void EliteDetermineState(){

		if (knownPosition.Count <= 0) {
			EliteState = 1; // Idle
		} else if (knownPosition.Count > 0 && FolkUnitsWithinView.Count > 0) {
			EliteState = 3; // Attack
		} else if (knownPosition.Count > 0) {
			EliteState = 2; // Search
		}

		switch (EliteState) 
		{
			case 1:
				// conduct default behaviour
				//Debug.Log ( "Idle State");
				break;
			case 2:
				//Debug.Log ( "Pursuit State");
				break;
			case 3:
				//Debug.Log ( "Eliminate State");
				break;
			default:
				//Debug.Log ( "No State Defined");
				break;

		}
	}

	public bool raycastLineOfSight( Unit fU , bool ignoreAngle){
		Vector3 direction = fU.transform.position - transform.position;
		//Debug.Log ( direction.normalized.x + " " + direction.normalized.y + " " + direction.normalized.z );
		float angle = Vector3.Angle(direction, facing);
		Debug.DrawLine( fU.transform.position+ new Vector3(0.5f,1.2f,0.5f), transform.position+ new Vector3(0.5f,1.2f,0.5f));
		// If the angle between forward and where the player is, is less than half the angle of view...
		if(angle < fieldOfViewAngle * 0.5f || ignoreAngle == true )
		{
			RaycastHit hit;
			// ... and if a raycast towards the player hits something...
			if( isElite ){
				if(Physics.Raycast(transform.position + new Vector3(0.5f,1.2f,0.5f) , direction.normalized, out hit, 6.0f ) )
				{
					// ... and if the raycast hits the player...
					if(hit.collider.gameObject == fU.gameObject )
					{
						return true;
					} else {
						return false;
						//FolkUnitsWithinView.Remove (fU);
					}
				} else {
					return false;
					//if( FolkUnitsWithinView.Contains (fU) )
						//FolkUnitsWithinView.Remove (fU);
				}
			} else {
				if(Physics.Raycast(transform.position + new Vector3(0.5f,1.2f,0.5f) , direction.normalized, out hit ) )
				{
					// ... and if the raycast hits the player...
					if(hit.collider.gameObject == fU.gameObject )
					{
						return true;
					} else {
						return false;
						//FolkUnitsWithinView.Remove (fU);
					}
				} else {
					return false;
					//if( FolkUnitsWithinView.Contains (fU) )
					//FolkUnitsWithinView.Remove (fU);
				}
			}
		} else {
			return false;
			if( FolkUnitsWithinView.Contains (fU) )
				FolkUnitsWithinView.Remove (fU);
		}
	}

	public Vector2 EliteCalcOptMoveTile(){
		Vector2 targetPosition = currentPosition;
		int myMapSize = _GameController.mapSize;
		if (EliteState == 1) {
			float distToTargetPosition = 99.9f;
			if( currentPosition != startPosition && EliteBehaviour == "Guard" ){
				if(  _GameController.GeneratePathTo((int)startPosition.x,(int)startPosition.y,0) ){
					targetPosition = startPosition;
				} else{ 
					List<ExploreMode_GameController.Node> path = _GameController.GenerateNodePath((int)startPosition.x,(int)startPosition.y);
					if( path == null ){
						Debug.Log ( "I HAVE FUCKED THE HELL UP");
					}
					while( targetPosition == new Vector2(-1,-1) ){
						if(  _GameController.GeneratePathTo(path[0].x,path[0].y,0) ){
							targetPosition = new Vector2( path[0].x, path[0].y );
						} else {
							path.Remove(path[0]);
							if( path.Count <= 0 ){
								//targetPosition = currentPosition;
								Debug.Log ( "I aint moving");
							}
						}
					}
				}
			} else if ( EliteBehaviour == "Patrol" ){
				if( currentPosition == PatrolPoints[currentPatrolPoint] ){
					currentPatrolPoint++;
					if( currentPatrolPoint >= PatrolPoints.Count ){
						currentPatrolPoint = 0;
					}
				}
				targetPosition = new Vector2(-1,-1);
				if(  _GameController.GeneratePathTo((int)PatrolPoints[currentPatrolPoint].x,(int)PatrolPoints[currentPatrolPoint].y,0) ){
					targetPosition = PatrolPoints[currentPatrolPoint];
				} else{ 
					List<ExploreMode_GameController.Node> path = _GameController.GenerateNodePath((int)PatrolPoints[currentPatrolPoint].x,(int)PatrolPoints[currentPatrolPoint].y);
					if( path == null ){
						Debug.Log ( "I HAVE FUCKED THE HELL UP");
					}
					while( targetPosition == new Vector2(-1,-1) ){
						if(  _GameController.GeneratePathTo(path[0].x,path[0].y,0) ){
							targetPosition = new Vector2( path[0].x, path[0].y );
						} else {
							path.Remove(path[0]);
							if( path.Count <= 0 ){
								targetPosition = currentPosition;
							}
						}
					}
				}
				//targetPosition = PatrolPoints[currentPatrolPoint];
			} else {
				facing = new Vector3( (int) Random.Range (-1,2), 0,(int) Random.Range (-1,2) );
			}
		}
		else if (EliteState == 2) {
			targetPosition = new Vector2(-1,-1);
			if(  _GameController.GeneratePathTo((int)lastKnownPosition.x,(int)lastKnownPosition.y,0) )
				targetPosition = lastKnownPosition;
			List<ExploreMode_GameController.Node> path = _GameController.GenerateNodePath((int)lastKnownPosition.x,(int)lastKnownPosition.y);
			if( path == null ){
				Debug.Log ( "I HAVE FUCKED THE HELL UP");
			}
			while( targetPosition == new Vector2(-1,-1) ){
				if(  _GameController.GeneratePathTo(path[0].x,path[0].y,0) ){
					targetPosition = new Vector2( path[0].x, path[0].y );
				} else {
					path.Remove(path[0]);
					if( path.Count <= 0 ){
						targetPosition = currentPosition;
					}
				}
	      	}

		} else if (EliteState == 3) {
			GameObject tempUnit = (GameObject) Instantiate ( prefabUnit, this.transform.position, Quaternion.identity );
			Unit tempScript = tempUnit.GetComponent<Unit>();
			tempScript._GameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ExploreMode_GameController> ();
			_GameController.selectedUnit = tempScript;
			tempScript.myWeapon = myWeapon;
			tempScript.attackRange = attackRange;
			tempScript.currentPosition = currentPosition;
			tempScript.currentPath = null;
			for( int i = (int)currentPosition.x-movement; i < (int)currentPosition.x + movement; i++){
				for( int j = (int) currentPosition.y-movement; j < (int)currentPosition.y + movement; j++){
					if( i >= 0 && i < myMapSize && j >= 0 && j < myMapSize ){
						tempScript.currentPosition = new Vector2( i , j );
						foreach( Unit fU in FolkUnitsWithinView ){
							Vector2 tempFacing = fU.currentPosition - tempScript.currentPosition;
							tempFacing.Normalize();
							tempScript.facing = new Vector3( tempFacing.x, 0, tempFacing.y);
							if( tempScript.isWithinAttackRange(fU) ){
								if( _GameController.GeneratePathTo(i,j,0)){
									targetPosition = new Vector2(i,j );
									Destroy (tempUnit);
									return targetPosition;
								}
							}
						}
					}
				}
			}
			Destroy (tempUnit);
		}

//			GameObject tempUnit = (GameObject) Instantiate ( prefabUnit, this.transform.position, Quaternion.identity );
//			Unit tempScript = tempUnit.GetComponent<Unit>();
//			tempScript._GameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ExploreMode_GameController> ();
//			_GameController.selectedUnit = tempScript;
//			tempScript.attackRange = attackRange;
//			tempScript.currentPosition = currentPosition;
//			tempScript.currentPath = null;
//			int[,] scores = new int[myMapSize,myMapSize];
//			for( int i = (int)currentPosition.x-movement; i < (int)currentPosition.x + movement; i++){
//				for( int j = (int) currentPosition.y-movement; j < (int)currentPosition.y + movement; j++){
//					if( i >= 0 && i <= myMapSize && j >= 0 && j <= myMapSize ){
//						// is it pathable
//						if( _GameController.GeneratePathTo(i,j,0)){
//							scores[i,j] += 100;
//							
//							_GameController.selectedUnit = tempScript;
//							//tempScript.currentPosition = currentPosition;
//							tempScript.currentPosition = new Vector2(i,j);
//							tempScript.transform.position = new Vector3(i , 0 , j );
//							//tempScript.currentPath = null;
//							//_GameController.GeneratePathTo( i , j );
//							//tempScript.MoveNextTile();
//
//							foreach( Unit fU in FolkUnitsWithinView ){
//								if( fU.raycastLineOfSight(tempScript,true) && fU.isWithinAttackRange(tempScript) ){
//									scores[i,j] -= 10;
//								}
//								if( tempScript.raycastLineOfSight(fU,false) && tempScript.isWithinAttackRange(fU) ){
//									scores[i,j] += 40;
//								}
//							}
//						}
//					}
//				}
//			}
//			Destroy ( tempUnit );
//			_GameController.selectedUnit = this.gameObject.GetComponent<Unit>();
//			int highestScore = 0;
//			Vector2 highVector = new Vector2(-1,-1);
//			for( int i = (int)currentPosition.x-movement; i < (int)currentPosition.x + movement; i++){
//				for( int j = (int) currentPosition.y-movement; j < (int)currentPosition.y + movement; j++){
//					if( i >= 0 && i <= myMapSize && j >= 0 && j <= myMapSize ){
//						if( scores[i,j] > highestScore ){
//							highestScore = scores[i,j];
//							highVector = new Vector2(i,j);
//						}
//					}
//				}
//			}
//			targetPosition = highVector;
		return targetPosition;
	}

	public void Attack(Unit targetUnit){
		targetUnit.health -= attackRating;
		if (targetUnit.isElite) {
			targetUnit.knownPosition.Add (currentPosition);
			targetUnit.lastKnownPosition = targetUnit.knownPosition[targetUnit.knownPosition.Count-1];

		}
		generateSound (currentPosition, myWeapon.GetComponent<weaponScript> ().soundRange);
		Debug.Log ("Attack Dealt " + attackRating + " Damage.");
		Debug.Log ("Unit has " + targetUnit.health + " remaining.");
	}

	public bool isWithinAttackRange(Unit fU ){
		if (!isElite) {
			if (raycastLineOfSight (fU, true) && getDistance (currentPosition, fU.currentPosition) <= attackRange){
				return true;
			} else
				return false;
		} else {
			if (raycastLineOfSight (fU, false) && getDistance (currentPosition, fU.currentPosition) <= attackRange)
				return true;
			else
				return false;
		}
	}

	public void generateSound(Vector2 source, float sndDistance){
		foreach (Unit eU in _GameController.elite) {
			if( getDistance ( source, eU.currentPosition ) <= sndDistance ){
				if( !eU.knownPosition.Contains(source) ){
					eU.knownPosition.Add (source);
					eU.lastKnownPosition = eU.knownPosition[eU.knownPosition.Count-1];
				}
			}
		}
	}

	public float calcChanceToHit(float distance){
		float chance = aimRating - ( myWeapon.GetComponent<weaponScript>().rangeModifier * distance );
		//float chance = aimRating * Mathf.Sin( (myWeapon.GetComponent<weaponScript>().period*distance) + myWeapon.GetComponent<weaponScript>().offset );
		if (distance > myWeapon.GetComponent<weaponScript> ().range) {
			chance = 0;
		}
		chance = chance * 100;
		if (chance <= 0)
			chance = 0;
		else if (chance >= 99)
			chance = 99;
		//Debug.Log ("Chance to hit: " + chance + "%");
		return chance;
		/**
		int rand = Random.Range (0, 100);

		if (!isElite) {
			_GameController.chanceToHitText.text = ""+chance;
		}

		if (rand < chance) {
			Debug.Log("HIT!");
			return true;
		} else {
			Debug.Log("Miss. #sadness #onlyFolkKidsWouldUnderstand");
			return false;
		}
		**/
	}
}
