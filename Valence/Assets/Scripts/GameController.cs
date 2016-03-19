using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class GameController : MonoBehaviour {
	static int mapSize = 50;
	public int[,] tiles = new int[mapSize,mapSize];

	public AgentSpawner myAgentSpawner;

	public GameObject agentPrefab;

	public Vector3 rootMousePos;
	public bool rootSet = false;

	public List<GameObject> population = new List<GameObject>();
	public List<GameObject> buildingDatabase = new List<GameObject> ();

    public List<GameObject> farmerList = new List<GameObject>();
    public List<GameObject> farmBuildingList = new List<GameObject>();

    public List<GameObject> powerWorkerList = new List<GameObject>();
    public List<GameObject> powerBuildingList = new List<GameObject>();
    
	public List<GameObject> traineeList = new List<GameObject>();
	public List<GameObject> trainingBuildingList = new List<GameObject> ();

	public List<GameObject> waterWorkerList = new List<GameObject> ();
	public List<GameObject> waterBuildingList = new List<GameObject>();

	
	public List<GameObject> hospitalWorkerList = new List<GameObject>();
	public List<GameObject> hospitalBuildingList = new List<GameObject> ();

	public GUIController_SettlerInfo currentSettlerUI;
	public NotificationController notificationController;
	public RandomEventController randomEventController;

    public int scrap;
	public float food, power, water, popLimit, morale;

	public bool firstLoad;
	public bool foodAlerted, scrapAlerted, waterAlerted, powerAlerted;
	
	// Use this for initialization
	void Awake () {

		myAgentSpawner = FindObjectOfType<AgentSpawner> ();
		notificationController = GameObject.Find ("NotificationController").GetComponent <NotificationController> ();

		population = new List<GameObject> ();

		buildingDatabase = new List<GameObject> ();
        farmerList = new List<GameObject>();
        farmBuildingList = new List<GameObject>();

        powerWorkerList = new List<GameObject>();
        powerBuildingList = new List<GameObject>();

		waterWorkerList = new List<GameObject> ();
		waterBuildingList = new List<GameObject> ();

		traineeList = new List<GameObject> ();
		trainingBuildingList = new List<GameObject> ();

		loadLastSave ();
		
		if (firstLoad) {
			//
			scrap += 75;
			//Start the game with 100 power
			power += 0;
			
			//Start population with a 10 person cap
			popLimit = 10;

			waterAlerted = true;
			powerAlerted = true;
			foodAlerted = true;
		}

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
		if (power > 10 * powerBuildingList.Count) {
			power = 10 * powerBuildingList.Count;
		}
		if (food > 20 * farmBuildingList.Count) {
			food = 20 * farmBuildingList.Count;
		}

		if (food < 15 && !foodAlerted) {
			notificationController.CreateNewNotification ("Food is low! Build more FARMS, or assign more settlers as FARMERS to increase production!");
			foodAlerted = true;
		} else if( food > 15 ) {
			foodAlerted = false;
		}
		if (scrap < 50 && !scrapAlerted) {
			notificationController.CreateNewNotification ("Scrap is low! Explore the metro to discover more scrap!");
			scrapAlerted = true;
		} else if( scrap > 50 ) {
			scrapAlerted = false;
		}
		if (water < 10 && !waterAlerted) {
			notificationController.CreateNewNotification ("Water is low! Build more WATER STATIONS, or assign more settlers as HYDROLOGISTS to increase production!");
			waterAlerted = true;
		} else if (water > 10 ) {
			waterAlerted = false;
		}
		if (power < 20 && !powerAlerted) {
			notificationController.CreateNewNotification ("Power is low! Without power buildings don't operate. Build more POWER STATIONS, or assign more settlers as POWER WORKERS to increases production!");
			powerAlerted = true;
		} else if ( power > 20 ) {
			powerAlerted = false;
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

	void loadLastSave(){
		PlayerData loadedData = PlayerDataManager.playerDataManager.loadSaveData ();

		firstLoad = loadedData.firstLoad;

		scrap = loadedData.scrap;
		food = loadedData.food;
		power = loadedData.power;
		water = loadedData.water;
		popLimit = loadedData.popLimit;
		morale = loadedData.morale;

		foreach (serialBuilding bld in loadedData.buildingDatabase) {
			GameObject tempBld = (GameObject) Instantiate( Resources.Load(bld.bType), new Vector3( bld.xPos, bld.yPos, bld.zPos), Quaternion.identity);
			
			if( tempBld.GetComponent<BuildingScript>().myType == "Farm" ){
				farmBuildingList.Add ( tempBld );
				Debug.Log ("Added to FarmBuilding List");
			} else if ( tempBld.GetComponent<BuildingScript>().myType == "PowerStation" ){
				powerBuildingList.Add ( tempBld );
			} else if ( tempBld.GetComponent<BuildingScript>().myType == "WaterStation" ){
				waterBuildingList.Add ( tempBld );
			} else if ( tempBld.GetComponent<BuildingScript>().myType == "TrainingArea"){
				trainingBuildingList.Add( tempBld );
			}  else if ( tempBld.GetComponent<BuildingScript>().myType == "Hospital"){
				hospitalBuildingList.Add( tempBld );
			}
			tempBld.GetComponent<BuildingScript>().initBuildingType();
			tempBld.GetComponent<BuildingScript>().beginProduction();

			buildingDatabase.Add(tempBld);
		}

		foreach (serialAgent agent in loadedData.population) {
			GameObject temp;
			if( agent.gender == "Male" ){
				temp = (GameObject) Instantiate( myAgentSpawner.MaleAgent[agent.myModelIndex], new Vector3( agent.xPos, agent.yPos, agent.zPos), Quaternion.identity);
			} else {
				temp = (GameObject) Instantiate( myAgentSpawner.FemaleAgent[agent.myModelIndex], new Vector3( agent.xPos, agent.yPos, agent.zPos), Quaternion.identity);
			}

			if( agent.agentId != "NEWAGENT" )
				temp.name = agent.agentId;
			else
				temp.name = "Agent" + temp.GetInstanceID();

			temp.GetComponent<AgentLogic_07>().gender = agent.gender;
			temp.GetComponent<AgentLogic_07>().modelIndex = agent.myModelIndex;
			temp.GetComponent<AgentLogic_07>().firstLastName = agent.agentName;
			temp.GetComponent<AgentLogic_07>().photo = agent.agentPhoto;
			temp.GetComponent<AgentLogic_07>().health = agent.health;
			temp.GetComponent<AgentLogic_07>().hungerValue = agent.hunger;
			temp.GetComponent<AgentAttributes>().agentAgility = agent.agility;
			temp.GetComponent<AgentAttributes>().agentPerception = agent.perception;
			temp.GetComponent<AgentAttributes>().agentStrength = agent.strength;

			temp.GetComponent<AgentLogic_07>().aState = agent.state;
			temp.GetComponent<AgentLogic_07>().jobState = agent.job;
			temp.GetComponent<AgentLogic_07>().newAgent = false;
			if( temp.GetComponent<AgentLogic_07>().jobState == AgentLogic_07.jobSubState.Farmer){
				temp.GetComponent<AgentLogic_07>().workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag ("FarmWaypoint"));
				farmerList.Add(temp);
			} else if ( temp.GetComponent<AgentLogic_07>().jobState == AgentLogic_07.jobSubState.PowerWorker){
				temp.GetComponent<AgentLogic_07>().workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("PowerWaypoint"));
				powerWorkerList.Add (temp);
			} else if ( temp.GetComponent<AgentLogic_07>().jobState == AgentLogic_07.jobSubState.Hydrologist){
				temp.GetComponent<AgentLogic_07>().workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("WaterWaypoint"));
				waterWorkerList.Add (temp);
			} else if ( temp.GetComponent<AgentLogic_07>().jobState == AgentLogic_07.jobSubState.Trainee){
				temp.GetComponent<AgentLogic_07>().workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("TrainingWaypoint"));
				traineeList.Add (temp);
			} else if ( temp.GetComponent<AgentLogic_07>().jobState == AgentLogic_07.jobSubState.Medic){
				temp.GetComponent<AgentLogic_07>().workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("HospitalWaypoint"));
				hospitalWorkerList.Add (temp);
			}
			population.Add(temp);
		}
	}

	public void saveCurrentSettlement(){
		Debug.Log ("Saving");
		PlayerData newData = new PlayerData ();

		newData.scrap = scrap;
		newData.food = food;
		newData.power = power;
		newData.water = water;
		newData.popLimit = popLimit;
		newData.morale = morale;

		//newData.population = population;
		List<serialAgent> serialPopulation = new List<serialAgent>();

		foreach (GameObject agent in population) {
			serialAgent tempAgent = new serialAgent();

			tempAgent.agentId = agent.name;
			tempAgent.gender = agent.GetComponent<AgentLogic_07>().gender;
			tempAgent.myModelIndex = agent.GetComponent<AgentLogic_07>().modelIndex;
			tempAgent.agentName = agent.GetComponent<AgentLogic_07>().firstLastName;
			tempAgent.xPos = agent.transform.position.x;
			tempAgent.yPos = agent.transform.position.y;
			tempAgent.zPos = agent.transform.position.z;
			tempAgent.health = agent.GetComponent<AgentLogic_07>().health;
			tempAgent.hunger = agent.GetComponent<AgentLogic_07>().hungerValue;
			tempAgent.agility = (int) agent.GetComponent<AgentAttributes>().agentAgility;
			tempAgent.perception = (int) agent.GetComponent<AgentAttributes>().agentPerception;
			tempAgent.strength = (int) agent.GetComponent<AgentAttributes>().agentStrength;

			tempAgent.state = agent.GetComponent<AgentLogic_07>().aState;
			tempAgent.job = agent.GetComponent<AgentLogic_07>().jobState;

			serialPopulation.Add (tempAgent);
		}

		List<serialBuilding> serialBuildingDatabase = new List<serialBuilding>();

		foreach (GameObject building in buildingDatabase) {
			serialBuilding tempBuilding = new serialBuilding();

			tempBuilding.bType = building.GetComponent<BuildingScript>().myType;
			Debug.Log (building.name);
			tempBuilding.xPos = building.transform.position.x;
			tempBuilding.yPos = building.transform.position.y;
			tempBuilding.zPos = building.transform.position.z;

			serialBuildingDatabase.Add(tempBuilding);
		}

		newData.population = serialPopulation;
		newData.buildingDatabase = serialBuildingDatabase;

		PlayerDataManager.playerDataManager.writePlayerData (newData);
		Debug.Log ("SAVED");
	}
}

[Serializable]
public class serialBuilding {
	public string bType;
	public float xPos;
	public float yPos;
	public float zPos;
}

[Serializable]
public class serialAgent {
	public string agentId;

	public string gender;
	public string agentName;
	public string photo;
	public int myModelIndex;

	public float xPos;
	public float yPos;
	public float zPos;

	public int health;
	public int hunger;

	public int strength;
	public int perception;
	public int agility;

	public serialWeapon myWeapon;

	public AgentLogic_07.agentState state;
	public AgentLogic_07.jobSubState job;
}

[Serializable]
public class serialWeapon {
	public string weaponId;

	public string weaponName;
	public string weaponType;	//Fist, Baton, Pistol, Rifle, Shotgun
	public bool weaponState;	//Equipped or not equipped (part of the inventory). If already equipped, it is not accessible by another settler.

	//Weapon Stats
	public int weaponDMG;
	public int weaponRNG;
	public int weaponACC;
	public int weaponSND;
}