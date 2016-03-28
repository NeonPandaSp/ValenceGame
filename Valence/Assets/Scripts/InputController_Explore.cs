using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class InputController_Explore : MonoBehaviour {
	TileMap _tileMap;
	generateZone _generateZone;
	public ExploreMode_GameController _GameController;
	public FolkUnit _myFolkUnit;
	
	Vector2 currentTile;
	
	Vector2 rootMousePos;

	Vector2 targetMovementPos;
	
	GameObject myHoverObject;
	
	public Material redMat, blueMat, yellowMat, greenMat;
	
	string currentColor;
	
	bool generate;

	public GameObject wallObject, boundObject;

	public Canvas myCanvas;
	public GameObject dmgText;

	public GameObject moveTargetIcon;

	public LineRenderer myLine;

	public Button moveConfirmedButton, attackConfirmedButton;

	public GameObject HintObject;

	public Sprite dropSprite, pickupSprite;

	public bool hovering;

	void Start(){
		_tileMap = GetComponent<TileMap> ();
		//myHoverObject = (GameObject) Instantiate (Resources.Load("Tile"), new Vector3 (0, 0, 0), Quaternion.identity);
		myLine.gameObject.SetActive (false);
		moveTargetIcon.gameObject.SetActive (false);
		currentColor = "blue";
	}
	
	
	public void selectedMaterial( string color ){
		if (color == "blue") {
			//myHoverObject.GetComponentInChildren<MeshRenderer> ().material = blueMat;
			currentColor = "blue";
		} else if (color == "yellow") {
			//myHoverObject.GetComponentInChildren<MeshRenderer> ().material = yellowMat;
			currentColor = "yellow";
		} else if (color == "green") {
			//myHoverObject.GetComponentInChildren<MeshRenderer> ().material = greenMat;
			currentColor = "green";
		}
	}
	

	

	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitInfo;
		
		if ( GetComponent<Collider>().Raycast (ray, out hitInfo, Mathf.Infinity)) {

			int x = Mathf.FloorToInt( hitInfo.point.x  / _tileMap.tileSize );
			int z = Mathf.FloorToInt( hitInfo.point.z / _tileMap.tileSize );
			currentTile.x = x;
			currentTile.y = z;
			
			if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
				//myHoverObject.transform.position = new Vector3( currentTile.x, 0, currentTile.y );
			}
			
		} else {
			
		}
		if (_GameController.selectedUnit.isElite) {
			_GameController.moveButton.interactable = false;
			_GameController.attackButton.interactable = false;
			_GameController.waitButton.interactable = false;
			_GameController.pickUpButton.interactable = false;
		} else {
			_GameController.waitButton.interactable = true;
			if (_GameController.selectedUnit.movementRemaining > 0 && !_GameController.selectedUnit.movePressed && !_GameController.selectedUnit.isMoving) {
				_GameController.GenerateMovementRange ((int)_GameController.selectedUnit.currentPosition.x, (int)_GameController.selectedUnit.currentPosition.y);
				_GameController.selectedUnit.movePressed = true;
			} else if( ( !_GameController.selectedUnit.movePressed && _GameController.moveTiles.Count > 0 ) || _GameController.selectedUnit.isMoving ) {
				foreach( GameObject n in _GameController.moveTiles){
					Destroy (n);
				}
				_GameController.moveTiles.Clear();
			}
			
			if (_GameController.selectedUnit.movePressed && !_GameController.selectedUnit.isMoving) {
				if (!hovering && _GameController.selectedUnit.withinMoveRange (currentTile) && _GameController.GeneratePathTo ((int)currentTile.x, (int)currentTile.y, 0)) {
					List<ExploreMode_GameController.Node> pathToSelected = _GameController.GenerateNodePath ((int)currentTile.x, (int)currentTile.y);
					DrawLine (pathToSelected);
					moveTargetIcon.SetActive (true);
					moveTargetIcon.transform.position = new Vector3 (currentTile.x, 0.1f, currentTile.y);
				} else {
					myLine.gameObject.SetActive (false);
					moveTargetIcon.SetActive (false);
				}
			} else if (_GameController.selectedUnit.isMoving) {
				List<ExploreMode_GameController.Node> pathToSelected = _GameController.GenerateNodePath((int) targetMovementPos.x, (int)targetMovementPos.y );
				if( pathToSelected != null && pathToSelected.Count >= 1 ){
					DrawLine( pathToSelected );
					moveTargetIcon.SetActive(true);
					moveTargetIcon.transform.position = new Vector3( pathToSelected[pathToSelected.Count-1].x, 0.1f, pathToSelected[pathToSelected.Count-1].y );
				}
			}
		}

		if( Input.GetMouseButton(0) && !Input.GetKey (KeyCode.LeftAlt) ){

			if( _GameController.selectedUnit.movementRemaining > 0 && _GameController.GameState == 1 && _GameController.selectedUnit.movePressed ){
				if( _GameController.selectedUnit.withinMoveRange( currentTile ) && _GameController.GeneratePathTo((int)currentTile.x,(int)currentTile.y, 0 ) ){
					//_GameController.selectedUnit.Move(currentTile);
					//Instantiate( moveTargetIcon, new Vector3( currentTile.x, 0.1f, currentTile.y), Quaternion.identity );

					//OLD FORM 
//					moveTargetIcon.SetActive(true);
//					moveTargetIcon.transform.position = new Vector3( currentTile.x, 0.1f, currentTile.y);
//					targetMovementPos = currentTile;
//					List<ExploreMode_GameController.Node> pathToSelected = _GameController.GenerateNodePath((int)currentTile.x,(int)currentTile.y);
//					DrawLine( pathToSelected );
//					foreach( GameObject n in _GameController.moveTiles){
//						Destroy (n);
//					}
//					_GameController.moveTiles.Clear();
//					moveConfirmedButton.gameObject.SetActive(true);
//					_GameController.selectedUnit.movePressed = false;
					if( !hovering ){
						targetMovementPos = currentTile;
						moveConfirmed();
						_GameController.selectedUnit.movePressed = false;
					}
				} else {
					// not within range
				}
			}
		}

		if (Input.GetKeyDown (KeyCode.Tab) && !_GameController.selectedUnit.isMoving) {
			selectedNextUnit ();
		}

		if(Input.GetKeyDown ( KeyCode.V )){
			ToggleWallVisibilty();
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel(2);
		}

		if (Input.GetKeyDown (KeyCode.H)) {
			if( HintObject.activeSelf ){
				HintObject.SetActive(false);
			} else {
				HintObject.SetActive(true);
				HintObject.GetComponent<HintScript>().currentTime = Time.time;
				HintObject.GetComponent<HintScript>().timeToDelete = Time.time + 14;
			}
		}

		if (Input.GetKey (KeyCode.Alpha1) && _GameController.folk.Count > 1 ) {
			moveTargetIcon.SetActive (false);
			myLine.gameObject.SetActive (false);
			_GameController.DestroyMovementRange ();
			_GameController.selectedUnit = _GameController.folk[0];
			_GameController.selectedIndex = 0;
			_GameController.MoveIcon();
			_GameController.cameraObject.MoveCameraTo( _GameController.cameraObject.transform.position, _GameController.selectedUnit.transform.position );
		} else if (Input.GetKey (KeyCode.Alpha2) && _GameController.folk.Count > 2) {
			moveTargetIcon.SetActive (false);
			myLine.gameObject.SetActive (false);
			_GameController.DestroyMovementRange ();
			_GameController.selectedUnit = _GameController.folk[1];
			_GameController.selectedIndex = 1;
			_GameController.MoveIcon();
			_GameController.cameraObject.MoveCameraTo( _GameController.cameraObject.transform.position, _GameController.selectedUnit.transform.position );
		} else if (Input.GetKey (KeyCode.Alpha3) && _GameController.folk.Count > 3 ) {
			moveTargetIcon.SetActive (false);
			myLine.gameObject.SetActive (false);
			_GameController.DestroyMovementRange ();
			_GameController.selectedUnit = _GameController.folk[2];
			_GameController.selectedIndex = 2;
			_GameController.MoveIcon();
			_GameController.cameraObject.MoveCameraTo( _GameController.cameraObject.transform.position, _GameController.selectedUnit.transform.position );
		} else if (Input.GetKey (KeyCode.Alpha4) && _GameController.folk.Count > 4 ) {
			moveTargetIcon.SetActive (false);
			myLine.gameObject.SetActive (false);
			_GameController.DestroyMovementRange ();
			_GameController.selectedUnit = _GameController.folk[3];
			_GameController.selectedIndex = 3;
			_GameController.MoveIcon();
			_GameController.cameraObject.MoveCameraTo( _GameController.cameraObject.transform.position, _GameController.selectedUnit.transform.position );
		} else if (Input.GetKey (KeyCode.Alpha5) && _GameController.folk.Count > 5 ) {
			moveTargetIcon.SetActive (false);
			myLine.gameObject.SetActive (false);
			_GameController.DestroyMovementRange ();
			_GameController.selectedUnit = _GameController.folk[4];
			_GameController.selectedIndex = 4;
			_GameController.MoveIcon();
			_GameController.cameraObject.MoveCameraTo( _GameController.cameraObject.transform.position, _GameController.selectedUnit.transform.position );
		}

		hovering = false;
	}
	
	public void ToggleWallVisibilty (){
		if (wallObject.activeInHierarchy) {
			wallObject.SetActive (false);
			//boundObject.SetActive(true);
		} else {
			wallObject.SetActive (true);
			//boundObject.SetActive(false);
		}
	}
	public void MoveSelectedUnit( ){
		_GameController.disableAttackBox();
		_GameController.selectedUnit.movePressed = true;
		attackConfirmedButton.gameObject.SetActive (false);
		_GameController.GenerateMovementRange((int)_GameController.selectedUnit.currentPosition.x, (int)_GameController.selectedUnit.currentPosition.y);
	}

	public void AttackWithSelectedUnit(){

		if (!_GameController.selectedUnit.attackPressed) {
			_GameController.enableAttackBox (_GameController.selectedUnit);
			attackConfirmedButton.gameObject.SetActive (true);
			moveConfirmedButton.gameObject.SetActive (false);
			_GameController.selectedUnit.AttackTargets [_GameController.selectedUnit.currentAttackTarget].gameObject.GetComponent<EnemyMouseOver> ().enableUI ();
			_GameController.selectedUnit.attackPressed = true;
		} else {
			attackConfirmedButton.gameObject.SetActive(false);
			_GameController.disableAttackBox();
			_GameController.selectedUnit.attackPressed = false;
		}
	}

	public void WaitSelectedUnit(){
		_GameController.disableAttackBox();
		_GameController.selectedUnit.waitPressed = true;
		_GameController.selectedUnit.canMove = false;
		_GameController.selectedUnit.actionPoints = 0;
		_GameController.selectedUnit.turnComplete = true;
		attackConfirmedButton.gameObject.SetActive (false);
		moveConfirmedButton.gameObject.SetActive (false);
		selectedNextUnit ();
	}

	public void PickupSelectedUnit(){
		if (!_GameController.selectedUnit.hasScrap) {
			_GameController.disableAttackBox ();
			_GameController.selectedUnit.grabPressed = true;
			_GameController.selectedUnit.actionPoints--;
			_GameController.scrapObj.transform.SetParent (_GameController.selectedUnit.gameObject.transform);
			_GameController.scrapObj.transform.position = _GameController.selectedUnit.gameObject.transform.position;
			_GameController.scrapObj.transform.position += _GameController.selectedUnit.facing / 2;
			_GameController.scrapObj.transform.position += new Vector3( 0, 0.5f, 0 );
			_GameController.selectedUnit.hasScrap = true;
			_GameController.pickUpButton.image.sprite = dropSprite;
		} else {
			_GameController.disableAttackBox ();
			_GameController.selectedUnit.grabPressed = true;
			_GameController.selectedUnit.actionPoints--;
			_GameController.scrapObj.transform.SetParent (null);
			_GameController.scrapObj.transform.position = _GameController.selectedUnit.gameObject.transform.position;
			//_GameController.scrapObj.transform.position += _GameController.selectedUnit.facing;
			_GameController.selectedUnit.hasScrap = false;
			_GameController.pickUpButton.image.sprite = pickupSprite;
		}
	}

	public void selectUnit(int index){
		_GameController.selectedUnit = _GameController.folk[index];
		_GameController.selectedIndex = index;
		_GameController.MoveIcon();
		_GameController.cameraObject.MoveCameraTo( _GameController.cameraObject.transform.position, _GameController.selectedUnit.transform.position );

	}

	public void selectedNextUnit(){
		moveTargetIcon.SetActive (false);
		myLine.gameObject.SetActive (false);
		_GameController.DestroyMovementRange ();
		int i = _GameController.selectedIndex;
		if( _GameController.GameState == 1 ){
			i += 1;
			if( i > _GameController.folk.Count-1 ){
				i = 0;
			} 
			int dCount = 0;
			while( !_GameController.folk[i].isActiveAndEnabled || _GameController.folk[i].turnComplete ){
				i++;
				if( i > _GameController.folk.Count-1 ){
					i = 0;
				} 
				dCount++;
				if( dCount == _GameController.folk.Count ){
					break;
				}
			}
			_GameController.selectedUnit = _GameController.folk[i];
			if( _GameController.selectedUnit.canMove ){
				_GameController.selectedUnit.movePressed = false;
			}
			_GameController.selectedIndex = i;
			_GameController.MoveIcon();
			_GameController.cameraObject.MoveCameraTo( _GameController.cameraObject.transform.position, _GameController.selectedUnit.transform.position );
		}
	}
	public void recursiveLayerSet(GameObject g, int layer ){
		g.layer = layer;
		foreach (Transform child in g.transform) {
			recursiveLayerSet(child.gameObject, layer) ;
		}
	}
	public void attackConfirmed(){
		Unit attackTarget = _GameController.selectedUnit.AttackTargets [_GameController.selectedUnit.currentAttackTarget];
		if (attackTarget.myCam != null) {
			recursiveLayerSet( attackTarget.gameObject, 16 );
			attackTarget.myCam.SetActive (true);
		}
		_GameController.selectedUnit.actionPoints--;
		_GameController.selectedUnit.hasAttacked = true;
		attackTarget.generateSound (_GameController.selectedUnit.currentPosition, _GameController.selectedUnit.myWeapon.GetComponent<weaponScript> ().soundRange);
		Vector2 tempFacing = attackTarget.currentPosition - _GameController.selectedUnit.currentPosition;
		tempFacing.Normalize();
		_GameController.selectedUnit.facing = new Vector3( tempFacing.x, 0, tempFacing.y );
		int rand = Random.Range (0, 100);
		
		//_GameController.selectedUnit.myFAnimCtrl.InitAttackAnim();
		_GameController.selectedUnit.isAttacking = true;
		Debug.Log ("FolkAnimCtrl Called");

		if (_GameController.selectedUnit.calcChanceToHit (_GameController.selectedUnit.getDistance (_GameController.selectedUnit.currentPosition, attackTarget.currentPosition)) > rand) {
			Debug.Log("HIT");
			attackTarget.myCam.GetComponent<ScreenShake>().shake = 2;
			attackTarget.myCam.GetComponent<ScreenShake>().shakeAmount = _GameController.selectedUnit.attackRating/100;
			GameObject tempObj = (GameObject) Instantiate ( dmgText, Camera.main.WorldToScreenPoint(attackTarget.gameObject.transform.position), Quaternion.identity );
			tempObj.gameObject.transform.SetParent(myCanvas.gameObject.transform);
			tempObj.GetComponent<Text>().text = ""+_GameController.selectedUnit.attackRating;
			tempObj.GetComponent<Text>().color = Color.red;
			Vector3 tempPosition = attackTarget.gameObject.transform.position;
			tempPosition.x = tempPosition.x+0.5f;
			tempPosition.y = 1.0f;
			tempPosition.z = tempPosition.z+0.5f;
			tempObj.transform.position = Camera.main.WorldToScreenPoint(tempPosition);
			_GameController.selectedUnit.Attack (attackTarget);
			_GameController.selectedUnit.hasAttacked = true;
			
			if (attackTarget.health <= 0) {
				_GameController.tiles [(int)attackTarget.currentPosition.x, (int)attackTarget.currentPosition.y] = 1;
				_GameController.elite.Remove (attackTarget);
				attackTarget.gameObject.SetActive (false);
			}
		} else {
			GameObject tempObj = (GameObject) Instantiate ( dmgText, Vector3.zero, Quaternion.identity );
			tempObj.gameObject.transform.SetParent(myCanvas.gameObject.transform);
			tempObj.GetComponent<Text>().text = "MISS";
			tempObj.GetComponent<Text>().color = Color.yellow;
			Vector3 tempPosition = attackTarget.gameObject.transform.position;
			tempPosition.x = tempPosition.x+0.5f;
			tempPosition.y = 1.0f;
			tempPosition.z = tempPosition.z+0.5f;
			tempObj.transform.position = Camera.main.WorldToScreenPoint(tempPosition);
			Debug.Log("Miss. #sadness #onlyFolkKidsWouldUnderstand");
		}
		attackConfirmedButton.gameObject.SetActive (false);
		_GameController.disableAttackBox();
	}

	public void moveConfirmed(){
		myLine.gameObject.SetActive (false);
		moveTargetIcon.gameObject.SetActive (false);
		_GameController.selectedUnit.Move(targetMovementPos);

		moveConfirmedButton.gameObject.SetActive (false);
	}
	
	public void selectAttackTarget(int x){
		_GameController.selectedUnit.currentAttackTarget += x;

		if (_GameController.selectedUnit.currentAttackTarget >= _GameController.selectedUnit.AttackTargets.Count) {
			_GameController.selectedUnit.currentAttackTarget = 0;
		} else if ( _GameController.selectedUnit.currentAttackTarget < 0 ) {
			_GameController.selectedUnit.currentAttackTarget = _GameController.selectedUnit.AttackTargets.Count-1;
		}
		_GameController.chanceToHitText.text = ""+ _GameController.selectedUnit.calcChanceToHit (_GameController.selectedUnit.getDistance (_GameController.selectedUnit.currentPosition, _GameController.selectedUnit.AttackTargets[_GameController.selectedUnit.currentAttackTarget].currentPosition));
		_GameController.attackIcon.selectUnit = _GameController.selectedUnit.AttackTargets [_GameController.selectedUnit.currentAttackTarget];
		
		_GameController.selectedUnit.AttackTargets[_GameController.selectedUnit.currentAttackTarget].gameObject.GetComponent<EnemyMouseOver>().infoObject.GetComponent<FollowMouse>().targetPosition = _GameController.selectedUnit.AttackTargets[_GameController.selectedUnit.currentAttackTarget].gameObject.transform.position;
		_GameController.selectedUnit.AttackTargets[_GameController.selectedUnit.currentAttackTarget].gameObject.GetComponent<EnemyMouseOver>().enableUI();
	}

	public void DrawLine(List<ExploreMode_GameController.Node> path){
		myLine.gameObject.SetActive (true);
		myLine.SetVertexCount (path.Count);
		int index = 0;
		foreach (ExploreMode_GameController.Node n in path) {
			myLine.SetPosition( index, new Vector3( n.x+0.5f, 0.1f, n.y+0.5f ) );
			index++;
		}
	}

}
