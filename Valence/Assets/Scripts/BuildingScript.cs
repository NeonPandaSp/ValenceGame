using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {

	public GameController _myGameController;

	public BuildingType bType;
	public string myType; 
	public int myArea; 

	public GameObject[] assignedAgents;
		
	public bool initProduction;

	public bool powered;
	public bool worked;

	public float resourceProgress;
	public float consumptionProgress;

    public Transform infoUI;
    public Transform progressUI;


    //Bool checks if the user has clicked once or twice on the building
    //used to toggle between UI components
    bool checkClick;

	// Use this for initialization
	void Start () {
		GameObject gameControllerObject =  GameObject.FindGameObjectWithTag("GameController");
		_myGameController = gameControllerObject.GetComponent<GameController> ();

        //Find child UI gameobjects of this building
        infoUI = transform.Find("BuildingInfo");
        progressUI = transform.Find("ProgressBar");

        assignedAgents = new GameObject[3];


        checkClick = true;
		//beginProduction ();
	}
	
	// Update is called once per frame
	void Update () {

        if (initProduction)
			production ();
	}

    void OnMouseDown() {

        if (checkClick){

            infoUI.gameObject.SetActive(true);
            progressUI.gameObject.SetActive(false);

            checkClick = false;
        }
        else {

            infoUI.gameObject.SetActive(false);
            progressUI.gameObject.SetActive(true);

            checkClick = true;
        }
    }

    void production(){
		// checks if any settlers are assigned to this building type
		if (checkIfWorked ()) {
			worked = true;
			//Debug.Log ("Building Worked");
		} else {
			worked = false;
			//Debug.Log ("Building NOT Worked");
		}
		
		// adds to counter to check if its time to consume power
		consumptionProgress += Time.deltaTime;
		
		// if its time to consume power, consume power, else tell the game this building isn't powered
		if (consumptionProgress >= bType.cTime) {
			if( _myGameController.power >= bType.cRate ){
				_myGameController.power -= bType.cRate;
				powered = true;
				//Debug.Log ("POWER CONSUMED");
			} else {
				//Debug.Log ("NOT ENOUGH POWER");
				if( bType.typeName == "PowerStation" )
					powered = true;
				else
					powered = false;
			}
			consumptionProgress = 0;
		}
		
		// if worked and powered, add to counter to check if its time to generate resource
		if (worked && powered) {
			//Debug.Log ("Work and Power Check Successful, Incrementing resourceProgress");
			resourceProgress += Time.deltaTime;
		} else {
			//Debug.Log ("Work and Power Check Failed");
		}
		
		// if its time to generate resource, generate resource and then reset counter
		if (resourceProgress > bType.pTime) {
			//Debug.Log ("Generating Resource");
			GenerateResource();
			resourceProgress = 0;
		}
	}

	public void initBuildingType(){
        //Create a new buildingtype and pass the type of building, the area of that building, the number of similar building, and the number of agents currently working at that building type
		bType = new BuildingType (myType, myArea);

        //bType.farmerVal = _myGameController.farmerList.Count;
        //bType.farmVal = _myGameController.farmBuildingList.Count;
    }

	public void beginProduction(){
		initProduction = true;
		//Debug.Log ("Production Started");
		//InvokeRepeating("ConsumeResource", bType.pTime,bType.pTime);
		//InvokeRepeating("GenerateResource",bType.pTime,bType.pTime);
        
    }

	void GenerateResource(){
        //	Debug.Log ("GENERATING!");

        if (bType.typeName == "Shelter"){
            _myGameController.popLimit += bType.pRate;
            //_myGameController.popLimit += 10;
        }
        if (bType.typeName == "TrainingArea"){
            //Maybe add a moral increase rate?
            //_myGameController.traineeList
            foreach (GameObject agent in _myGameController.traineeList) {

                print(agent + " is training");

                //Increase the agent atributes by 1 while training
                agent.GetComponent<AgentAttributes>().agentAgility += 1;
                agent.GetComponent<AgentAttributes>().agentPerception += 1;
                agent.GetComponent<AgentAttributes>().agentStrength += 1;

                //Recalculate each attribute 
                agent.GetComponent<AgentAttributes>().SetAgility();
                agent.GetComponent<AgentAttributes>().SetPerception();
                agent.GetComponent<AgentAttributes>().SetStrength();

            }
        }

        //First check that we have enough power to generate resources
       // if ( powered ) {
            
            if (bType.typeName == "Farm") {
                //We should look into updating the generation algorithm to be affected by the number of agents assigned,ie. more farmers working = increased production rate -Zach
                Debug.Log("bType.pRate: " + bType.pRate);
				if( _myGameController.farmBuildingList.Count > 0  )
					_myGameController.food += ( bType.pRate ); //* _myGameController.farmerList.Count) / (_myGameController.farmBuildingList.Count);
            }
            else if (bType.typeName == "WaterStation") {
                _myGameController.water += bType.pRate;
            }
            else {
                Debug.Log("Production Type Error @ Resource Generation");
            }
      //  }
      //  else {
            
       //     Debug.Log("No power! We require more minerals");
      //  }

        //Since power stations do not consume power, they are not restricted by no power
        if (bType.typeName == "PowerStation") {
			_myGameController.power += ( bType.pRate * _myGameController.powerWorkerList.Count) / (_myGameController.powerBuildingList.Count);
        }
    }

    void ConsumeResource() {
        //	Debug.Log ("GENERATING!");

		if (_myGameController.power >= bType.cRate) {
			_myGameController.power -= bType.cRate;
			powered = true;
		} else {
			powered = false;
		}



//        if (bType.typeName == "Shelter") {
//            // nada 
//        }
//        else if (bType.typeName == "Farm") {
//            Debug.Log("Power consumed by farm: " + bType.cRate);
//			if( _myGameController.power > bType )
//            	_myGameController.power -= bType.cRate;
//        }
//        //Remove power building consuming power
//        else if (bType.typeName == "PowerStation") {
//            //_myGameController.power += bType.cRate;
//        }
//        else if (bType.typeName == "WaterStation") {
//            _myGameController.power -= bType.cRate;
//        }
//        else if (bType.typeName == "Tavern") {
//            _myGameController.power -= bType.cRate;
//        }
//        else if (bType.typeName == "Hospital")
//        {
//            _myGameController.power -= bType.cRate;
//        }
//        else {
//            Debug.Log("Production Type Error @ Resource Generation");
//        }
    }

	public bool checkIfWorked(){
		if (bType.typeName == "Farm") {
			if( _myGameController.farmerList.Count > 0 )
				return true;
		}
		if (bType.typeName == "PowerStation") {
			if( _myGameController.powerWorkerList.Count > 0 )
				return true;
		}
		if (bType.typeName == "WaterStation") {
			if( _myGameController.waterWorkerList.Count > 0 )
				return true;
		}
		if (bType.typeName == "TrainingArea") {
			if( _myGameController.traineeList.Count > 0 )
				return true;
		}
		if (bType.typeName == "Hospital") {
			if( _myGameController.hospitalWorkerList.Count > 0 )
				return true;
		}
		return false;
	}
}
