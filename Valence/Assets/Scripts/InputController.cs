﻿using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	TileMap _tileMap;
	generateZone _generateZone;

	Vector2 currentTile;

	Vector2 rootMousePos;

	GameObject myHoverObject;

	public Material redMat, blueMat, yellowMat, greenMat;

	string currentColor;

	bool generate;

	void Start(){
		_tileMap = GetComponent<TileMap> ();
		_generateZone = GetComponent < generateZone >();
		myHoverObject = (GameObject) Instantiate (Resources.Load("Tile"), new Vector3 (0, 0, 0), Quaternion.identity);
		generate = false;
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

	int getCurrentSize(){
		return getCurrentWidth() * getCurrentHeight ();
	}

	int getCurrentWidth(){
		float maxX, minX;
		if( rootMousePos.x < currentTile.x ){
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
		if( rootMousePos.y < currentTile.y ){
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

		if (Input.GetMouseButtonDown (0) && !Input.GetKey ( KeyCode.LeftAlt )) {
			if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
				myHoverObject.transform.position = new Vector3( currentTile.x, 0.1f, currentTile.y );
				rootMousePos = currentTile;
			}
		}
		if (Input.GetMouseButton (0) && !Input.GetKey ( KeyCode.LeftAlt ) ) {


			if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
				if( rootMousePos.x >= currentTile.x ){ myHoverObject.transform.position = new Vector3( rootMousePos.x + 1, 0.1f, myHoverObject.transform.position.y ); }
				else { myHoverObject.transform.position = new Vector3( rootMousePos.x, 0.1f, myHoverObject.transform.position.y ); }
				if( rootMousePos.y >= currentTile.y ){ myHoverObject.transform.position = new Vector3( myHoverObject.transform.position.x,0.1f, rootMousePos.y + 1 ); }
				else { myHoverObject.transform.position = new Vector3(  myHoverObject.transform.position.x, 0.1f, rootMousePos.y ); }
				int scaleX = (int) ( rootMousePos.x - currentTile.x );
				int scaleY = (int) ( rootMousePos.y - currentTile.y );
				if( scaleX == 0 ) { scaleX = 1; }
				if( scaleY == 0 ) { scaleY = 1; }
				myHoverObject.transform.localScale = new Vector3( -1 * scaleX, 1 , -1 * scaleY );

			}
			if( getCurrentSize() >= 25 && getCurrentWidth() >= 5 && getCurrentHeight() >= 5 ){
				selectedMaterial( currentColor );
				generate = true;
			} else {
				myHoverObject.GetComponentInChildren<MeshRenderer>().material = redMat;
				generate = false;
			}
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
			if( generate ){
				_generateZone.setZoneSize( min , max );
				_generateZone.Generate( _generateZone.getPropNum() );

				foreach (GameObject obstcale in GameObject.FindGameObjectsWithTag("prop")) {
					AstarPath.active.UpdateGraphs(obstcale.gameObject.GetComponent<Collider>().bounds);
				}
			}
			if( currentTile.x <= _tileMap.worldSizeX && currentTile.y <= _tileMap.worldSizeZ && currentTile.x >= 0 && currentTile.y >= 0 ){
				myHoverObject.transform.position = new Vector3( currentTile.x, 1, currentTile.y );
			}
			myHoverObject.transform.localScale = new Vector3( 1, 1 , 1); 

		}
	}
}
