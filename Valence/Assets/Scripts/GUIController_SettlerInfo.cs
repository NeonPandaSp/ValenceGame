using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class GUIController_SettlerInfo : MonoBehaviour {

    /* Set this script on a building */
    protected bool showMenu = false;
    // Set showing the menu to false

    //Assign agent fsm to this GUI
    public AgentLogic_07 agentLogic;

	//Return true if a gameobject with corresponding tag has been spawned, vise versa for false
    bool farmAvailable, hospitalAvailable, waterstationAvailable, powerstationAvailable, storageAvailable, schoolAvailable, shrineAvailable, tavernAvailable;

    //Return true if error message should be shown
    bool showError;

	Canvas myCanvas;
	
	public Image SettlerInfoBg;
	Image SettlerInfoDelBg;

	public Image genericProfileIcon;
	Image genericProfileIconDel;

	int randomFirstName;
	int randomLastName;
	String[] firstNameArray;
	String[] lastNameArray;

	public Text firstLastName;
	Text firstLastNameDel;
	
	// === Settler Attributes === \\
	public Text attributesTitle, settlerHealthText, settlerStaminaText, settlerMoraleText, settlerHungerText, settlerThirstText;
	Text attributesTitleDel, settlerHealthTextDel, settlerStaminaTextDel, settlerMoraleTextDel, settlerHungerTextDel, settlerThirstTextDel;
	
	public Text settlerStrengthText, settlerIntelligenceText, settlerAgilityText, settlerPerceptionText, settlerCharismaText;
	Text settlerStrengthTextDel, settlerIntelligenceTextDel, settlerAgilityTextDel, settlerPerceptionTextDel, settlerCharismaTextDel;

	int rndHP,rndStam, rndMor, rndHung, rndThir, rndStr, rndInt, rndAgil, rndPerc, rndChar;
	
	// === Settler Inventory === \\
	public Text inventoryTitle;
	Text inventoryTitleDel;
	
	// === Settler Assign Role === \\
	public Text rolesTitle;
	Text rolesTitleDel;
	
	public Button farmerRoleButton, waterPurifierRoleButton, powerEngineerRoleButton, storageWorkerRoleButton, medicRoleButton, teacherRoleButton, worshipperRoleButton, bartenderRoleButton;
	Button farmerRoleButtonDel, waterPurifierRoleButtonDel, powerEngineerRoleButtonDel, storageWorkerRoleButtonDel, medicRoleButtonDel, teacherRoleButtonDel, worshipperRoleButtonDel, bartenderRoleButtonDel;

	// === Close Window Button === \\
	public Button exBtn;
	Button exBtnDel;

	//=================\\
	//===== Start =====\\
	//=================\\

    void Start() {

        showError = false;
        hospitalAvailable = false;
        farmAvailable = false;
        waterstationAvailable = false;
        powerstationAvailable = false;
        storageAvailable = false;
        schoolAvailable = false;

        myCanvas = GameObject.Find ("Canvas").GetComponent <Canvas>();

		//===============================\\
		//=== Settler Info Background ===\\
		//===============================\\
		SettlerInfoDelBg = (Image)Instantiate (SettlerInfoBg);
		SettlerInfoDelBg.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		SettlerInfoDelBg.rectTransform.sizeDelta = new Vector2 (820, 305);
		SettlerInfoDelBg.transform.Translate (410, 152.5f, 0);
		SettlerInfoDelBg.gameObject.SetActive (false);

		//=======================\\
		//=== Settler Picture ===\\
		//=======================\\
		genericProfileIconDel = (Image)Instantiate (genericProfileIcon);
		genericProfileIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		genericProfileIconDel.rectTransform.sizeDelta = new Vector2 (200, 300);
		genericProfileIconDel.transform.Translate (105, 150, 0);
		genericProfileIconDel.gameObject.SetActive (false);

		//====================\\
		//=== Settler Name ===\\
		//====================\\
		//		switch (namesList) {
		//		case true:
		firstNameArray = new String[14] {"Jimmy", "T.D.", "Very", "Jackery", "Fontana", "Freya", "Iris", "Dean", "Reed", "Tate", "Seth", "Larry", "Leaf", "Marco"};
		lastNameArray = new string[14] {"Hawthorne", "Hazlewood", "Beckett", "Polo", "Mordecai", "McKnight", "Kerrigan", "Kellerman", "Stone", "Drake", "Richards", "Fontana", "Bob", "Steele"};
		
		randomFirstName = UnityEngine.Random.Range (0, 14);
		randomLastName = UnityEngine.Random.Range (0, 14);
		

		firstLastNameDel = (Text)Instantiate (firstLastName);
		firstLastNameDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		firstLastNameDel.rectTransform.sizeDelta = new Vector2 (400, 50);
		firstLastNameDel.transform.position = new Vector2 (500, 279);
		
		firstLastNameDel.fontSize = 28;
		firstLastNameDel.gameObject.SetActive (false);
		
		//			break;
		//		case false:
		//			//LOL
		//			break;
		//		}

		//==========================\\
		//=== Settler Attributes ===\\
		//==========================\\
		//Fake Attributes
		rndHP  = UnityEngine.Random.Range (1, 101);
		rndStam = UnityEngine.Random.Range (0, 101);
		rndMor = UnityEngine.Random.Range (0, 101);
		rndHung = UnityEngine.Random.Range (0, 101);
		rndThir = UnityEngine.Random.Range (0, 101);
		rndStr = UnityEngine.Random.Range (0, 11);
		rndInt = UnityEngine.Random.Range (0, 11);
		rndAgil = UnityEngine.Random.Range (0, 11);
		rndPerc = UnityEngine.Random.Range (0, 11);
		rndChar = UnityEngine.Random.Range (0, 11);

		// Attributes Title
		attributesTitleDel = (Text)Instantiate (attributesTitle);
		attributesTitleDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		attributesTitleDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		attributesTitleDel.text = "Attributes";
			
		attributesTitleDel.fontSize = 28;
		attributesTitleDel.transform.position = new Vector2 (315, 230);
		attributesTitleDel.rectTransform.sizeDelta = new Vector2 (200, 50);
		attributesTitleDel.gameObject.SetActive (false);
		
		//Health
		settlerHealthTextDel = (Text)Instantiate (settlerHealthText);
		settlerHealthTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerHealthTextDel.rectTransform.sizeDelta = new Vector2 (300, 100);
		settlerHealthTextDel.transform.position = new Vector2 (260, 177);
		settlerHealthTextDel.text = "Health: " + agentLogic.health;
		settlerHealthTextDel.gameObject.SetActive (false);
		settlerHealthTextDel.fontSize = 16;
		
		//Stamina
		settlerStaminaTextDel = (Text)Instantiate (settlerStaminaText);
		settlerStaminaTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerStaminaTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
		settlerStaminaTextDel.transform.position = new Vector2 (260, 137);
		settlerStaminaTextDel.text = "Stamina: " + rndStam;
		settlerStaminaTextDel.gameObject.SetActive (false);
		settlerStaminaTextDel.fontSize = 16;

		//Morale
		settlerMoraleTextDel = (Text)Instantiate (settlerMoraleText);
		settlerMoraleTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerMoraleTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
		settlerMoraleTextDel.transform.position = new Vector2 (260, 97);
		settlerMoraleTextDel.text = "Morale: " + rndMor;
		settlerMoraleTextDel.gameObject.SetActive (false);
		settlerMoraleTextDel.fontSize = 16;

		//Hunger
		settlerHungerTextDel = (Text)Instantiate (settlerHungerText);
		settlerHungerTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerHungerTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
		settlerHungerTextDel.transform.position = new Vector2 (260, 57);
		settlerHungerTextDel.text = "Hunger: " + agentLogic.hungerValue;
		settlerHungerTextDel.gameObject.SetActive (false);
		settlerHungerTextDel.fontSize = 16;

		//Thirst
		settlerThirstTextDel = (Text)Instantiate (settlerThirstText);
		settlerThirstTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerThirstTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
		settlerThirstTextDel.transform.position = new Vector2 (260, 17);
		settlerThirstTextDel.text = "Thirst: " + rndThir;
		settlerThirstTextDel.gameObject.SetActive (false);
		settlerThirstTextDel.fontSize = 16;

		//Strength
		settlerStrengthTextDel = (Text)Instantiate (settlerStrengthText);
		settlerStrengthTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerStrengthTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
		settlerStrengthTextDel.transform.position = new Vector2 (360, 177);
		settlerStrengthTextDel.text = "Strength: " + rndStr;
		settlerStrengthTextDel.gameObject.SetActive (false);
		settlerStrengthTextDel.fontSize = 16;

		//Intelligence
		settlerIntelligenceTextDel = (Text)Instantiate (settlerIntelligenceText);
		settlerIntelligenceTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerIntelligenceTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
		settlerIntelligenceTextDel.transform.position = new Vector2 (360, 137);
		settlerIntelligenceTextDel.text = "Intelligence: " + rndInt;
		settlerIntelligenceTextDel.gameObject.SetActive (false);
		settlerIntelligenceTextDel.fontSize = 16;

		//Agility
		settlerAgilityTextDel = (Text)Instantiate (settlerAgilityText);
		settlerAgilityTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerAgilityTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
		settlerAgilityTextDel.transform.position = new Vector2 (360, 97);
		settlerAgilityTextDel.text = "Agility: " + rndAgil;
		settlerAgilityTextDel.gameObject.SetActive (false);
		settlerAgilityTextDel.fontSize = 16;

		//Perception
		settlerPerceptionTextDel = (Text)Instantiate (settlerPerceptionText);
		settlerPerceptionTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerPerceptionTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
		settlerPerceptionTextDel.transform.position = new Vector2 (360, 57);
		settlerPerceptionTextDel.text = "Perception: " + rndPerc;
		settlerPerceptionTextDel.gameObject.SetActive (false);
		settlerPerceptionTextDel.fontSize = 16;

		//Charisma
		settlerCharismaTextDel = (Text)Instantiate (settlerCharismaText);
		settlerCharismaTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerCharismaTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
		settlerCharismaTextDel.transform.position = new Vector2 (360, 17);
		settlerCharismaTextDel.text = "Charisma: " + rndChar;
		settlerCharismaTextDel.gameObject.SetActive (false);
		settlerCharismaTextDel.fontSize = 16;
		
		//=========================\\
		//=== Settler Inventory ===\\
		//=========================\\
		// Inventory Title
		inventoryTitleDel = (Text)Instantiate (inventoryTitle);
		inventoryTitleDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		inventoryTitleDel.transform.Translate (960, Screen.height - 50, 0);
		inventoryTitleDel.text = "Inventory";
		
		inventoryTitleDel.fontSize = 28;
		inventoryTitleDel.transform.position = new Vector2 (515, 230);
		inventoryTitleDel.rectTransform.sizeDelta = new Vector2 (200, 50);
		inventoryTitleDel.gameObject.SetActive (false);
		
		//====================\\
		//=== Settler Role ===\\
		//====================\\
		//Roles Title
		rolesTitleDel = (Text)Instantiate (rolesTitle);
		rolesTitleDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		rolesTitleDel.transform.Translate (960, Screen.height - 50, 0);
		rolesTitleDel.text = "Role";
		
		rolesTitleDel.fontSize = 28;
		rolesTitleDel.transform.position = new Vector2 (715, 230);
		rolesTitleDel.rectTransform.sizeDelta = new Vector2 (200, 50);
		rolesTitleDel.gameObject.SetActive (false);
		
		//Farmer Role Button
		farmerRoleButtonDel = (Button)Instantiate (farmerRoleButton);
		farmerRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		farmerRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (100, 50);
		farmerRoleButtonDel.transform.Translate (669, 175, 0);
		farmerRoleButtonDel.GetComponentInChildren<Text> ().text = "Farmer";
		farmerRoleButtonDel.onClick.AddListener (() => farmerRoleClicked());
		farmerRoleButtonDel.gameObject.SetActive (false);
		
		//Water Purifier Role Button
		waterPurifierRoleButtonDel = (Button)Instantiate (waterPurifierRoleButton);
		waterPurifierRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		waterPurifierRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (100, 50);
		waterPurifierRoleButtonDel.transform.Translate (669, 125, 0);
		waterPurifierRoleButtonDel.GetComponentInChildren<Text> ().text = "Water Purifier";
		waterPurifierRoleButtonDel.onClick.AddListener (() => waterPurifierRoleClicked());
		waterPurifierRoleButtonDel.gameObject.SetActive (false);

		//Power Engineer Role Button
		powerEngineerRoleButtonDel = (Button)Instantiate (powerEngineerRoleButton);
		powerEngineerRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		powerEngineerRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (100, 50);
		powerEngineerRoleButtonDel.transform.Translate (669, 75, 0);
		powerEngineerRoleButtonDel.GetComponentInChildren<Text> ().text = "Power Engineer";
		powerEngineerRoleButtonDel.onClick.AddListener (() => powerEngineerRoleClicked());
		powerEngineerRoleButtonDel.gameObject.SetActive (false);

		//Storage Worker Role Button
		storageWorkerRoleButtonDel = (Button)Instantiate (storageWorkerRoleButton);
		storageWorkerRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		storageWorkerRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (100, 50);
		storageWorkerRoleButtonDel.transform.Translate (669, 25, 0);
		storageWorkerRoleButtonDel.GetComponentInChildren<Text> ().text = "Storage Worker";
		//storageWorkerRoleButtonDel.onClick.AddListener (() => storageWorkerRoleClicked());
		storageWorkerRoleButtonDel.gameObject.SetActive (false);

		//Medic Role Button
		medicRoleButtonDel = (Button)Instantiate (medicRoleButton);
		medicRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		medicRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (100, 50);
		medicRoleButtonDel.transform.Translate (766, 175, 0);
		medicRoleButtonDel.GetComponentInChildren<Text> ().text = "Medic";
		medicRoleButtonDel.onClick.AddListener (() => medicRoleClicked());
		medicRoleButtonDel.gameObject.SetActive (false);

		//Teacher Role Button
		teacherRoleButtonDel = (Button)Instantiate (teacherRoleButton);
		teacherRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		teacherRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (100, 50);
		teacherRoleButtonDel.transform.Translate (766, 125, 0);
		teacherRoleButtonDel.GetComponentInChildren<Text> ().text = "Teacher";
		//teacherRoleButtonDel.onClick.AddListener (() => teacherRoleClicked());
		teacherRoleButtonDel.gameObject.SetActive (false);

		//Worshipper Role Button
		worshipperRoleButtonDel = (Button)Instantiate (worshipperRoleButton);
		worshipperRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		worshipperRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (100, 50);
		worshipperRoleButtonDel.transform.Translate (766, 75, 0);
		worshipperRoleButtonDel.GetComponentInChildren<Text> ().text = "Worshipper";
		//worshipperRoleButtonDel.onClick.AddListener (() => worshipperRoleClicked());
		worshipperRoleButtonDel.gameObject.SetActive (false);

		//Bartender Role Button
		bartenderRoleButtonDel = (Button)Instantiate (bartenderRoleButton);
		bartenderRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		bartenderRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (100, 50);
		bartenderRoleButtonDel.transform.Translate (766, 25, 0);
		bartenderRoleButtonDel.GetComponentInChildren<Text> ().text = "Bartender";
		//bartenderRoleButtonDel.onClick.AddListener (() => bartenderRoleClicked());
		bartenderRoleButtonDel.gameObject.SetActive (false);

		//Close Button
		exBtnDel = (Button)Instantiate (exBtn);
		exBtnDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		exBtnDel.image.rectTransform.sizeDelta = new Vector2 (20, 20);


		exBtnDel.transform.Translate (795, 286, 0);
		exBtnDel.GetComponentInChildren<Text> ().text = "";
		exBtnDel.gameObject.SetActive (false);
		exBtnDel.onClick.AddListener (() => exBtnClicked());
    }

	//=================\\
	//=== Functions ===\\
	//=================\\
    void OnMouseUp() {

        // When you click, change the variables value
        if (showMenu) {
			showMenu = false;
			inventoryTitleDel.gameObject.SetActive (false);
			rolesTitleDel.gameObject.SetActive (false);
			attributesTitleDel.gameObject.SetActive (false);
			SettlerInfoDelBg.gameObject.SetActive (false);
			farmerRoleButtonDel.gameObject.SetActive (false);
			waterPurifierRoleButtonDel.gameObject.SetActive (false);
			powerEngineerRoleButtonDel.gameObject.SetActive (false);
			storageWorkerRoleButtonDel.gameObject.SetActive (false);
			medicRoleButtonDel.gameObject.SetActive (false);
			teacherRoleButtonDel.gameObject.SetActive (false);
			worshipperRoleButtonDel.gameObject.SetActive (false);
			bartenderRoleButtonDel.gameObject.SetActive (false);
			exBtnDel.gameObject.SetActive (false);
			genericProfileIconDel.gameObject.SetActive (false);
			firstLastNameDel.gameObject.SetActive (false);
			//Attributes
			settlerHealthTextDel.gameObject.SetActive (false);
			settlerStaminaTextDel.gameObject.SetActive (false);
			settlerMoraleTextDel.gameObject.SetActive (false);
			settlerHungerTextDel.gameObject.SetActive (false);
			settlerThirstTextDel.gameObject.SetActive (false);
			settlerStrengthTextDel.gameObject.SetActive (false);
			settlerIntelligenceTextDel.gameObject.SetActive (false);
			settlerAgilityTextDel.gameObject.SetActive (false);
			settlerPerceptionTextDel.gameObject.SetActive (false);
			settlerCharismaTextDel.gameObject.SetActive (false);
		}
		else {
			showMenu = true;

			
			firstLastNameDel.gameObject.SetActive (true);

			//Randomizing attributes when settler info box pops up
			rndHP  = UnityEngine.Random.Range (1, 101);
			rndStam = UnityEngine.Random.Range (0, 101);
			rndMor = UnityEngine.Random.Range (0, 101);
			rndHung = UnityEngine.Random.Range (0, 101);
			rndThir = UnityEngine.Random.Range (0, 101);
			rndStr = UnityEngine.Random.Range (0, 11);
			rndInt = UnityEngine.Random.Range (0, 11);
			rndAgil = UnityEngine.Random.Range (0, 11);
			rndPerc = UnityEngine.Random.Range (0, 11);
			rndChar = UnityEngine.Random.Range (0, 11);

			inventoryTitleDel.gameObject.SetActive (true);
			rolesTitleDel.gameObject.SetActive (true);
			attributesTitleDel.gameObject.SetActive (true);
			SettlerInfoDelBg.gameObject.SetActive (true);
			farmerRoleButtonDel.gameObject.SetActive (true);
			waterPurifierRoleButtonDel.gameObject.SetActive (true);
			powerEngineerRoleButtonDel.gameObject.SetActive (true);
			storageWorkerRoleButtonDel.gameObject.SetActive (true);
			medicRoleButtonDel.gameObject.SetActive (true);
			teacherRoleButtonDel.gameObject.SetActive (true);
			worshipperRoleButtonDel.gameObject.SetActive (true);
			bartenderRoleButtonDel.gameObject.SetActive (true);
			exBtnDel.gameObject.SetActive (true);
			genericProfileIconDel.gameObject.SetActive (true);
			//Attributes
			settlerHealthTextDel.gameObject.SetActive (true);
			settlerStaminaTextDel.gameObject.SetActive (true);
			settlerMoraleTextDel.gameObject.SetActive (true);
			settlerHungerTextDel.gameObject.SetActive (true);
			settlerThirstTextDel.gameObject.SetActive (true);
			settlerStrengthTextDel.gameObject.SetActive (true);
			settlerIntelligenceTextDel.gameObject.SetActive (true);
			settlerAgilityTextDel.gameObject.SetActive (true);
			settlerPerceptionTextDel.gameObject.SetActive (true);
			settlerCharismaTextDel.gameObject.SetActive (true);
		}
    }

	void farmerRoleClicked () {
		if ((agentLogic.jobState != AgentLogic_07.jobSubState.Farmer) && farmAvailable) {
			//Obtain all farm waypoints that the agent should move between when working
			agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag ("FarmWaypoint"));
			
			//Set the agent to working
			agentLogic.aState = AgentLogic_07.agentState.Working;
			
			//Define the working state as farming
			agentLogic.jobState = AgentLogic_07.jobSubState.Farmer;
		}
	}

	void waterPurifierRoleClicked () {
		if ((agentLogic.jobState != AgentLogic_07.jobSubState.WaterPurifier) && waterstationAvailable) {
			agentLogic.workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("WaterWaypoint"));
			
			//Set the agent to working
			agentLogic.aState = AgentLogic_07.agentState.Working;
			
			//Define the working state as farming
			agentLogic.jobState = AgentLogic_07.jobSubState.WaterPurifier;
		}
	}

	void powerEngineerRoleClicked () {
		if ((agentLogic.jobState != AgentLogic_07.jobSubState.PowerWorker) && powerstationAvailable) {
			//Obtain all farm waypoints that the agent should move between when working
			agentLogic.workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("PowerWaypoint"));
			
			//Set the agent to working
			agentLogic.aState = AgentLogic_07.agentState.Working;
			
			//Define the working state as farming
			agentLogic.jobState = AgentLogic_07.jobSubState.PowerWorker;
		}
	}

