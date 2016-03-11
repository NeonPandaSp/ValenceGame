using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinStateScript : MonoBehaviour {
	public ExploreMode_GameController _gameController;

	int folkInitialPartySize;

	public Vector2 rootPosition; 

	bool win, lose;

	public Image endScreen;
	public Canvas mainUI;

	public Text winText;
	public Text rewardsText;
	public Text lossesText;

	public int scrapRate;
	public int recruitRate;
	public int weaponRate;

	public GameObject objectiveMarker;
	// Use this for initialization
	void Start () {
		endScreen.gameObject.SetActive (false);

		win = false;
		lose = false;

		folkInitialPartySize = _gameController.folk.Count;
	}
	
	// Update is called once per frame
	void Update () {
		int scrapless = 0;
		foreach (Unit fU in _gameController.folk) {
			if( fU.hasScrap ){

			} else {
				scrapless++;
			}
		}
		if (scrapless == _gameController.folk.Count) {
			objectiveMarker.transform.position = _gameController.scrapObj.transform.position;
			objectiveMarker.GetComponentInChildren<TextMesh>().text = "collect";
		} else {
			objectiveMarker.transform.position = new Vector3( rootPosition.x, 0.0f, rootPosition.y);
			objectiveMarker.GetComponentInChildren<TextMesh>().text = "escape";
		}
		objectiveMarker.transform.position += new Vector3(0.5f, 0, 0.5f );

		if (!win && !lose) {
			if (_gameController.folk.Count <= 0) {
				lose = true;
			}
			if(_gameController.elite.Count <= 0){
				win = true;
			}
			foreach (Unit fU in _gameController.folk) {
				if (fU.hasScrap) {
					if (fU.getDistance (fU.currentPosition, rootPosition) <= 2) {
						win = true;
					}
				}

			}
		} else {
			winScreen();
		}
	}

	void winScreen(){
		endScreen.gameObject.SetActive (true);
		mainUI.gameObject.SetActive (false);
		if (win) {
			winText.text = "Mission Complete";
			rewardsText.text = "Rewards are generated here";


		} else {
			winText.text = "Mission Failed";
			rewardsText.text = "---";
		}
		results();
		lossesText.text = "" + ( folkInitialPartySize - _gameController.folk.Count) + " casualties.";
	}

	void loseScreen(){

	}

	void results(){
		PlayerData myData = PlayerDataManager.playerDataManager.loadSaveData ();
		//updatescrap
		if (win) {
			Debug.Log ( "win was called" );
			myData.scrap += scrapRate;
			for( int i = 0; i < recruitRate; i++){
				serialAgent newAgent = new serialAgent();
				//Gender
				string[] genderArray = new string[2] {
					"Male",
					"Female"
				};
				int randomGender = Random.Range(0, (genderArray.Length));
				newAgent.agentId = "NEWAGENT";
				newAgent.gender = genderArray[randomGender];
				newAgent.agentName = generateNewAgentName(newAgent.gender);
				newAgent.xPos = 0;
				newAgent.yPos = 0;
				newAgent.zPos = 0;
				
				newAgent.health = 60;
				newAgent.hunger = 80;
				
				newAgent.strength = randomStat();
				newAgent.perception = randomStat ();
				newAgent.agility = randomStat ();
				
				newAgent.state = AgentLogic_07.agentState.Wandering;
				newAgent.job = AgentLogic_07.jobSubState.Default;
				myData.population.Add( newAgent );
				myData.populationCount++;
				Debug.Log("newAgent: " + newAgent.agentName + " was added");
			}
		}
		
		
		foreach (serialAgent sA in myData.currentParty) {
			for( int i = myData.population.Count - 1; i >=0; i--){
				if( sA.agentId == myData.population[i].agentId ){
					Debug.Log ( myData.population.Count );
					myData.population.Remove ( myData.population[i] );
					Debug.Log ( sA.agentName + " was removed " + myData.population[i].agentName  );
					Debug.Log ( myData.population.Count );
				}
			}
		}
		foreach (Unit fU in _gameController.folk) {
			foreach( serialAgent sA in myData.currentParty ){
				if( sA.agentId == fU.agentId ){
					sA.health = fU.health * 10;
				}
			}
		}
		foreach (serialAgent sA in myData.currentParty) {
			if( sA.health > 0 ){
				Debug.Log (sA.agentName + "readded to population");
				myData.population.Add ( sA );
			}
		}
		myData.currentParty.Clear ();
		Debug.Log ("Current Population");
		foreach (serialAgent sA in myData.population) {
			Debug.Log ( sA.agentName );
		}
		PlayerDataManager.playerDataManager.writePlayerData (myData);
		loadBuild ();
	}

	void loadBuild(){
		Application.LoadLevel(2);
	}
	int randomStat(){
		int randVal = (int) Random.Range (0, 100);
		if (randVal < 50)
			return 1;
		else if (randVal < 75)
			return 2;
		else if (randVal < 87)
			return 3;
		else if (randVal < 93)
			return 4;
		else if (randVal < 96)
			return 5;
		else if (randVal < 98)
			return 6;
		else if (randVal < 99)
			return 7;
		else
			return 8;
	}

	string generateNewAgentName(string gen){
		
		//Name
		string[] maleFirstNameArray = new string[21] {
			"Daron",
			"Bernardo",
			"Grady",
			"Willie",
			"Mark",
			"Malcolm",
			"Trevor",
			"Len",
			"Tod",
			"Randy",
			"Gail",
			"Kurt",
			"Alexis",
			"Winford",
			"Luigi",
			"Jake",
			"Reggie",
			"Loyd",
			"Darron",
			"Tyler",
			"Zachary"
		};
		
		string[] femaleFirstNameArray = new string[20] {
			"Joye",
			"Argelia",
			"Candelaria",
			"Sheryll",
			"Carma",
			"Sheri",
			"Anita",
			"Magdalena",
			"Laryssa",
			"Zachary-a",
			"Darcie",
			"Sari",
			"Shayna",
			"Thea",
			"Maryanna",
			"Sanora",
			"Deedra",
			"Wanda",
			"Creola",
			"Weri"
		};
		
		string[] lastNameArray = new string[14] {
			"Hawthorne",
			"Hazlewood",
			"Beckett",
			"Polo",
			"Mordecai",
			"McKnight",
			"Kerrigan",
			"Kellerman",
			"Stone",
			"Drake",
			"Richards",
			"Fontana",
			"Bob",
			"Steele"
		};
		
		int randomFirstName = (int) UnityEngine.Random.Range (0, 14);
		int randomLastName = (int) UnityEngine.Random.Range (0, 14);

		string firstLastName;
		//Name - variable firstLastName outputs first and last name. variable settlerNameAndRole outputs name, what settler is currently doing, and their assigned role
		if (gen == "Male"){
			firstLastName = (maleFirstNameArray[randomFirstName] + " " + lastNameArray[randomLastName]);
		}
		else {
			firstLastName = (femaleFirstNameArray[randomFirstName] + " " + lastNameArray[randomLastName]);
		}
		
		return firstLastName;
	}
}
