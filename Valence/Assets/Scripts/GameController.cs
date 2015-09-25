using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	static int mapSize = 50;
	public GameObject[,] tiles = new GameObject[mapSize,mapSize];
	public Vector3 rootMousePos;
	public bool rootSet = false;
	// Use this for initialization
	void Start () {
		/**
		for (int i = -mapSize/2; i < mapSize/2; i++) {
			for (int j = -mapSize/2; j < mapSize/2; j++) {
				GameObject tempObject = (GameObject ) Instantiate(Resources.Load("Tile"), new Vector3(i, 0, j), Quaternion.identity );
				tiles[i+mapSize/2,j+mapSize/2] = tempObject;
			}
		}
		**/
	}
	
	// Update is called once per frame
	void Update () {


	}

}
