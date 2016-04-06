using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ExploreMode_GameController : MonoBehaviour {
	
	public int mapSize = 50;
	public int[,] tiles;
	public Node[,] graph;
	
	public TileType[] tileTypes;

	public List<Unit> folk = new List<Unit>();
	public List<Unit> elite = new List<Unit>();

	public Unit selectedUnit;
	public int selectedIndex;
	public SelectedIcon icon;
	public SelectedIcon attackIcon;

	public int currentElite = -1;
	public float bufferValue;
	public float currentTime;

	public bool newElite;
	public bool newAction;

	public GameObject[,] tileVisuals;
	public GameObject moveTile;
	public List<GameObject> moveTiles = new List<GameObject>();

	public List<Node> evaluatedPath = null;

	public GameObject pointObject;
	int[,] borderVectors;

	public int GameState;
	public Transform GUIFrame;
	public Fade playerTurnObject;
	public Fade enemyTurnObject;

	public CameraTargetController cameraObject;

	public Button moveButton, attackButton, pickUpButton, waitButton, undoButton;
	public Button attackSelectButton, attackNext, attackPrev;

	public List<Button> PartyButtons;

	public GameObject scrapObj;

	public Text chanceToHitText;
//
//	public Image actionPointGfx_01, actionPointGfx_02;
//	public List<Image> healthBar;

	public InputController_Explore _inputController;

	public Vector2 lastScrapPos;

	public Material redMat;

	public List<GameObject> maleModels;
	public List<GameObject> femaleModels;

	public List<Sprite> tileSprites;

	public Unit lastSelectedUnit;
	public Vector2 selectedUnitLastPos;
	public int selectedUnitOldMovementRemaining;
	public Vector3 selectedUnitTransformPosition;

	public Dictionary<Unit, Vector2> newKnownPositions;

	public AudioController _audioController;

	public List<GameObject> weaponDefaults;
	// Use this for initialization
	void Start () {

		_audioController = FindObjectOfType<AudioController> ().gameObject.GetComponent<AudioController> ();
		tiles = new int[mapSize,mapSize];
		tileVisuals = new GameObject[mapSize, mapSize];
		
		borderVectors = new int[mapSize, mapSize];

		GenerateNodeGraph ();

		for( int x = 0; x < mapSize; x++){
			for( int y = 0; y < mapSize; y++){
				int rand = (int) Random.Range( 0, 100 );
				if( rand < 100 ){
					tiles[x,y] = 1;
				} else{
					tiles[x,y] = 2;
				}
			}
		}
		Image myImg;
		GameState = 0;
		string filePath = "Weapons/";
		weaponDefaults.Add ( (GameObject) Resources.Load (filePath+"Weapon_Handgun", typeof(GameObject)));
		weaponDefaults.Add ( (GameObject) Resources.Load (filePath+"Weapon_Shotgun", typeof(GameObject)));
		weaponDefaults.Add ( (GameObject) Resources.Load (filePath+"Weapon_Rifle", typeof(GameObject)));

		if (PlayerDataManager.playerDataManager.isLive) {
			PlayerData dataCopy = PlayerDataManager.playerDataManager.loadSaveData ();
			int partyIndex = 0;
			
			Debug.Log ("Data Loaded");
			Debug.Log ("Party Count: " + dataCopy.currentParty.Count);
			foreach (serialAgent agent in dataCopy.currentParty) {

				Debug.Log ("Agent ID: " + agent.agentId );
				folk [partyIndex].agentId = agent.agentId;
				folk [partyIndex].unitName = agent.agentName;
				folk [partyIndex].health = Mathf.CeilToInt (agent.health / 10);
				folk [partyIndex].agility = agent.agility;
				folk [partyIndex].strength = agent.strength;
				folk [partyIndex].perception = agent.perception;

				GameObject modelObj;
				Debug.Log ("Object Instantiated!");
				if (agent.gender == "Male") {
					modelObj = (GameObject)Instantiate (maleModels [agent.myModelIndex], folk [partyIndex].transform.position, Quaternion.identity);
				} else if (agent.gender == "Female") {
					modelObj = (GameObject)Instantiate (femaleModels [agent.myModelIndex], folk [partyIndex].transform.position, Quaternion.identity);
				} else {
					modelObj = (GameObject)Instantiate (femaleModels [3], folk [partyIndex].transform.position, Quaternion.identity);
				}

				modelObj.transform.SetParent (folk [partyIndex].transform);
				modelObj.transform.position += new Vector3 (0.5f, 0.0f, 0.5f);

				//folk[partyIndex].myFAnimCtrl = modelObj.GetComponent<Animator>();
				Debug.Log ("AGENT WEAPON ID: " + agent.myWeapon.weaponId);
				if ( agent.myWeapon.weaponType == "Shotgun" ){
					folk[partyIndex].myWeapon = weaponDefaults[1];
					Debug.Log ("FOLK WEAPON SET");
				} else if ( agent.myWeapon.weaponType == "Rifle"){
					folk[partyIndex].myWeapon = weaponDefaults[2];
					Debug.Log ("FOLK WEAPON SET");
				} else {
					folk[partyIndex].myWeapon = weaponDefaults[0];
					Debug.Log ("FOLK WEAPON SET TO DEFUALT");
				}
				folk[partyIndex].myWeapon.GetComponent<weaponScript>().name = agent.myWeapon.weaponType;
				folk[partyIndex].myWeapon.GetComponent<weaponScript>().damageModifier = agent.myWeapon.damageModifier;
				folk[partyIndex].myWeapon.GetComponent<weaponScript>().accuracy = agent.myWeapon.accuracy;
				folk[partyIndex].myWeapon.GetComponent<weaponScript>().range = agent.myWeapon.range;
				folk[partyIndex].myWeapon.GetComponent<weaponScript>().rangeModifier = agent.myWeapon.rangeModifier;
				folk[partyIndex].myWeapon.GetComponent<weaponScript>().soundRange = agent.myWeapon.soundRange;

				partyIndex++;
			}
			
			if (partyIndex < 4 && partyIndex > 0) {
				for (int i = 3; i >= partyIndex; i--) {
					Destroy ( folk[i].gameObject );
					folk.Remove (folk[i]);
				}
			}
		} else {
			foreach( Unit fU in folk ){
				GameObject modelObj;
				modelObj = (GameObject)Instantiate (femaleModels [2], fU.transform.position, Quaternion.identity);
				modelObj.transform.SetParent (fU.transform);
				modelObj.transform.position += new Vector3 (0.5f, 0.0f, 0.5f);
			}

		}
		selectedUnit = folk [0];
		selectedIndex = 0;

		attackIcon.gameObject.SetActive (false);
		icon.selectUnit = selectedUnit;
		//GenerateMovementRange ((int)selectedUnit.currentPosition.x, (int)selectedUnit.currentPosition.y);

		GenerateMap();

		cameraObject.MoveCameraTo (cameraObject.transform.position, folk [0].transform.position);
//		while (PartyButtons.Count > folk.Count) {
//			Destroy( PartyButtons[PartyButtons.Count-1].gameObject );
//			PartyButtons.Remove (PartyButtons[PartyButtons.Count-1]);
//		}

		foreach( Unit fU in folk ){
			fU.turnComplete = false;
			fU.movementRemaining = fU.movement;
			fU.actionPoints = 2;
			fU.canMove = true;
			fU.movePressed = false;
			fU.attackPressed = false;
			fU.grabPressed = false;
			fU.waitPressed = false;
			fU.hasAttacked = false;
		}

	}

	// Update is called once per frame
	void Update () {
		bool scrapHeld = false;
		foreach (Unit fU in folk) {
			if( fU.hasScrap ){
				tiles [(int)lastScrapPos.x, (int)lastScrapPos.y] = 1;

				scrapHeld = true;
			}
		}
		if (!scrapHeld) {
			tiles [(int)lastScrapPos.x, (int)lastScrapPos.y] = 1;
			tiles [(int)scrapObj.transform.position.x, (int)scrapObj.transform.position.z] = 3;
			lastScrapPos = new Vector2 ((int)scrapObj.transform.position.x, (int)scrapObj.transform.position.z);
		}

		if( selectedUnit.movementRemaining > 0 && !selectedUnit.isMoving && GameState == 1){
			moveButton.interactable = true;
		} else {
			moveButton.interactable = false;
		} 
		if (selectedUnit != null) {
			if (canAttack (selectedUnit) && !selectedUnit.isMoving && !selectedUnit.hasScrap && !selectedUnit.hasAttacked && GameState == 1) {
				attackButton.interactable = true;
				if( selectedUnit.AttackTargets.Count >= 0 ){
					enableAttackBox (selectedUnit);
				} else {
					disableAttackBox();
				}
				_inputController.attackConfirmedButton.gameObject.SetActive (true);
				//_inputController.moveConfirmedButton.gameObject.SetActive (false);
				//selectedUnit.AttackTargets [selectedUnit.currentAttackTarget].gameObject.GetComponent<EnemyMouseOver> ().enableUI ();
				selectedUnit.attackPressed = true;
			} else {
				attackButton.interactable = false;
			}
		
		
		
			if (canPickUp (selectedUnit) && !selectedUnit.isMoving && GameState == 1) {
				pickUpButton.interactable = true;
			} else {
				pickUpButton.interactable = false;
			}
		
			if (selectedUnit.isMoving || GameState == 2) {
				waitButton.interactable = false;
			} else {
				waitButton.interactable = true;
			}
		
			if (selectedUnit.AttackTargets.Count > 0 && !selectedUnit.isMoving && GameState == 1) {
				attackSelectButton.interactable = true;
				attackNext.interactable = true;
				attackPrev.interactable = true;
				chanceToHitText.transform.parent.gameObject.SetActive (true);
				chanceToHitText.text = "" + (int)selectedUnit.calcChanceToHit (selectedUnit.getDistance (selectedUnit.currentPosition, selectedUnit.AttackTargets [selectedUnit.currentAttackTarget].currentPosition));
			} else {
				attackSelectButton.interactable = false;
				attackNext.interactable = false;
				attackPrev.interactable = false;
			}

			if (!selectedUnit.hasAttacked && lastSelectedUnit != null && GameState == 1) {
				undoButton.interactable = true;
			} else {
				undoButton.interactable = false;
			}
		}
		switch (GameState)
		{
		case 1:
			int movementRemaing = GetNumberOfPlayerUnits();
			foreach( Unit fU in folk ){
				if( fU.turnComplete == false ){
					break;
				} else {
					movementRemaing--;
				}
				
				if( movementRemaing == 0 ){
					enemyTurnObject.ReStart();
					GameState = 2; 
					foreach( Unit eU in elite ){
						currentElite = -1;
						eU.turnComplete = false;
						eU.canMove = true;
						selectedUnit = elite[0];
					}
				}
			}



			break;
		case 2:
			int eMovementRemaing = GetNumberOfEnemyUnits();
			bool EnemyTurnComplete = true;
			foreach( Unit eU in elite ){
				if( eU.isActiveAndEnabled ){
					if( eU.canMove == true ){
						break;
					} else {
						eMovementRemaing--;
					}

					if( !eU.turnComplete ){
						EnemyTurnComplete = false;
					}
				}
			}



			if( EnemyTurnComplete && eMovementRemaing <= 0){
				GameState = 1;
				playerTurnObject.ReStart();
				selectedUnit = folk[0];
				selectedIndex = 0;
				MoveIcon();
				cameraObject.MoveCameraTo( cameraObject.transform.position, selectedUnit.transform.position );
				foreach( Unit fU in folk ){
					fU.turnComplete = false;
					fU.movementRemaining = fU.movement;
					fU.actionPoints = 2;
					fU.canMove = true;
					fU.movePressed = false;
					fU.attackPressed = false;
					fU.grabPressed = false;
					fU.waitPressed = false;
					fU.hasAttacked = false;
				}
				lastSelectedUnit = null;
				break;
			} else {
				EnemyTurn();
			}

			break;
		default:
			GameState = 1;
			foreach( Unit fU in folk ){
				fU.canMove = true;
			}
			break;
		}

//		if (!selectedUnit.isElite && selectedUnit.actionPoints >= 2) {
//			actionPointGfx_01.gameObject.SetActive(true);
//			actionPointGfx_02.gameObject.SetActive(true);
//		} else if (!selectedUnit.isElite && selectedUnit.actionPoints == 1) {
//			actionPointGfx_01.gameObject.SetActive(true);
//			actionPointGfx_02.gameObject.SetActive(false);
//		} else {
//			actionPointGfx_01.gameObject.SetActive(false);
//			actionPointGfx_02.gameObject.SetActive(false);
//		}
//		if (!selectedUnit.isElite) {
//			foreach (Image i in healthBar) {
//				if (selectedUnit.health < healthBar.IndexOf (i) + 1) {
//					i.gameObject.SetActive (false);
//				} else {
//					i.gameObject.SetActive (true);
//				}
//			}
//		}
//
	}

	public class Node{
		public List<Node> neighbours;
		public Vector2 nodePos;
		public int x, y;

		public Node(){
			neighbours = new List<Node>();
		}
		
		public float DistanceTo(Node n) {
			if(n == null) {
				Debug.LogError("WTF?");
			}
			
			return Vector2.Distance(
				new Vector2(x, y),
				new Vector2(n.x, n.y)
				);
		}
	}
	public void DestroyMovementRange(){
		foreach( GameObject n in moveTiles){
			Destroy (n);
		}
		moveTiles.Clear ();
	}

	public void placeMovementTile(int i, int j){
		GameObject tempObject = (GameObject) Instantiate( moveTile , new Vector3(i,0,j), Quaternion.identity ); 
		tempObject.transform.SetParent( this.transform );
		moveTiles.Add( tempObject );
	}

	public bool checkIfTileAlreadyPlaced( int i, int j ){
		foreach (GameObject obj in moveTiles) {
			if( obj.transform.position.x == i && obj.transform.position.z == j ){
				return true;
			}
		}
		return false;
	}

	public void GenerateMovementRange(int x, int y){
		int[,] vectors = new int[mapSize,mapSize];

		foreach( GameObject n in moveTiles){
			Destroy (n);
		}
		moveTiles.Clear ();
		int pathingCalled = 0;
		int tilesPlaced = 0;
		
		Dictionary<Vector2,int> mTiles = new Dictionary<Vector2, int> ();

		for (int i = (int)selectedUnit.currentPosition.x-selectedUnit.movementRemaining; i <= (int)selectedUnit.currentPosition.x + selectedUnit.movementRemaining; i++) {
			for (int j=(int)selectedUnit.currentPosition.y -selectedUnit.movementRemaining; j <= (int)selectedUnit.currentPosition.y +selectedUnit.movementRemaining; j++) {
				if (i >= 0 && i < mapSize && j >= 0 && j < mapSize) {
					if (selectedUnit.withinMoveRange (new Vector2 (i, j))) {
						mTiles.Add ( new Vector2( i , j ), selectedUnit.getDistance (selectedUnit.currentPosition, new Vector2 (i, j)) );
					}
				}
			}
		}
		List<Vector2> vTiles = new List<Vector2>();
		int currentD = selectedUnit.movementRemaining;
		while (currentD > 0) {
			foreach (KeyValuePair<Vector2, int> entry in mTiles) {
				if( entry.Value == currentD ){
					int vX = (int) entry.Key.x;
					int vY = (int) entry.Key.y;
					if (!checkIfTileAlreadyPlaced (vX, vY)) {
						if (GeneratePathTo (vX, vY, 0)) {
							pathingCalled++;
							foreach (Node n in evaluatedPath) {
								if (!checkIfTileAlreadyPlaced ((int)n.nodePos.x, (int)n.nodePos.y)) {
									placeMovementTile ((int)n.nodePos.x, (int)n.nodePos.y);
									tilesPlaced++;
								}
							}
						}
					}
				}
			}
			currentD--;
		}
		borderVectors = vectors;

		foreach (GameObject g in moveTiles) {
			bool u = true;
			bool l = true;
			bool d = true;
			bool r = true;

			if( checkIfTileAlreadyPlaced( (int)g.transform.position.x + 1, (int)g.transform.position.z ) ){
				r = false;
			}
			if( checkIfTileAlreadyPlaced( (int)g.transform.position.x - 1,(int) g.transform.position.z ) ){
				l = false;
			}
			if( checkIfTileAlreadyPlaced( (int)g.transform.position.x,(int) g.transform.position.z + 1 ) ){
				u = false;
			}
			if( checkIfTileAlreadyPlaced((int) g.transform.position.x,(int) g.transform.position.z - 1 ) ){
				d = false;
			}

			if( u && r && d && l ){
				// 1111
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[0];
			} else if ( u && r && d && !l ){
				// 1110
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[1];
			} else if ( u && r && !d && !l ){
				// 1100
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[2];
			} else if ( u && !r && !d && !l ){
				// 1000
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[3];
			} else if ( u && !r && d && !l ){
				// 1010
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[4];
			} else if ( u && !r && d && l ){
				// 1011
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[5];
			} else if ( u && r && !d && l ){
				// 1101
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[6];
			} else if ( !u && r && d && l ){
				// 0111
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[7];
			} else if ( !u && r && d && !l ){
				// 0110
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[8];
			} else if ( !u && r && !d && !l ){
				// 0100
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[9];
			} else if ( !u && !r && d && l ){
				// 0011
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[10];
			} else if ( !u && !r && d && !l ){
				// 0010
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[11];
			} else if ( !u && !r && !d && l ){
				// 0001
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[12];
			} else if ( !u && r && !d && l ){
				// 0101
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[13];
			} else if ( u && !r && !d && l ){
				// 1001
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[14];
			} else {
				// 0000
				g.GetComponentInChildren<SpriteRenderer>().sprite = tileSprites[15];
			}
		}


	}
	public void GenerateMovementRange(int x, int y, Unit _unit){
		int[,] vectors = new int[mapSize,mapSize];
		Unit tempUnit = selectedUnit;
		selectedUnit = _unit;
		foreach( GameObject n in moveTiles){
			Destroy (n);
		}
		moveTiles.Clear ();
		int pathingCalled = 0;
		int tilesPlaced = 0;
		
		Dictionary<Vector2,int> mTiles = new Dictionary<Vector2, int> ();
		
		for (int i = (int)_unit.currentPosition.x-selectedUnit.movementRemaining; i <= (int)_unit.currentPosition.x + selectedUnit.movementRemaining; i++) {
			for (int j=(int)_unit.currentPosition.y -selectedUnit.movementRemaining; j <= (int)_unit.currentPosition.y +selectedUnit.movementRemaining; j++) {
				if (i >= 0 && i < mapSize && j >= 0 && j < mapSize) {
					if (_unit.withinMoveRange (new Vector2 (i, j))) {
						mTiles.Add ( new Vector2( i , j ), _unit.getDistance (_unit.currentPosition, new Vector2 (i, j)) );
					}
				}
			}
		}
		List<Vector2> vTiles = new List<Vector2>();
		int currentD = _unit.movementRemaining;
		while (currentD > 0) {
			foreach (KeyValuePair<Vector2, int> entry in mTiles) {
				if( entry.Value == currentD ){
					int vX = (int) entry.Key.x;
					int vY = (int) entry.Key.y;
					if (!checkIfTileAlreadyPlaced (vX, vY)) {
						if (GeneratePathTo (vX, vY, 0)) {
							pathingCalled++;
							foreach (Node n in evaluatedPath) {
								if (!checkIfTileAlreadyPlaced ((int)n.nodePos.x, (int)n.nodePos.y)) {
									placeMovementTile ((int)n.nodePos.x, (int)n.nodePos.y);
									tilesPlaced++;
								}
							}
						}
					}
				}
			}
			currentD--;
		}
		borderVectors = vectors;

		foreach (GameObject mTile in moveTiles) {
			mTile.GetComponentInChildren<SpriteRenderer>().color = Color.red;
		}

		selectedUnit = tempUnit;
		
	}
	public void GenerateMap(){
		for( int x = 0; x < mapSize; x++){
			for( int y = 0; y < mapSize; y++){
				/**
				TileType tt = tileTypes[ tiles[x,y] ];
				GameObject tileVisual = (GameObject) Instantiate ( tt.visualPrefab, new Vector3( x+0.5f, 0 , y+0.5f ), Quaternion.identity );
				tileVisual.transform.SetParent(this.gameObject.transform);
				tileVisuals[x,y] = tileVisual;
				**/
			}
		}
	}

	void GenerateNodeGraph(){
		graph = new Node[mapSize, mapSize];
		for (int x=0; x < mapSize; x++) {
			for (int y=0; y < mapSize; y++) {
				graph [x, y] = new Node ();
			}
		}
		for (int x=0; x < mapSize; x++) {
			for( int y=0; y < mapSize; y++){
				graph[x,y].nodePos = new Vector2(x,y);
				graph[x,y].x = x;
				graph[x,y].y = y;
				if( x > 0 )
					graph[x,y].neighbours.Add ( graph[x-1, y ] );
				if( x < mapSize - 1 )
					graph[x,y].neighbours.Add (graph[x+1, y ] );
				if( y > 0 )
					graph[x,y].neighbours.Add (graph[x, y-1 ] );
				if( y < mapSize - 1 )
					graph[x,y].neighbours.Add (graph[x, y+1 ] );
			}
		}

	}
	public void MoveIcon(){
		icon.selectUnit = selectedUnit;
		//selectedUnit.canMove = true;
	}

	public void GeneratePathTo(int x, int y) {
		// Clear out our unit's old path.
		selectedUnit.currentPath = null;
		if( UnitCanEnterTile(x,y) == false ) {

			// We probably clicked on a mountain or something, so just quit out.
			return;
		}
		
		Dictionary<Node, float> dist = new Dictionary<Node, float>();
		Dictionary<Node, Node> prev = new Dictionary<Node, Node>();
		
		// Setup the "Q" -- the list of nodes we haven't checked yet.
		List<Node> unvisited = new List<Node>();
		
		Node source = graph[
		                    (int) selectedUnit.currentPosition.x, 
		                    (int) selectedUnit.currentPosition.y
		                    ];
		
		Node target = graph[
		                    x, 
		                    y
		                    ];
		
		dist[source] = 0;
		prev[source] = null;
		
		// Initialize everything to have INFINITY distance, since
		// we don't know any better right now. Also, it's possible
		// that some nodes CAN'T be reached from the source,
		// which would make INFINITY a reasonable value
		foreach(Node v in graph) {
			if(v != source) {
				dist[v] = Mathf.Infinity;
				//dist[v] = selectedUnit.movement;
				prev[v] = null;
			}
			
			unvisited.Add(v);
		}
		
		while(unvisited.Count > 0) {
			// "u" is going to be the unvisited node with the smallest distance.
			Node u = null;
			
			foreach(Node possibleU in unvisited) {
				if(u == null || dist[possibleU] < dist[u]) {
					u = possibleU;
				}
			}
			
			if(u == target) {
				break;	// Exit the while loop!
			}
			
			unvisited.Remove(u);
			
			foreach(Node v in u.neighbours) {
				//float alt = dist[u] + u.DistanceTo(v);
				float alt = dist[u] + CostToEnterTile(u.x, u.y, v.x, v.y);
				if( alt < dist[v] && alt <= selectedUnit.movement ) {
					dist[v] = alt;
					prev[v] = u;
				}
			}
		}
		
		// If we get there, the either we found the shortest route
		// to our target, or there is no route at ALL to our target.
		
		if(prev[target] == null) {
			// No route between our target and the source
			return;
		}
		
		List<Node> currentPath = new List<Node>();
		
		Node curr = target;
		
		// Step through the "prev" chain and add it to our path
		while(curr != null) {
			currentPath.Add(curr);
			curr = prev[curr];
		}
		
		// Right now, currentPath describes a route from out target to our source
		// So we need to invert it!
		
		currentPath.Reverse();
		selectedUnit.currentPath = currentPath;
		/**
		if (currentPath.Count - 1 <= selectedUnit.movement) {
			selectedUnit.currentPath = currentPath;
		}
		**/
	}

	public bool GeneratePathTo(int x, int y, int w ) {
		// Clear out our unit's old path.
		selectedUnit.currentPath = null;
		if( UnitCanEnterTile(x,y) == false ) {
			// We probably clicked on a mountain or something, so just quit out.
			return false;
		}
		
		Dictionary<Node, float> dist = new Dictionary<Node, float>();
		Dictionary<Node, Node> prev = new Dictionary<Node, Node>();
		
		// Setup the "Q" -- the list of nodes we haven't checked yet.
		List<Node> unvisited = new List<Node>();
		
		Node source = graph[
		                    (int) selectedUnit.currentPosition.x, 
		                    (int) selectedUnit.currentPosition.y
		                    ];
		
		Node target = graph[
		                    x, 
		                    y
		                    ];
		
		dist[source] = 0;
		prev[source] = null;
		
		// Initialize everything to have INFINITY distance, since
		// we don't know any better right now. Also, it's possible
		// that some nodes CAN'T be reached from the source,
		// which would make INFINITY a reasonable value
		foreach(Node v in graph) {
			if(v != source) {
				dist[v] = Mathf.Infinity;
				//dist[v] = selectedUnit.movement;
				prev[v] = null;
			}
			
			unvisited.Add(v);
		}
		
		while(unvisited.Count > 0) {
			// "u" is going to be the unvisited node with the smallest distance.
			Node u = null;
			
			foreach(Node possibleU in unvisited) {
				if(u == null || dist[possibleU] < dist[u]) {
					u = possibleU;
				}
			}
			
			if(u == target) {
				break;	// Exit the while loop!
			}
			
			unvisited.Remove(u);
			
			foreach(Node v in u.neighbours) {
				//float alt = dist[u] + u.DistanceTo(v);
				float alt = dist[u] + CostToEnterTile(u.x, u.y, v.x, v.y);
				if( alt < dist[v] && alt <= selectedUnit.movement  ) {
					dist[v] = alt;
					prev[v] = u;
				}
			}
		}
		
		// If we get there, the either we found the shortest route
		// to our target, or there is no route at ALL to our target.
		
		if (prev [target] == null) {
			// No route between our target and the source
			return false;
		}
		
		List<Node> currentPath = new List<Node>();
		
		Node curr = target;
		
		// Step through the "prev" chain and add it to our path
		while(curr != null) {
			currentPath.Add(curr);
			curr = prev[curr];
		}
		// Right now, currentPath describes a route from out target to our source
		// So we need to invert it!
		
		//currentPath.Reverse();
		if (currentPath.Count - 1 <= selectedUnit.movement) {
			evaluatedPath = currentPath;
			return true;
		} else {
			return false;
		}
		
	}

	public List<Node> GenerateNodePath(int x, int y ){
		// Clear out our unit's old path.
		selectedUnit.currentPath = null;
		if( UnitCanEnterTile(x,y) == false ) {
			// We probably clicked on a mountain or something, so just quit out.
			return null;
		}
		
		Dictionary<Node, float> dist = new Dictionary<Node, float>();
		Dictionary<Node, Node> prev = new Dictionary<Node, Node>();
		
		// Setup the "Q" -- the list of nodes we haven't checked yet.
		List<Node> unvisited = new List<Node>();
		
		Node source = graph[
		                    (int) selectedUnit.currentPosition.x, 
		                    (int) selectedUnit.currentPosition.y
		                    ];
		
		Node target = graph[
		                    x, 
		                    y
		                    ];
		
		dist[source] = 0;
		prev[source] = null;
		
		// Initialize everything to have INFINITY distance, since
		// we don't know any better right now. Also, it's possible
		// that some nodes CAN'T be reached from the source,
		// which would make INFINITY a reasonable value
		foreach(Node v in graph) {
			if(v != source) {
				dist[v] = Mathf.Infinity;
				//dist[v] = selectedUnit.movement;
				prev[v] = null;
			}
			
			unvisited.Add(v);
		}
		
		while(unvisited.Count > 0) {
			// "u" is going to be the unvisited node with the smallest distance.
			Node u = null;
			
			foreach(Node possibleU in unvisited) {
				if(u == null || dist[possibleU] < dist[u]) {
					u = possibleU;
				}
			}
			
			if(u == target) {
				break;	// Exit the while loop!
			}
			
			unvisited.Remove(u);
			
			foreach(Node v in u.neighbours) {
				//float alt = dist[u] + u.DistanceTo(v);
				float alt = dist[u] + CostToEnterTile(u.x, u.y, v.x, v.y);
				if( alt < dist[v] ) {
					dist[v] = alt;
					prev[v] = u;
				}
			}
		}
		
		// If we get there, the either we found the shortest route
		// to our target, or there is no route at ALL to our target.
		
		if (prev [target] == null) {
			// No route between our target and the source
			return null;
		}
		
		List<Node> currentPath = new List<Node>();
		
		Node curr = target;
		
		// Step through the "prev" chain and add it to our path
		while(curr != null) {
			currentPath.Add(curr);
			curr = prev[curr];
		}
		// Right now, currentPath describes a route from out target to our source
		// So we need to invert it!
		
		//currentPath.Reverse();
		return currentPath;
	}

	public float CostToEnterTile(int sourceX, int sourceY, int targetX, int targetY) {
		
		TileType tt = tileTypes[ tiles[targetX,targetY] ];
		if(UnitCanEnterTile(targetX, targetY) == false)
			return Mathf.Infinity;
		
		float cost = tt.movementCost;
		
		if( sourceX!=targetX && sourceY!=targetY) {
			// We are moving diagonally!  Fudge the cost for tie-breaking
			// Purely a cosmetic thing!
			cost += 0.001f;
		}
		//Debug.Log (cost);
		return cost;
		
	}

	public bool UnitCanEnterTile(int x, int y) {
		
		// We could test the unit's walk/hover/fly type against various
		// terrain flags here to see if they are allowed to enter the tile.
		return tileTypes[ tiles[x,y] ].isWalkable;
	}
	

	public void EnemyTurn(){
		bool nextElite = false;

		if (currentElite == -1) {
			nextElite = true;
		}

		updateBuffer ();

		if (checkBuffer () && newElite ) {
			Debug.Log ( "Movement" );
			elite[currentElite].EliteObserve();
			elite[currentElite].EliteDetermineState();
			elite[currentElite].Move (elite[currentElite].EliteCalcOptMoveTile());
			elite[currentElite].canMove = false;
			newElite = false;
			newAction = true;

			if( elite[currentElite].FolkUnitsWithinView.Count > 0 ){
				elite[currentElite].FolkUnitsWithinView[0].gameObject.GetComponent<EnemyMouseOver> ().enableUI ();
				attackIcon.gameObject.SetActive(true);
				attackIcon.selectUnit = elite[currentElite].FolkUnitsWithinView[0];
			}

			if( elite[currentElite].EliteBehaviour == "Guard" && elite[currentElite].EliteState == 1 ){
				startBuffer(0);
			} else {
				startBuffer(2);
			}
		} 



		if (checkBuffer () && newAction) {
			Debug.Log ( "Action" );
			if( elite[currentElite].FolkUnitsWithinView.Count > 0 ){
				float rand = Random.Range (0, 100);

				elite[currentElite].myAnimCtrl.InitAttackAnim();
				if( elite[currentElite].calcChanceToHit(elite[currentElite].getDistance(elite[currentElite].currentPosition, elite[currentElite].FolkUnitsWithinView[0].currentPosition)) > rand){
					GameObject tempObj = (GameObject) Instantiate ( _inputController.dmgText, Camera.main.WorldToScreenPoint(elite[currentElite].FolkUnitsWithinView[0].gameObject.transform.position), Quaternion.identity );
					tempObj.gameObject.transform.SetParent(_inputController.myCanvas.gameObject.transform);
					tempObj.GetComponent<Text>().text = ""+elite[currentElite].attackRating;
					tempObj.GetComponent<Text>().color = Color.red;
					Vector3 tempPosition = elite[currentElite].FolkUnitsWithinView[0].gameObject.transform.position;
					tempPosition.x = tempPosition.x+0.5f;
					tempPosition.y = 1.0f;
					tempPosition.z = tempPosition.z+0.5f;
					tempObj.transform.position = Camera.main.WorldToScreenPoint(tempPosition);
					elite[currentElite].Attack (elite[currentElite].FolkUnitsWithinView[0]);
					if(  elite[currentElite].myWeapon.name == "Weapon_Handgun" )
						_audioController.playAudioClipOnce (0, elite[currentElite].transform.position, 20);
					if(  elite[currentElite].myWeapon.name == "Weapon_Rifle" )
						_audioController.playAudioClipOnce (1, elite[currentElite].transform.position, 20);
					if(  elite[currentElite].myWeapon.name == "Weapon_Shotgun" )
						_audioController.playAudioClipOnce (2, elite[currentElite].transform.position, 20);
					// HIT
				} else{
					GameObject tempObj = (GameObject) Instantiate ( _inputController.dmgText, Vector3.zero, Quaternion.identity );
					tempObj.gameObject.transform.SetParent(_inputController.myCanvas.gameObject.transform);
					tempObj.GetComponent<Text>().text = "MISS";
					tempObj.GetComponent<Text>().color = Color.yellow;
					Vector3 tempPosition = elite[currentElite].FolkUnitsWithinView[0].gameObject.transform.position;
					tempPosition.x = tempPosition.x+0.5f;
					tempPosition.y = 1.0f;
					tempPosition.z = tempPosition.z+0.5f;
					tempObj.transform.position = Camera.main.WorldToScreenPoint(tempPosition);
					_audioController.playAudioClipOnce (2, elite[currentElite].transform.position, 20);
					// MISS 
				}
				if( currentElite < elite.Count-1 && ( elite[currentElite+1].EliteBehaviour == "Guard" && elite[currentElite+1].EliteState == 1 ) ){
					startBuffer(0);
				} else {
					startBuffer(2);
				}
				attackIcon.gameObject.SetActive(false);
			}

			elite[currentElite].turnComplete = true;
			newAction = false;
			newElite = false;
			nextElite = true;
		}

		
		
		if (nextElite) {
			currentElite++;
			int whileCount = 0;
			
			if( currentElite >= GetNumberOfEnemyUnits() ){
				currentElite = 0;
			}

			while( !elite[currentElite].isActiveAndEnabled ){
				currentElite++;
				if( currentElite >= GetNumberOfEnemyUnits() ){
					currentElite = 0;
				}
			}
			selectedUnit = elite[ currentElite ];
			newElite = true;
			nextElite = false;
			
			cameraObject.MoveCameraTo(cameraObject.transform.position, elite[currentElite].transform.position);
			startBuffer(2);
		}
	}

	void startBuffer( int bufferLength ){
		bufferValue = bufferLength;
		currentTime = 0;
	}

	void updateBuffer(){
		if( !selectedUnit.isMoving )
			currentTime += Time.deltaTime;
	}

	bool checkBuffer(){
		if (currentTime >= bufferValue) {
			return true;
			bufferValue = 0;
			currentTime = 0;
		}
		return false;
	}

	public int GetNumberOfPlayerUnits(){
		int count = 0;
		foreach (Unit fU in folk) {
			if( fU.isActiveAndEnabled ){
				count++;
			}
		}
		return count;
	}

	public int GetNumberOfEnemyUnits(){
		int count = 0;
		foreach (Unit eU in elite) {
			if( eU.isActiveAndEnabled ){
				count++;
			}
		}
		return count;
	}

	public bool canAttack(Unit fU){
		foreach (Unit eU in elite) {
			if( eU.health > 0 ){
				if( fU.isWithinAttackRange(eU) ){
					if( fU.actionPoints >= 1 && !fU.hasAttacked ){
						return true;
					}
				}
			}
		}
		return false;
	}

	public bool canPickUp(Unit myUnit){
		if (selectedUnit.getDistance (selectedUnit.currentPosition, new Vector2(scrapObj.transform.position.x, scrapObj.transform.position.z)) <= 1) {
			return true;
		} else {
			return false;
		}
	}

	public void enableAttackBox(Unit fU){
		selectedUnit.AttackTargets.Clear ();
		foreach (Unit eU in elite) {
			if( fU.isWithinAttackRange(eU) ){
				if( eU.health > 0 ){
					selectedUnit.AttackTargets.Add(eU);
					selectedUnit.currentAttackTarget = 0;
					/**
					Transform[] eUChildren = eU.GetComponentsInChildren<Transform>(true);
					foreach( Transform ob in eUChildren ){
						if ( ob.tag == "enemyTouchBox" ){
							ob.gameObject.SetActive(true);
						}
					}**/
				}
			}
		}
		attackIcon.gameObject.SetActive (true);
		attackIcon.selectUnit = selectedUnit.AttackTargets [0];
		selectedUnit.AttackTargets[0].GetComponent<EnemyMouseOver> ().enableUI ();
	}
	public void disableAttackBox(){
		selectedUnit.AttackTargets.Clear();
		selectedUnit.attackPressed = false;
		chanceToHitText.gameObject.transform.parent.gameObject.SetActive (false);
		attackIcon.gameObject.SetActive (false);
		chanceToHitText.text = "X";
		_inputController.attackConfirmedButton.gameObject.SetActive (false);
//		foreach (Unit eU in elite) {
//			if( Vector3.Distance ( eU.transform.position, selectedUnit.transform.position ) <= 5 ){
//				Transform[] eUChildren = eU.GetComponentsInChildren<Transform>(true);
//				foreach( Transform ob in eUChildren ){
//					if ( ob.tag == "enemyTouchBox" ){
//						ob.gameObject.SetActive(false);
//					}
//				}
//			}
//		}
	}

	public void selectedNextUnit(){
		DestroyMovementRange ();
		disableAttackBox ();
		int i = selectedIndex;
		if( GameState == 1 ){
			i += 1;
			if( i > GetNumberOfPlayerUnits()-1 ){
				i = 0;
			} 
			int dCount = 0;
			while( !folk[i].isActiveAndEnabled && folk[i].actionPoints > 0 ){
				i++;
				if( i > GetNumberOfPlayerUnits()-1 ){
					i = 0;
				} 
				dCount++;
				if( dCount == GetNumberOfPlayerUnits() ){
					//GameOver
					Debug.Log ("GAMEOVER");
					//break;
				}
			}
			selectedUnit = folk[i];
			if( selectedUnit.canMove ){
				selectedUnit.movePressed = false;
			}
			selectedIndex = i;
			MoveIcon();
			cameraObject.MoveCameraTo( cameraObject.transform.position, selectedUnit.transform.position );
			
		}
	}
	public void selectSelectedUnit(Unit newUnit){
		DestroyMovementRange ();
		disableAttackBox ();
		selectedUnit.gameObject.GetComponent<EnemyMouseOver> ().infoObject.SetActive (false);
		if( GameState == 1 ){
			selectedUnit = newUnit;
			_inputController.currentTile = selectedUnit.currentPosition;
			if( selectedUnit.canMove ){
				selectedUnit.movePressed = false;
			}
			selectedIndex = folk.IndexOf(newUnit);
			MoveIcon();
			cameraObject.MoveCameraTo( cameraObject.transform.position, selectedUnit.transform.position );
			
		}
	}

	public void undoLastMove(){
		selectedUnit = lastSelectedUnit;
		selectedUnit.canMove = true;
		selectedUnit.turnComplete = false;

		foreach (Unit eU in elite) {
			if( eU.knownPosition.Contains ( selectedUnit.currentPosition ) ){
				eU.knownPosition.Remove (selectedUnit.currentPosition);
				eU.FolkUnitsWithinView.Remove (selectedUnit);
			}
		}

		disableAttackBox (); 

		tiles [(int)selectedUnit.currentPosition.x,(int)selectedUnit.currentPosition.y] = 1;
		selectedUnit.transform.position = selectedUnitTransformPosition;
		selectedUnit.currentPosition = selectedUnitLastPos;
		selectedUnit.movementRemaining = selectedUnitOldMovementRemaining;
		GenerateMovementRange ((int)selectedUnit.currentPosition.x,(int)selectedUnit.currentPosition.y);



		lastSelectedUnit = null;
	}

}
