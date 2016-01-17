using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {

	public GameController _myGameController;

	public BuildingType bType;
	public string myType; 
	public int myArea; 

	public GameObject[] assignedAgents;
		
	public bool initProduction;

	// Use this for initialization
	void Awake () {
		GameObject gameControllerObject =  GameObject.FindGameObjectWithTag("GameController");
		_myGameController = gameControllerObject.GetComponent<GameController> ();


		assignedAgents = new GameObject[3];
		initProduction = false;
		//beginProduction ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void initBuildingType(){
        //Create a new buildingtype and pass the type of building, the area of that building, the number of similar building, and the number of agents currently working at that building type
		bType = new BuildingType (myType, myArea);
        //bType.farmerVal = _myGameController.farmerList.Count;
        //bType.farmVal = _myGameController.farmBuildingList.Count;
    }

	public void beginProduction(){
		Debug.Log (bType.pTime);

		InvokeRepeating("GenerateResource",bType.pTime,bType.pTime);
        InvokeRepeating("ConsumeResource", bType.pTime, 5);
    }

	void GenerateResource(){
        //	Debug.Log ("GENERATING!");
        //First check that we have enough power to generate resources
        if (_myGameController.power > 0) {
            if (bType.typeName == "shelter") {
                // nada 
            }
            else if (bType.typeName == "food") {
                //We should look into updating the generation algorithm to be affected by the number of agents assigned,ie. more farmers working = increased production rate -Zach
                Debug.Log("bType.pRate: " + bType.pRate);

                _myGameController.food += bType.pRate * _myGameController.farmerList.Count / _myGameController.farmBuildingList.Count;
            }
            else if (bType.typeName == "water") {
                _myGameController.water += bType.pRate;
            }
            else if (bType.typeName == "tavern") {
                //Maybe add a moral increase rate?
            }
            else {
                Debug.Log("Production Type Error @ Resource Generation");
            }
        }
        else {
            
            Debug.Log("No power! We require more minerals");
        }

        //Since power stations do not consume power, they are not restricted by no power
        if (bType.typeName == "power") {
            _myGameController.power += bType.pRate;
        }
    }

    void ConsumeResource() {
        //	Debug.Log ("GENERATING!");
        if (bType.typeName == "shelter") {
            // nada 
        }
        else if (bType.typeName == "food") {
            Debug.Log("Power consumed by farm: " + bType.cRate);
            _myGameController.power -= bType.cRate;
        }
        //Remove power building consuming power
        else if (bType.typeName == "power") {
            //_myGameController.power += bType.cRate;
        }
        else if (bType.typeName == "water") {
            _myGameController.power -= bType.cRate;
        }
        else if (bType.typeName == "tavern") {
            _myGameController.power -= bType.cRate;
        }
        else {
            Debug.Log("Production Type Error @ Resource Generation");
        }
    }
}
