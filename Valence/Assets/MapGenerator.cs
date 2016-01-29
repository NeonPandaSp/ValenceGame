using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class MapGenerator : MonoBehaviour {
	public ExploreMode_GameController myGameController;
	public GameObject CoverObject;
	public GameObject scrapObject;
	
	int myMapSize;

	public string seed;
	public bool useRandomSeed;


	public int threshold;

	[Range(0,5)]
	public int smoothing;

	int[,] seedGrid;
	
	public bool regenMap = false;

	List<GameObject> currentMap = new List<GameObject>();
	// Use this for initialization
	void Start () {
		myMapSize = myGameController.mapSize;
		seedGrid = new int[myMapSize, myMapSize];
		RandomFillMap ();
		for (int i = 0; i < smoothing; i++) {
			SmoothMap ();
		}
		GenMap ();

	}
	
	// Update is called once per frame
	void Update () {
		if( regenMap ){
			regenerate();
			regenMap = false;
		}
	}
	public void regenerate(){
		foreach( GameObject g in currentMap )
			Destroy (g);
		
		for( int i = 0; i < myMapSize; i++){
			for( int j = 0; i < myMapSize; i++){
				if( myGameController.tiles[i,j] == 2 )
					myGameController.tiles[i,j] = 1;
			}
		}
		seedGrid = new int[myMapSize, myMapSize];
		RandomFillMap ();
		for (int i = 0; i < smoothing; i++) {
			SmoothMap ();
		}
		GenMap ();
	}
	public void GenMap(){
		// place starting location
		// place scrap location
		// place obstacle location
		Debug.Log ("Generating Map");
		Vector2 startingLocation = new Vector2 (13, 0);
		Vector2 scrapLocation;
		float scrapX = UnityEngine.Random.Range (0, myMapSize);
		float scrapY = UnityEngine.Random.Range (0, myMapSize);
		scrapLocation = new Vector2 (scrapX, scrapY);
		while( Vector2.Distance( startingLocation, scrapLocation ) < 15 ){
			scrapX = UnityEngine.Random.Range (0, myMapSize);
			scrapY = UnityEngine.Random.Range (0, myMapSize);
			scrapLocation = new Vector2 (scrapX, scrapY);
		}
		scrapObject.transform.position = new Vector3 (scrapLocation.x, 0, scrapLocation.y);
		for (int x = 0; x < myMapSize; x++) {
			for( int y = 0; y < myMapSize; y++ ){
				if( scrapLocation != new Vector2(x,y) ){
					if( Vector2.Distance( new Vector2(x,y), startingLocation ) > 4 ){
						int sample = seedGrid[x,y];
						if( sample == 1 ){
							GameObject TempObject = (GameObject) Instantiate (CoverObject, new Vector3(x, 0, y), Quaternion.identity);
							currentMap.Add(TempObject);
						} else { Debug.Log ("Generated Less Than Threshold " + sample ); }
					} else { Debug.Log ( "Too Close to Start" ); }
				} else { Debug.Log ( "On ScrapLocation" ); }
			}
		}
//		if (myGameController.GenerateNodePath( (int)scrapX, (int)scrapY) == null){
//			regenerate ();
//		}
	}

	public void RandomFillMap(){
		if (useRandomSeed) {
			seed = Time.time.ToString();
		}
		
		System.Random pseudoRandom = new System.Random(seed.GetHashCode());
		
		for (int x = 0; x < myMapSize; x ++) {
			for (int y = 0; y < myMapSize; y ++) {
				if (x == 0 || x == myMapSize-1 || y == 0 || y == myMapSize -1) {
					seedGrid[x,y] = 1;
				}
				else {
					seedGrid[x,y] = (pseudoRandom.Next(0,100) < threshold)? 1: 0;
				}
			}
		}
	}

	void SmoothMap() {
		for (int x = 0; x < myMapSize; x ++) {
			for (int y = 0; y < myMapSize; y ++) {
				int neighbourWallTiles = GetSurroundingWallCount(x,y);
				
				if (neighbourWallTiles > 4)
					seedGrid[x,y] = 1;
				else if (neighbourWallTiles < 2)
					seedGrid[x,y] = 0;
				
			}
		}
	}
	
	int GetSurroundingWallCount(int gridX, int gridY) {
		int wallCount = 0;
		for (int neighbourX = gridX - 1; neighbourX <= gridX + 1; neighbourX ++) {
			for (int neighbourY = gridY - 1; neighbourY <= gridY + 1; neighbourY ++) {
				if (neighbourX >= 0 && neighbourX < myMapSize && neighbourY >= 0 && neighbourY < myMapSize) {
					if (neighbourX != gridX || neighbourY != gridY) {
						wallCount += seedGrid[neighbourX,neighbourY];
					}
				}
				else {
					wallCount ++;
				}
			}
		}
		
		return wallCount;
	}

}
