using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinStateScript : MonoBehaviour {
	public ExploreMode_GameController _gameController;

	int folkInitialPartySize;

	public Vector2 rootPosition; 

	public bool win, lose, rewardTriggered;

	public Image endScreen;
	public Canvas mainUI;

	public Image winUI;
	public Sprite winSprite, loseSprite;

	public int scrapRate;
	public int recruitRate;
	public int weaponRate;

	public GameObject objectiveMarker;

	public NameGenerator _nameGenerator;
	public loadScene _loadScene;

	public AudioController _audioController; // Audio controller

	public GameObject settlerObj, weaponObj, scrapObj;
	public GameObject rewardBucket;
	// Use this for initialization
	void Start () {
		endScreen.gameObject.SetActive (false);

		win = false;
		lose = false;

		folkInitialPartySize = _gameController.folk.Count;

		_nameGenerator = GetComponent<NameGenerator> ();
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
				_audioController.playAudioClipOnce (11, Vector3.zero, 500);
			}
			if(_gameController.elite.Count <= 0){
				win = true;
				_audioController.playAudioClipOnce (12, Vector3.zero, 500);
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
		} else {
		}
		results();
	}

	void loseScreen(){

	}

	void results(){
		PlayerData myData = PlayerDataManager.playerDataManager.loadSaveData ();
		//updatescrap
		if (win && !rewardTriggered) {
			Debug.Log ("win was called");

			winUI.sprite = winSprite;

			myData.scrap += scrapRate;
			GameObject newSObj = (GameObject) Instantiate ( scrapObj, Vector3.zero, Quaternion.identity );
			newSObj.transform.SetParent ( rewardBucket.transform );
			newSObj.transform.localScale = new Vector3( 1, 1, 1);
			newSObj.GetComponent<Reward_Scrap>().scrapVal.text = ""+scrapRate;

			for (int i = 0; i < recruitRate; i++) {
				serialAgent newAgent = new serialAgent ();
				//Gender
				string[] genderArray = new string[2] {
					"Male",
					"Female"
				};
				int randomGender = Random.Range (0, (genderArray.Length));
				newAgent.agentId = "NEWAGENT";
				newAgent.gender = genderArray [randomGender];
				newAgent.agentName = generateNewAgentName (newAgent.gender);
				newAgent.xPos = 0;
				newAgent.yPos = 0;
				newAgent.zPos = 0;
				
				newAgent.health = 60;
				newAgent.hunger = 80;
				
				newAgent.strength = randomStat ();
				newAgent.perception = randomStat ();
				newAgent.agility = randomStat ();
				
				newAgent.state = AgentLogic_07.agentState.Wandering;
				newAgent.job = AgentLogic_07.jobSubState.Default;

				GameObject newWObj = (GameObject) Instantiate ( settlerObj, Vector3.zero, Quaternion.identity );
				newWObj.transform.SetParent ( rewardBucket.transform );
				newWObj.transform.localScale = new Vector3( 1, 1, 1);
				newWObj.GetComponent<Reward_Person>().agentName.text = newAgent.agentName;
				newWObj.GetComponent<Reward_Person>().strVal.text = ""+newAgent.strength;
				newWObj.GetComponent<Reward_Person>().perVal.text = ""+ newAgent.perception;
				newWObj.GetComponent<Reward_Person>().aglVal.text = ""+newAgent.agility;

				myData.population.Add (newAgent);
				myData.populationCount++;
				Debug.Log ("newAgent: " + newAgent.agentName + " was added");
			}

			for (int i = 0; i < weaponRate; i++) {
				serialWeapon newWeapon = new serialWeapon ();

				string gunName = _nameGenerator.GetAdjective () + " " + _nameGenerator.GetVerbs ();
				gunName = gunName.ToUpper ();

				newWeapon.weaponName = gunName;
				newWeapon.weaponId = "" + ((int)Random.Range (1000, 9999));
				int dice = (int)rollDice (1, 7);

				if (dice <= 3) {
					newWeapon.weaponType = "Handgun";
					newWeapon.range = 8 + (int)rollDice (-2, 2);
					newWeapon.accuracy = 0.95f + rollDice (-0.3f, 0.3f);
					newWeapon.damageModifier = 6 + (int)rollDice (-3, 3);
					newWeapon.rangeModifier = 0.1f;
					newWeapon.soundRange = newWeapon.range - 3 + (newWeapon.damageModifier / 2);
				} else if (dice <= 5) {
					newWeapon.weaponType = "Shotgun";
					newWeapon.range = 6 + (int)rollDice (-2, 2);
					newWeapon.accuracy = 0.95f + rollDice (-0.2f, 0.2f);
					newWeapon.damageModifier = 6 + (int)rollDice (-3, 6);
					newWeapon.rangeModifier = 0.2f;
					newWeapon.soundRange = newWeapon.range - 3 + (newWeapon.damageModifier / 2);
				} else {
					newWeapon.weaponType = "Rifle";
					newWeapon.range = 13 + (int)rollDice (-3, 3);
					newWeapon.accuracy = 0.75f + rollDice (-0.2f, 0.2f);
					newWeapon.damageModifier = 6 + (int)rollDice (-2, 4);
					newWeapon.rangeModifier = 0.05f;
					newWeapon.soundRange = newWeapon.range - 3 + (newWeapon.damageModifier / 2);
				}



				GameObject newWObj = (GameObject) Instantiate ( weaponObj, Vector3.zero, Quaternion.identity );
				newWObj.transform.SetParent ( rewardBucket.transform );
				newWObj.transform.localScale = new Vector3( 1, 1, 1);
				newWObj.GetComponent<Reward_Weapon>().weaponName.text = newWeapon.weaponName;
				newWObj.GetComponent<Reward_Weapon>().weaponType.text = "["+newWeapon.weaponType+"]";
				newWObj.GetComponent<Reward_Weapon>().dmgMod.text = "+"+newWeapon.damageModifier;
				newWObj.GetComponent<Reward_Weapon>().rngMod.text = ""+ newWeapon.range;
				newWObj.GetComponent<Reward_Weapon>().accMod.text = newWeapon.accuracy*10 + "%";
				myData.settlementWeapons.Add (newWeapon);

				rewardTriggered = true;

			}
		} else if(!rewardTriggered) {
			winUI.sprite = loseSprite;
			if( winUI.gameObject.GetComponentInChildren<ScrollRect>().gameObject.activeSelf )
				winUI.gameObject.GetComponentInChildren<ScrollRect>().gameObject.SetActive(false);
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

		PlayerDataManager.playerDataManager.writePlayerData (myData);
		//loadBuild ();
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

	string generateNewAgentName(string gender){
		//Name
		string[] maleFirstNameArray = new string[32] {
			"Daron",
			"Bernardo",
			"Grady",
			"Willie",
			"Malcolm",
			"Trevor",
			"Ken",
			"Todd",
			"Rand",
			"Jeff",
			"Kurt",
			"Alexis",
			"Vishesh",
			"Luigi",
			"Jake",
			"Reggie",
			"Loyd",
			"Darron",
			"Tyler",
			"Zachary",
			"Roderick",
			"Raiden",
			"Miguel",
			"Ender",
			"Colm",
			"Phil",
			"Niko",
			"Tyson",
			"Sacha",
			"Tariq",
			"Zeph",
			"Ram"
		};
		
		string[] femaleFirstNameArray = new string[32] {
			"Joye",
			"Argelia",
			"Sheryll",
			"Carma",
			"Sheri",
			"Anita",
			"Xuan",
			"Robyn",
			"Allie",
			"Darcie",
			"Sari",
			"Shayna",
			"Thea",
			"Christie",
			"Sanora",
			"Laryssa",
			"Weri",
			"Elicia",
			"Wanda",
			"Creola",
			"Heidi",
			"Irene",
			"Helene",
			"Elora",
			"Joselyn",
			"Margery",
			"Oona",
			"Clair",
			"Freya",
			"Yvonne",
			"Sue",
			"Miley"
		};
		
		string[] lastNameArray = new string[35] {
			"Slate",
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
			"Allard",
			"Black",
			"Steele",
			"Sparks",
			"Quan",
			"Sparrow",
			"Poehler",
			"Carnes",
			"Vivek",
			"Cumberbatch",
			"Weaver",
			"Clay",
			"Yu",
			"Keyes",
			"Baird",
			"Crane",
			"Gould",
			"Valentine",
			"Frost",
			"Stark",
			"McDonald",
			"Willis",
			"Kirby",
			"Goldblum"
		};
		
		
		string firstLastName;

		//Create Random Variables
		int randomFirstName = UnityEngine.Random.Range (0, 32);
		int randomLastName = UnityEngine.Random.Range (0, 35);
				
		//Assigns random names and photos according to gender
		//Variable firstLastName outputs first and last name. variable settlerNameAndRole outputs name, what settler is currently doing, and their assigned role
		if (gender == "Male"){
			firstLastName = (maleFirstNameArray[randomFirstName] + " " + lastNameArray[randomLastName]);
		}
		else {
			firstLastName = (femaleFirstNameArray[randomFirstName] + " " + lastNameArray[randomLastName]);
		}

		return firstLastName;
	}

	public float rollDice(float min, float max){
		float randVal = Random.Range (min, max);

		return randVal;
	}
}