//	void storageWorkerRoleClicked () {
//		//STORAGE WORKER
//	}

	void medicRoleClicked () {
		if ((agentLogic.jobState != AgentLogic_07.jobSubState.Medic) && hospitalAvailable) {
			agentLogic.workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("HospitalWaypoint"));
		
			//Shuffle the order of the waypoints
			for (int i = 0; i < agentLogic.workWaypoints.Count; i++){
				
				//Set the current list value to a temp var
				GameObject temp = agentLogic.workWaypoints[i];
				
				//Obtain a random index value within the scope of the waypoint list size
				int randomIndex = UnityEngine.Random.Range (i, agentLogic.workWaypoints.Count);
				
				//Set the current list index to the new shuffled index
				agentLogic.workWaypoints[i] = agentLogic.workWaypoints[randomIndex];
				
				//Replace the contents into the list
				agentLogic.workWaypoints[randomIndex] = temp;
			}
			
			//Set the agent to working
			agentLogic.aState = AgentLogic_07.agentState.Working;
			
			//Define the working state as farming
			agentLogic.jobState = AgentLogic_07.jobSubState.Medic;
		}
	}

//	void teacherRoleClicked () {
//		//TEACHER
//	}
//
//	void worshipperRoleClicked () {
//		//WORSHIPPER
//	}
//
//	void bartenderRoleClicked () {
//		//BARTENDER
//	}

	void exBtnClicked () {
		showMenu = false;
		inventoryTitleDel.gameObject.SetActive (false);
		rolesTitleDel.gameObject.SetActive (false);
		attributesTitleDel.gameObject.SetActive (false);
		SettlerInfoDelBg.gameObject.SetActive (false);
		farmerRoleButtonDel.gameObject.SetActive (false);
		waterPurifierRoleButtonDel.gameObject.SetActive (false);
		powerEngineerRoleButtonDel.gameObject.SetActive (false);
		storageWorkerRoleButtonDel.gameObject.SetActive (false);
		medicRoleButtonDel.gameObject.SetActive (false);
		teacherRoleButtonDel.gameObject.SetActive (false);
		worshipperRoleButtonDel.gameObject.SetActive (false);
		bartenderRoleButtonDel.gameObject.SetActive (false);
		exBtnDel.gameObject.SetActive (false);
		genericProfileIconDel.gameObject.SetActive (false);
		firstLastNameDel.gameObject.SetActive (false);
		//Attributes
		settlerHealthTextDel.gameObject.SetActive (false);
		settlerStaminaTextDel.gameObject.SetActive (false);
		settlerMoraleTextDel.gameObject.SetActive (false);
		settlerHungerTextDel.gameObject.SetActive (false);
		settlerThirstTextDel.gameObject.SetActive (false);
		settlerStrengthTextDel.gameObject.SetActive (false);
		settlerIntelligenceTextDel.gameObject.SetActive (false);
		settlerAgilityTextDel.gameObject.SetActive (false);
		settlerPerceptionTextDel.gameObject.SetActive (false);
		settlerCharismaTextDel.gameObject.SetActive (false);
	}

	//==================\\
	//===== Update =====\\
	//==================\\

    void Update() {
		//Re setting random name and attributes
		firstLastNameDel.text = firstNameArray [randomFirstName] + " " + lastNameArray [randomLastName] + " (" + agentLogic.aState + ")";

		settlerHealthTextDel.text = "Health: " + agentLogic.health;
		settlerStaminaTextDel.text = "Stamina: " + rndStam;
		settlerMoraleTextDel.text = "Morale: " + rndMor;
		settlerHungerTextDel.text = "Hunger: " + agentLogic.hungerValue;
		settlerThirstTextDel.text = "Thirst: " + rndThir;
		settlerStrengthTextDel.text = "Strength: " + rndStr;
		settlerIntelligenceTextDel.text = "Intelligence: " + rndInt;
		settlerAgilityTextDel.text = "Agility: " + rndAgil;
		settlerPerceptionTextDel.text = "Perception: " + rndPerc;
		settlerCharismaTextDel.text = "Charisma: " + rndChar;

		////

		//Check to see if there are any gameobjects with the appropriate building tag
		if (!GameObject.FindWithTag ("Farm"))
		{
			farmAvailable = false;
			farmerRoleButtonDel.interactable = false;
		}
		else {
			farmAvailable = true;
			farmerRoleButtonDel.interactable = true;
		}
		
        if (!GameObject.FindWithTag ("WaterStation"))
        {
            waterstationAvailable = false;
			waterPurifierRoleButtonDel.interactable = false;
        }
        else
        {
            waterstationAvailable = true;
			waterPurifierRoleButtonDel.interactable = true;
        }

        if (!GameObject.FindWithTag ("PowerStation"))
        {
            powerstationAvailable = false;
			powerEngineerRoleButtonDel.interactable = false;
        }
        else
        {
            powerstationAvailable = true;
			powerEngineerRoleButtonDel.interactable = true;
        }

		if (!GameObject.FindWithTag ("Hospital"))
		{
			hospitalAvailable = false;
			medicRoleButtonDel.interactable = false;
		}
		else {
			hospitalAvailable = true;
			medicRoleButtonDel.interactable = true;
		}

		if (!GameObject.FindWithTag("Storage")) { 

		    storageAvailable = false;
		    storageWorkerRoleButtonDel.interactable = false;
        }
        else {
            storageAvailable = true;
            storageWorkerRoleButtonDel.interactable = true;
        }

        if (!GameObject.FindWithTag ("School")) {
            schoolAvailable = false;
            teacherRoleButtonDel.interactable = false;
        }
        else {
            schoolAvailable = true;
            teacherRoleButtonDel.interactable = true;
        }

		if (!GameObject.FindWithTag ("Shrine")) {
            shrineAvailable = false;
            worshipperRoleButtonDel.interactable = false;
        }
        else {
            shrineAvailable = true;
            worshipperRoleButtonDel.interactable = true;
        }

        if (!GameObject.FindWithTag ("Tavern")) {
            tavernAvailable = false;
            bartenderRoleButtonDel.interactable = false;
        }
        else {
            tavernAvailable = true;
            bartenderRoleButtonDel.interactable = true;
        }
	}

	IEnumerator MissingBuildingError (float wait, string building) {
		if (showError)
		{
			GUI.Box (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 50, 250, 25), "No Building with tag " + building + " placed...");
			yield return new WaitForSeconds (wait);
			showError = false;
		}
	}
}