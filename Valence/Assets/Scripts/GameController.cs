using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	static int mapSize = 50;
	public GameObject[,] tiles = new GameObject[mapSize,mapSize];
	public Vector3 rootMousePos;
	public bool rootSet = false;
	// Use this for initialization
	void Start () {
		for (int i = -mapSize/2; i < mapSize/2; i++) {
			for (int j = -mapSize/2; j < mapSize/2; j++) {
				GameObject tempObject = (GameObject ) Instantiate(Resources.Load("Tile"), new Vector3(i, 0, j), Quaternion.identity );
				tiles[i+mapSize/2,j+mapSize/2] = tempObject;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) {


			Vector3 mousePos = Input.mousePosition;
			mousePos.z = 90;
			mousePos = Camera.main.ScreenToWorldPoint(mousePos);
			if( !rootSet ){	
				rootMousePos = mousePos;
				rootSet = true;
			}

			Vector2 zoneStart, zoneEnd;
			if( rootMousePos.x < mousePos.x ){
				zoneStart.x = rootMousePos.x;
				zoneEnd.x = mousePos.x;
			} else {
				zoneStart.x = mousePos.x;
				zoneEnd.x = rootMousePos.x;
			} 

			if ( rootMousePos.z < mousePos.z ){
				zoneStart.y = rootMousePos.z;
				zoneEnd.y = mousePos.z;
			} else {
				zoneStart.y = mousePos.z;
				zoneEnd.y = rootMousePos.z;
			}

			if( zoneStart.x + mapSize/2 > mapSize ){
				zoneStart.x = mapSize/2;
			} else if ( zoneStart.x + mapSize/2 < 0 ){
				zoneStart.x = -mapSize/2; 
			}
			if( zoneStart.y + mapSize/2 > mapSize ){
				zoneStart.y = mapSize/2;
			} else if ( zoneStart.y + mapSize/2 < 0 ){
				zoneStart.y = -mapSize/2; 
			}

			if( zoneEnd.x + mapSize/2 > mapSize ){
				zoneEnd.x = mapSize/2;
			} else if ( zoneEnd.x + mapSize/2 < 0 ){
				zoneEnd.x = -mapSize/2; 
			}
			if( zoneEnd.y + mapSize/2 > mapSize ){
				zoneEnd.y = mapSize/2;
			} else if ( zoneEnd.y + mapSize/2 < 0 ){
				zoneEnd.y = -mapSize/2; 
			}
			for( int i = (int) zoneStart.x; i < (int) zoneEnd.x; i++ ){
				for( int j = (int) zoneStart.y; j < (int) zoneEnd.y; i++ ){
					Debug.Log ( i +(mapSize/2) + " " + ( j+(mapSize/2)) );
					tiles [i + (mapSize/2), j+(mapSize/2)].GetComponent<TileScript> ().setChildActive (true);
				}
			}

		} else if (Input.GetMouseButtonUp (0)) {
			rootMousePos = new Vector3( 0,0,0);
			rootSet = false;
			for (int i = 0; i < mapSize; i++) {
				for (int j = 0; j < mapSize; j++) {
					tiles [i,j].GetComponent<TileScript> ().setChildActive (false);
				}
			}
		}
	}

}
