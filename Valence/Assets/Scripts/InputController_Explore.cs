using UnityEngine;
using System.Collections;

public class InputController_Explore : MonoBehaviour {
	TileMap _tileMap;
	generateZone _generateZone;
	public ExploreMode_GameController _GameController;
	public FolkUnit _myFolkUnit;
	
	Vector2 currentTile;
	
	Vector2 rootMousePos;
	
	GameObject myHoverObject;
	
	public Material redMat, blueMat, yellowMat, greenMat;
	
	string currentColor;
	
	bool generate;
	
	void Start(){
		_tileMap = GetComponent<TileMap> ();
		myHoverObject = (GameObject) Instantiate (Resources.Load("Tile"), new Vector3 (0, 0, 0), Quaternion.identity);

		currentColor = "blue";
	}
	
	
	public void selectedMaterial( string color ){
		if (color == "blue") {
			myHoverObject.GetComponentInChildren<MeshRenderer> ().material = blueMat;
			currentColor = "blue";
		} else if (color == "yellow") {
			myHoverObject.GetComponentInChildren<MeshRenderer> ().material = yellowMat;
			currentColor = "yellow";
		} else if (color == "green") {
			myHoverObject.GetComponentInChildren<MeshRenderer> ().material = greenMat;
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
				myHoverObject.transform.position = new Vector3( currentTile.x, 0, currentTile.y );
			}
			
		} else {
			
		}

		if( Input.GetMouseButton(0) ){

			if( _GameController.selectedUnit.canMove && _GameController.GameState == 1 && _GameController.selectedUnit.movePressed ){
				if( _GameController.selectedUnit.withinMoveRange( currentTile ) ){
					_GameController.selectedUnit.Move(currentTile);
					foreach( GameObject n in _GameController.moveTiles){
						Destroy (n);
					}
					_GameController.moveTiles.Clear();
					_GameController.selectedUnit.movePressed = false;
				} else {
					// not within range
				}
			}
		}

		if (Input.GetKeyDown (KeyCode.Return)) {
			selectedNextUnit ();

		}
	}

	public void MoveSelectedUnit( ){
		_GameController.selectedUnit.movePressed = true;
		_GameController.GenerateMovementRange((int)_GameController.selectedUnit.currentPosition.x, (int)_GameController.selectedUnit.currentPosition.y);
	}

	public void AttackWithSelectedUnit(){
		_GameController.selectedUnit.attackPressed = true;
		_GameController.enableAttackBox (_GameController.selectedUnit);
	}

	public void WaitSelectedUnit(){
		_GameController.selectedUnit.waitPressed = true;
		_GameController.selectedUnit.canMove = false;
		selectedNextUnit ();
	}

	public void selectedNextUnit(){
		_GameController.DestroyMovementRange ();
		int i = _GameController.selectedIndex;
		if( _GameController.GameState == 1 ){
			i += 1;
			if( i > 3 ){
				i = 0;
			} 
			int dCount = 0;
			while( !_GameController.folk[i].isActiveAndEnabled ){
				i++;
				if( i > 3 ){
					i = 0;
				} 
				dCount++;
				if( dCount == 4 ){
					//GameOver
					break;
				}
			}
			_GameController.selectedUnit = _GameController.folk[i];
			if( _GameController.selectedUnit.canMove ){
				_GameController.selectedUnit.movePressed = false;
			}
			//_GameController.GenerateMovementRange((int)_GameController.selectedUnit.currentPosition.x, (int)_GameController.selectedUnit.currentPosition.y);
			_GameController.selectedIndex = i;
			_GameController.MoveIcon();
			_GameController.cameraObject.MoveCameraTo( _GameController.cameraObject.transform.position, _GameController.selectedUnit.transform.position );
			
			//					_GameController.selectedUnit = _GameController.folk[i];
			//					_GameController.GenerateMovementRange((int)_GameController.selectedUnit.currentPosition.x,(int) _GameController.selectedUnit.currentPosition.y);
			//					_GameController.MoveIcon();
			//					_GameController.selectedIndex = i;
			//					_GameController.cameraObject.MoveCameraTo( _GameController.cameraObject.transform.position, _GameController.selectedUnit.transform.position );
		}
	}

}
