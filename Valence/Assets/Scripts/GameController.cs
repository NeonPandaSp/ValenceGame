using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GameController : MonoBehaviour {
	static int mapSize = 50;
	public int[,] tiles = new int[mapSize,mapSize];
	public Vector3 rootMousePos;
	public bool rootSet = false;

    public List<GameObject> farmerList = new List<GameObject>();
    public List<GameObject> farmBuildingList = new List<GameObject>();

    public int scrap;
	public float food, power, water;
	
	// Use this for initialization
	void Start () {

        farmerList = new List<GameObject>();
        farmBuildingList = new List<GameObject>();

        for ( int x = 0; x < mapSize; x++){
			for( int y = 0; y < mapSize; y++){
				
			}
		}
	}
	
	// Update is called once per frame
	void Update () {


	}

}
