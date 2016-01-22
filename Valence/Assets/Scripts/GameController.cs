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

    public List<GameObject> powerWorkerList = new List<GameObject>();
    public List<GameObject> powerBuildingList = new List<GameObject>();

    public int scrap;
	public float food, power, water, popLimit, morale;
	
	// Use this for initialization
	void Start () {

        farmerList = new List<GameObject>();
        farmBuildingList = new List<GameObject>();

        powerWorkerList = new List<GameObject>();
        powerBuildingList = new List<GameObject>();

        //Start the game with 100 power
        power = 100;

        //Start population with a 10 person cap
        popLimit = 10;

        for ( int x = 0; x < mapSize; x++){
			for( int y = 0; y < mapSize; y++){
				
			}
		}

        InvokeRepeating("updateGridGraph",3,10);

	}
	
	// Update is called once per frame
	void Update () {
        if (power < 0) {
            power = 0;
        }
	}

    void updateGridGraph() {

        //yield return new WaitForSeconds(wait);
        //Debug.Log("Updated gridgraph..");
        //Update agent pathfinding to account for this new obstical -Zach
        foreach (GameObject obstcale in GameObject.FindGameObjectsWithTag("prop")) {
            AstarPath.active.UpdateGraphs(obstcale.gameObject.GetComponent<Collider>().bounds);
        }
        //yield return new WaitForSeconds(wait);
    }

}
