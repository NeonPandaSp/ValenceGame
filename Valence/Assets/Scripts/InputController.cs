using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	TileMap _tileMap;
	generateZone _generateZone;

	Vector2 currentTile;

	Vector2 rootMousePos;

	GameObject myHoverObject;

	void Start(){
		_tileMap = GetComponent<TileMap> ();
		_generateZone = GetComponent < generateZone >();
		myHoverObject = (GameObject) Instantiate (Resources.Load("Tile"), new Vector3 (0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitInfo;

		if ( GetComponent<Collider>().Raycast (ray, out hitInfo, Mathf.Infinity)) {
			int x = Mathf.FloorToInt( hitInfo.point.x  / _tileMap.tileSize );
			int z = Mathf.FloorToInt( hitInfo.point.z / _tileMap.tileSize );
			Debug.Log( x + " " + z );
			currentTile.x = x;
			currentTile.y = z;

			if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
				myHoverObject.transform.position = new Vector3( currentTile.x, 0, currentTile.y );
			}

		} else {

		}

		if (Input.GetMouseButtonDown (0)) {
			if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
				myHoverObject.transform.position = new Vector3( currentTile.x, 0, currentTile.y );
				rootMousePos = currentTile;
			}
		}
		if (Input.GetMouseButton (0)) {
			if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
				myHoverObject.transform.localScale = new Vector3( rootMousePos.x - currentTile.x, 0 , rootMousePos.y - currentTile.y );
			}
		}
		if (Input.GetMouseButtonUp (0)) {

			Vector2 min;
			Vector2 max;

			if( rootMousePos.x < currentTile.x ){
				min.x = rootMousePos.x;
				max.x = currentTile.x;

			} else {
				max.x = rootMousePos.x;
				min.x = currentTile.x;
			}
			if( rootMousePos.y < currentTile.y ){
				min.y = rootMousePos.y;
				max.y = currentTile.y;
			} else {
				max.y = rootMousePos.y;
				min.y = currentTile.y;
			}

			_generateZone.setZoneSize( min , max );
			_generateZone.Generate( _generateZone.getPropNum() );
			
			if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
				myHoverObject.transform.position = new Vector3( currentTile.x, 0, currentTile.y );
			}
			myHoverObject.transform.localScale = new Vector3( 1, 0 , 1); 

		}
	}
}
