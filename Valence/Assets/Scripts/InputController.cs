using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputController : MonoBehaviour {

	public GameController _gameController;
    public NotificationController notificationController;
    TileMap _tileMap;
	generateZone _generateZone;

	Vector3 currentTile;

	Vector2 rootMousePos;

	GameObject myHoverObject;

    public List<GameObject> BuildingDatabase;

	public Material redMat, blueMat, yellowMat, greenMat;

	public GameObject foodBuild, waterBuild, powerBuild, shelterBuild, tavernBuild, hospitalBuild, trainingBuild;

	string currentColor;

	bool generate;

	public bool zoning;
    public bool scrapAlerted;

    string hoverState;

	public GUIController _GUIController;
	public GameObject _debugUI;

	public Collider lowerCollider1, lowerCollider2;

	bool isPause;

	public GameObject menuObj;

	void Start(){
		_tileMap = GetComponent<TileMap> ();
		_generateZone = GetComponent < generateZone >();
		//myHoverObject = (GameObject) Instantiate (Resources.Load("Tile"), new Vector3 (0, 0, 0), Quaternion.identity);
		generate = false;
		zoning = true;
		currentColor = "blue";

        BuildingDatabase = new List<GameObject>();

		_GUIController = GameObject.Find ("Canvas").GetComponent<GUIController> ();
        notificationController = GameObject.Find("NotificationController").GetComponent<NotificationController>();
    }

	public void selectedMaterial (string color){
		if (color == "blue") {
			MeshRenderer[] meshes = myHoverObject.GetComponentsInChildren<MeshRenderer> ();
			foreach( MeshRenderer m in meshes ){
				m.material = blueMat;
			}
			currentColor = "blue";
		} else if (color == "yellow") {
			MeshRenderer[] meshes = myHoverObject.GetComponentsInChildren<MeshRenderer> ();
			foreach( MeshRenderer m in meshes ){
				m.material = yellowMat;
			}
			currentColor = "yellow";
		} else if (color == "green") {
			MeshRenderer[] meshes = myHoverObject.GetComponentsInChildren<MeshRenderer> ();
			foreach( MeshRenderer m in meshes ){
				m.material = greenMat;
			}
			currentColor = "green";
		} else if (color == "red") {
			MeshRenderer[] meshes = myHoverObject.GetComponentsInChildren<MeshRenderer> ();
			foreach( MeshRenderer m in meshes ){
				m.material = redMat;
			}
			currentColor = "red";
		}
	}

	int getCurrentSize(){
		return getCurrentWidth() * getCurrentHeight ();
	}

	int getCurrentWidth(){
		float maxX, minX;
		if( rootMousePos.x < currentTile.x) {
			minX = rootMousePos.x;
			maxX = currentTile.x;
			
		} else {
			maxX = rootMousePos.x;
			minX = currentTile.x;
			maxX += 1;
			minX += 1;
		}
		return (int) ( maxX - minX );
	}

	int getCurrentHeight(){
		float maxY, minY;
		if( rootMousePos.y < currentTile.y) {
			minY = rootMousePos.y;
			maxY = currentTile.y;
			
		} else {
			maxY = rootMousePos.y;
			minY = currentTile.y;
			maxY += 1;
			minY += 1;
		}
		return (int) ( maxY - minY );
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPause = !isPause;
			if(isPause)
				Time.timeScale = 0;
			else
				Time.timeScale = 1;
		}

		if (isPause) {
			menuObj.SetActive (true);
		} else {
			menuObj.SetActive (false);
		}
	}

	public void pause(){
		isPause = !isPause;
		if(isPause)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
		if (isPause) {
			menuObj.SetActive (true);
		} else {
			menuObj.SetActive (false);
		}
	}

	public void saveGame(){
		_gameController.saveCurrentSettlement ();
	}

	public void loadLastSave(){
		Time.timeScale = 1;
		Application.LoadLevel (Application.loadedLevel);
	}

	public void quitGame(){
		Time.timeScale = 1;
		Application.Quit();
	}

	public void loadMainMenu(){
		Time.timeScale = 1;
		Application.LoadLevel (1);
	}

	void FixedUpdate () {
		if (Input.GetKey (KeyCode.BackQuote)) {
			if( _debugUI.activeSelf == true ){
				_debugUI.SetActive(false);
			} else {
				_debugUI.SetActive (true);
			}
		}
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitInfo;
		if (myHoverObject != null) {
			if (!IsOverlapping (myHoverObject, GameObject.FindGameObjectsWithTag ("prop")) && _gameController.scrap > 25 && !MouseEdge() ) {
				selectedMaterial("blue");
			} else {
				selectedMaterial("red");
			}
		}

		if ( GetComponent<Collider>().Raycast (ray, out hitInfo, Mathf.Infinity)) {
			Debug.DrawRay(ray.origin,ray.direction);
			int x = Mathf.FloorToInt( hitInfo.point.x  / _tileMap.tileSize );
			int y = Mathf.FloorToInt( hitInfo.point.y );
			int z = Mathf.FloorToInt( hitInfo.point.z / _tileMap.tileSize );
			//Debug.Log ("X: "+ x + "Y: "+ y +" Z: "+ z );
			currentTile.x = x;

            currentTile.y = 1; //Fixed the y value to 1 to let hoverobject remain flush to the floor -ZACH

            currentTile.z = z;

			//if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
			if( myHoverObject != null ){
				myHoverObject.transform.position = currentTile;
			}
			//}
		} else if( lowerCollider1.Raycast (ray, out hitInfo, Mathf.Infinity)) {
			Debug.DrawRay(ray.origin,ray.direction);
			int x = Mathf.FloorToInt( hitInfo.point.x  / _tileMap.tileSize );
			int y = Mathf.FloorToInt( hitInfo.point.y );
			int z = Mathf.FloorToInt( hitInfo.point.z / _tileMap.tileSize );
			//Debug.Log ("X: "+ x + "Y: "+ y +" Z: "+ z );
			currentTile.x = x;
			currentTile.y = y;
			currentTile.z = z;
			
			//if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
			myHoverObject.transform.position = currentTile;
		} else if( lowerCollider2.Raycast (ray, out hitInfo, Mathf.Infinity)) {
			Debug.DrawRay(ray.origin,ray.direction);
			int x = Mathf.FloorToInt( hitInfo.point.x  / _tileMap.tileSize );
			int y = Mathf.FloorToInt( hitInfo.point.y );
			int z = Mathf.FloorToInt( hitInfo.point.z / _tileMap.tileSize );
			//Debug.Log ("X: "+ x + "Y: "+ y +" Z: "+ z );
			currentTile.x = x;
			currentTile.y = y;
			currentTile.z = z;
			
			//if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
			if( myHoverObject != null )
				myHoverObject.transform.position = currentTile;
		}

		if (Input.GetMouseButtonDown (0) && !Input.GetKey ( KeyCode.LeftAlt )) {
			if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
				if( myHoverObject != null )
					myHoverObject.transform.position = new Vector3( currentTile.x, 0.1f, currentTile.y );
				rootMousePos = currentTile;
			}
		}
		if (Input.GetMouseButton (0) && !Input.GetKey ( KeyCode.LeftAlt )) {
			/// Zoning Stuff
//			if( zoning ){
//				if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
//					if( rootMousePos.x >= currentTile.x ){ myHoverObject.transform.position = new Vector3( rootMousePos.x + 1, 0.1f, myHoverObject.transform.position.y ); }
//					else { myHoverObject.transform.position = new Vector3( rootMousePos.x, 0.1f, myHoverObject.transform.position.y ); }
//					if( rootMousePos.y >= currentTile.y ){ myHoverObject.transform.position = new Vector3( myHoverObject.transform.position.x,0.1f, rootMousePos.y + 1 ); }
//					else { myHoverObject.transform.position = new Vector3(  myHoverObject.transform.position.x, 0.1f, rootMousePos.y ); }
////					int scaleX = (int) ( rootMousePos.x - currentTile.x );
////					int scaleY = (int) ( rootMousePos.y - currentTile.y );
////					if( scaleX == 0 ) { scaleX = 1; }
////					if( scaleY == 0 ) { scaleY = 1; }
////					myHoverObject.transform.localScale = new Vector3( -1 * scaleX, 1 , -1 * scaleY );
//
//				}
//				if( getCurrentSize() >= 25 && getCurrentWidth() >= 5 && getCurrentHeight() >= 5 ){
//					selectedMaterial( currentColor );
//					generate = true;
//				} else {
//					myHoverObject.GetComponentInChildren<MeshRenderer>().material = redMat;
//					generate = false;
//				}
//			}
		}
		if (Input.GetMouseButtonUp (0) && !Input.GetKey ( KeyCode.LeftAlt ) ) {

			Vector2 min;
			Vector2 max;

			if( rootMousePos.x < currentTile.x ){
				min.x = rootMousePos.x;
				max.x = currentTile.x;

			} else {
				max.x = rootMousePos.x;
				min.x = currentTile.x;
				max.x += 1;
				min.x += 1;
			}
			if( rootMousePos.y < currentTile.y ){
				min.y = rootMousePos.y;
				max.y = currentTile.y;
			} else {
				max.y = rootMousePos.y;
				min.y = currentTile.y;
				max.y += 1;
				min.y += 1;
			}
//			if( generate && zoning ){
//				_generateZone.setZoneSize( min , max );
//				_generateZone.Generate( _generateZone.getPropNum() );
//
//				foreach (GameObject obstcale in GameObject.FindGameObjectsWithTag("prop")) {
//					AstarPath.active.UpdateGraphs(obstcale.gameObject.GetComponent<Collider>().bounds);
//				} 
//			} else 
			if ( !zoning && !_gameController.randomEventController.eventActive){
				if (hoverState == "food"){
					if (_gameController.scrap >= 25 && !MouseEdge())
                    {
                        if (!IsOverlapping(myHoverObject, GameObject.FindGameObjectsWithTag("prop")))
                        {
                            _gameController.scrap -= 25;
                            GameObject tempObject = (GameObject)Instantiate(Resources.Load("Farm"), new Vector3(currentTile.x, currentTile.y, currentTile.z), Quaternion.identity);
                            tempObject.GetComponent<BuildingScript>().initBuildingType();
                            tempObject.GetComponent<BuildingScript>().beginProduction();

                            //Increase the list of current farms placed
                            _gameController.farmBuildingList.Add(tempObject);

                            //Add the newly placed building to building database
                            _gameController.buildingDatabase.Add(tempObject);

                            //Debug.Log ( tempObject.GetComponent<BuildingScript>().initProduction );

                            Destroy(myHoverObject);
                            myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
                            hoverState = "zone";

                            scrapAlerted = false;

                            //Makes the transparency back to default - Vishesh
                            _GUIController.setBuildingTypeName = "empty";

                            //Update agent pathfinding to account for this new obstical -Zach
                            foreach (GameObject obstcale in GameObject.FindGameObjectsWithTag("prop"))
                            {
                                AstarPath.active.UpdateGraphs(obstcale.gameObject.GetComponent<Collider>().bounds);
                            }

                            foreach (Transform child in tempObject.transform)
                            {
                                if (child.gameObject.tag == "buildTrans")
                                {
                                    child.gameObject.SetActive(false);
                                }
                                if (child.gameObject.tag == "buildMesh")
                                {
                                    child.gameObject.SetActive(true);
                                }
                            }
                        }
                    }
                    else if (!scrapAlerted){
                                              
                        notificationController.CreateNewNotification("No Scrap! Explore the metro to discover more scrap!");
                        scrapAlerted = true;

                        Destroy(myHoverObject);
                        myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
                        //hoverState = "zone";
                    }
				}
				if (hoverState == "water"){
					if (_gameController.scrap >= 25 && !MouseEdge()){
                        if (!IsOverlapping(myHoverObject, GameObject.FindGameObjectsWithTag("prop"))){
                            _gameController.scrap -= 25;
                            GameObject tempObject = (GameObject)Instantiate(Resources.Load("WaterStation"), new Vector3(currentTile.x, currentTile.y, currentTile.z), Quaternion.identity);
                            tempObject.GetComponent<BuildingScript>().initBuildingType();
                            tempObject.GetComponent<BuildingScript>().beginProduction();

							_gameController.waterBuildingList.Add(tempObject);
                            //Add the newly placed building to building database
							_gameController.buildingDatabase.Add(tempObject);

                            Destroy(myHoverObject);
							myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
							hoverState = "zone";

                            scrapAlerted = false;

                            _GUIController.setBuildingTypeName = "empty";
							
							//Update agent pathfinding to account for this new obstical -Zach
							foreach (GameObject obstcale in GameObject.FindGameObjectsWithTag("prop"))
                            {
                                AstarPath.active.UpdateGraphs(obstcale.gameObject.GetComponent<Collider>().bounds);
                            }

                            foreach (Transform child in tempObject.transform)
                            {
                                if (child.gameObject.tag == "buildTrans")
                                {
                                    child.gameObject.SetActive(false);
                                }
                                if (child.gameObject.tag == "buildMesh")
                                {
                                    child.gameObject.SetActive(true);
                                }
							}
                        }
                    }
                    else if (!scrapAlerted)
                    {

                        notificationController.CreateNewNotification("No Scrap! Explore the metro to discover more scrap!");
                        scrapAlerted = true;

                        Destroy(myHoverObject);
                        myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
                        //hoverState = "zone";
                    }

                }
				if (hoverState == "power"){
					if (_gameController.scrap >= 25 && !MouseEdge()){
                        if (!IsOverlapping(myHoverObject, GameObject.FindGameObjectsWithTag ("prop"))){
                            _gameController.scrap -= 25;
                            GameObject tempObject = (GameObject)Instantiate(Resources.Load ("PowerStation"), new Vector3(currentTile.x, currentTile.y - 1, currentTile.z), Quaternion.identity);
                            tempObject.GetComponent<BuildingScript>().initBuildingType();
                            tempObject.GetComponent<BuildingScript>().beginProduction();

							_gameController.powerBuildingList.Add(tempObject);
                            //Add the newly placed building to building database
							_gameController.buildingDatabase.Add(tempObject);

                            Destroy(myHoverObject);
							myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
							hoverState = "zone";

                            scrapAlerted = false;

                            _GUIController.setBuildingTypeName = "empty";
							
							//Update agent pathfinding to account for this new obstical -Zach
							foreach (GameObject obstcale in GameObject.FindGameObjectsWithTag("prop"))
                            {
                                AstarPath.active.UpdateGraphs(obstcale.gameObject.GetComponent<Collider>().bounds);
                            }

                            foreach (Transform child in tempObject.transform)
                            {
                                if (child.gameObject.tag == "buildTrans")
                                {
                                    child.gameObject.SetActive(false);
                                }
                                if (child.gameObject.tag == "buildMesh")
                                {
                                    child.gameObject.SetActive(true);
                                }
							}
                        }
                    }
                    else if (!scrapAlerted)
                    {

                        notificationController.CreateNewNotification("No Scrap! Explore the metro to discover more scrap!");
                        scrapAlerted = true;

                        Destroy(myHoverObject);
                        myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
                        //hoverState = "zone";
                    }
                }
				if (hoverState == "shelter") {
					if (_gameController.scrap >= 25 && !MouseEdge()) {
                        if (!IsOverlapping(myHoverObject, GameObject.FindGameObjectsWithTag("prop"))) {
                            _gameController.scrap -= 25;
                            GameObject tempObject = (GameObject)Instantiate(Resources.Load("Shelter"), new Vector3(currentTile.x, currentTile.y, currentTile.z), Quaternion.identity);
                            tempObject.GetComponent<BuildingScript>().initBuildingType();
                            tempObject.GetComponent<BuildingScript>().beginProduction();

                            //Add the newly placed building to building database
							_gameController.buildingDatabase.Add(tempObject);

                            Destroy(myHoverObject);
							myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
							hoverState = "zone";

                            scrapAlerted = false;

                            _GUIController.setBuildingTypeName = "empty";

							//Update agent pathfinding to account for this new obstical -Zach
							foreach (GameObject obstcale in GameObject.FindGameObjectsWithTag("prop")) {
                                AstarPath.active.UpdateGraphs(obstcale.gameObject.GetComponent<Collider>().bounds);
                            }

                            foreach (Transform child in tempObject.transform) {
                                if (child.gameObject.tag == "buildTrans") {
                                    child.gameObject.SetActive (false);
                                }
                                if (child.gameObject.tag == "buildMesh") {
                                    child.gameObject.SetActive (true);
                                }
                            }
                        }
                    }
                    else if (!scrapAlerted)
                    {

                        notificationController.CreateNewNotification("No Scrap! Explore the metro to discover more scrap!");
                        scrapAlerted = true;

                        Destroy(myHoverObject);
                        myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
                        //hoverState = "zone";
                    }
                }
				if (hoverState == "tavern") {
					if (_gameController.scrap >= 25 && !MouseEdge()) {
						if (!IsOverlapping(myHoverObject, GameObject.FindGameObjectsWithTag("prop"))) {
                            _gameController.scrap -= 25;
                            GameObject tempObject = (GameObject)Instantiate(Resources.Load("Tavern"), currentTile, Quaternion.identity);
                            tempObject.GetComponent<BuildingScript>().initBuildingType();
                            tempObject.GetComponent<BuildingScript>().beginProduction();

                            //Add the newly placed building to building database
							_gameController.buildingDatabase.Add(tempObject);

                            Destroy(myHoverObject);
							myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
							hoverState = "zone";

                            scrapAlerted = false;

                            _GUIController.setBuildingTypeName = "empty";
							
							//Update agent pathfinding to account for this new obstical -Zach

                            foreach (GameObject obstcale in GameObject.FindGameObjectsWithTag("prop")) {
                                AstarPath.active.UpdateGraphs(obstcale.gameObject.GetComponent<Collider>().bounds);
                            }

                            foreach (Transform child in tempObject.transform) {
                                if (child.gameObject.tag == "buildTrans") {
                                    child.gameObject.SetActive(false);
                                }
                                if (child.gameObject.tag == "buildMesh") {
                                    child.gameObject.SetActive(true);
                                }
                            }
                        }
                    }
                    else if (!scrapAlerted)
                    {

                        notificationController.CreateNewNotification("No Scrap! Explore the metro to discover more scrap!");
                        scrapAlerted = true;

                        Destroy(myHoverObject);
                        myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
                        //hoverState = "zone";
                    }
                }
                if (hoverState == "hospital")
                {
					if (_gameController.scrap >= 25 && !MouseEdge())
                    {
                        if (!IsOverlapping(myHoverObject, GameObject.FindGameObjectsWithTag("prop")))
                        {
                            _gameController.scrap -= 25;
                            GameObject tempObject = (GameObject)Instantiate(Resources.Load("Hospital"), new Vector3(currentTile.x, currentTile.y, currentTile.z), Quaternion.identity);
                            tempObject.GetComponent<BuildingScript>().initBuildingType();
                            tempObject.GetComponent<BuildingScript>().beginProduction();

                            //Add the newly placed building to building database
                            _gameController.buildingDatabase.Add(tempObject);

                            Destroy(myHoverObject);
                            myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
                            hoverState = "zone";

                            scrapAlerted = false;

                            _GUIController.setBuildingTypeName = "empty";

                            //Update agent pathfinding to account for this new obstical -Zach

                            foreach (GameObject obstcale in GameObject.FindGameObjectsWithTag("prop"))
                            {
                                AstarPath.active.UpdateGraphs(obstcale.gameObject.GetComponent<Collider>().bounds);
                            }

                            foreach (Transform child in tempObject.transform)
                            {
                                if (child.gameObject.tag == "buildTrans")
                                {
                                    child.gameObject.SetActive(false);
                                }
                                if (child.gameObject.tag == "buildMesh")
                                {
                                    child.gameObject.SetActive(true);
                                }
                            }
                        }
                    }
                    else if (!scrapAlerted)
                    {

                        notificationController.CreateNewNotification("No Scrap! Explore the metro to discover more scrap!");
                        scrapAlerted = true;

                        Destroy(myHoverObject);
                        myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
                        //hoverState = "zone";
                    }
                }
                if (hoverState == "training")
                {
                    if (_gameController.scrap >= 200 && !MouseEdge())
                    {
                        if (!IsOverlapping(myHoverObject, GameObject.FindGameObjectsWithTag("prop")))
                        {
                            _gameController.scrap -= 200;
                            GameObject tempObject = (GameObject)Instantiate(Resources.Load("TrainingArea"), new Vector3(currentTile.x, currentTile.y - 1, currentTile.z), Quaternion.identity);
                            tempObject.GetComponent<BuildingScript>().initBuildingType();
                            tempObject.GetComponent<BuildingScript>().beginProduction();

                            //Add the newly placed building to building database
                            _gameController.buildingDatabase.Add(tempObject);

                            Destroy(myHoverObject);
                            myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
                            hoverState = "zone";

                            scrapAlerted = false;

                            _GUIController.setBuildingTypeName = "empty";

                            //Update agent pathfinding to account for this new obstical -Zach

                            foreach (GameObject obstcale in GameObject.FindGameObjectsWithTag("prop"))
                            {
                                AstarPath.active.UpdateGraphs(obstcale.gameObject.GetComponent<Collider>().bounds);
                            }

                            foreach (Transform child in tempObject.transform)
                            {
                                if (child.gameObject.tag == "buildTrans")
                                {
                                    child.gameObject.SetActive(false);
                                }
                                if (child.gameObject.tag == "buildMesh")
                                {
                                    child.gameObject.SetActive(true);
                                }
                            }
                        }
                    }
                    else if (!scrapAlerted)
                    {

                        notificationController.CreateNewNotification("No Scrap! Explore the metro to discover more scrap!");
                        scrapAlerted = true;

                        Destroy(myHoverObject);
                        myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
                        //hoverState = "zone";
                    }
                }
            }
			if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= -50 && currentTile.z >= -40 ){
				if( myHoverObject != null )
					myHoverObject.transform.position = new Vector3( currentTile.x, 1, currentTile.z );
			}
		}

        if (Input.GetKey(KeyCode.Alpha0))
        {
            Debug.Log("None");
            zoning = false;
        }
        else if (_GUIController.setBuildingTypeName == "farm" || Input.GetKey(KeyCode.Alpha1))
        {
            if (hoverState != "food")
            {
                scrapAlerted = false;
                Destroy(myHoverObject);
                myHoverObject = (GameObject)Instantiate(foodBuild, new Vector3(0, 1, 0), Quaternion.identity);
                hoverState = "food";
            }
            zoning = false;
        }
        else if (_GUIController.setBuildingTypeName == "water" || Input.GetKey(KeyCode.Alpha2))
        {
            if (hoverState != "water")
            {
                scrapAlerted = false;
                Destroy(myHoverObject);
                myHoverObject = (GameObject)Instantiate(waterBuild, new Vector3(0, 0, 0), Quaternion.identity);
                hoverState = "water";
            }
            zoning = false;
        }
        else if (_GUIController.setBuildingTypeName == "power" || Input.GetKey(KeyCode.Alpha3))
        {
            if (hoverState != "power")
            {
                scrapAlerted = false;
                Destroy(myHoverObject);
                myHoverObject = (GameObject)Instantiate(powerBuild, new Vector3(0, 0, 0), Quaternion.identity);
                hoverState = "power";
            }
            zoning = false;
        }
        else if (_GUIController.setBuildingTypeName == "shelter" || Input.GetKey(KeyCode.Alpha4))
        {
            if (hoverState != "shelter")
            {
                scrapAlerted = false;
                Destroy(myHoverObject);
                myHoverObject = (GameObject)Instantiate(shelterBuild, new Vector3(0, 1, 0), Quaternion.identity);
                hoverState = "shelter";
            }
            zoning = false;
        }
        else if (_GUIController.setBuildingTypeName == "tavern" || Input.GetKey(KeyCode.Alpha5))
        {
            if (hoverState != "tavern")
            {
                scrapAlerted = false;
                Destroy(myHoverObject);
                myHoverObject = (GameObject)Instantiate(tavernBuild, new Vector3(0, 0, 0), Quaternion.identity);
                hoverState = "tavern";
            }
            zoning = false;
        }
        else if (_GUIController.setBuildingTypeName == "hospital" || Input.GetKey(KeyCode.Alpha5))
        {
            if (hoverState != "hospital")
            {
                scrapAlerted = false;
                Destroy(myHoverObject);
                myHoverObject = (GameObject)Instantiate(hospitalBuild, new Vector3(0, 0, 0), Quaternion.identity);
                hoverState = "hospital";
            }
            zoning = false;
        }
        else if (_GUIController.setBuildingTypeName == "training" || Input.GetKey(KeyCode.Alpha5))
        {
            if (hoverState != "training")
            {
                scrapAlerted = false;
                Destroy(myHoverObject);
                myHoverObject = (GameObject)Instantiate(trainingBuild, new Vector3(0, 0, 0), Quaternion.identity);
                hoverState = "training";
            }
            zoning = false;
        }
        else if (_GUIController.setBuildingTypeName == "Null" || Input.GetKey(KeyCode.Alpha9))
        {
            Destroy(myHoverObject);
            myHoverObject = (GameObject)Instantiate(Resources.Load("Tile"), new Vector3(0, 0, 0), Quaternion.identity);
            hoverState = "zone";
            //buildType = "Null";

            //Update agent pathfinding to account for this new obstical -Zach
        }


    }



    bool IsOverlapping(GameObject candidate, GameObject[] others)
    {
        foreach (GameObject other in others)
        {
            if (candidate.GetComponent<Collider>().bounds.Intersects(other.GetComponent<Collider>().bounds))
            {
                print("WOAHHHHHHH COLLISION!!!!!");
                return true;
            }
        }
        return false;
    }

	bool MouseEdge(){
		int scrollArea = Screen.width / 10;
		if (Input.mousePosition.x < scrollArea) {
			return true;
		}
		
		if (Input.mousePosition.x >= Screen.width - scrollArea) {
			return true;
		}
		
		if (Input.mousePosition.y < scrollArea) {
			return true;
		}
		
		if (Input.mousePosition.y > Screen.height - scrollArea) {
			return true;
		}

		return false;
	}
}