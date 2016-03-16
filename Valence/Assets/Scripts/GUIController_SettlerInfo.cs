using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class GUIController_SettlerInfo : MonoBehaviour {

    bool showMenu = false;

	public GameController _gameController;

    //Assign agent fsm to this GUI
    public AgentLogic_07 agentLogic;
	public AgentAttributes agentAttributes;

	//Return true if a gameobject with corresponding tag has been spawned, vise versa for false
	bool farmAvailable, hospitalAvailable, waterstationAvailable, powerstationAvailable, storageAvailable, traininggroundAvailable;

    //Return true if error message should be shown
    bool showError;

	Canvas myCanvas;

    public SpriteRenderer selectedIcon;

    public Image SettlerInfoBg;
	Image SettlerInfoDelBg;

	public Image genericProfileIcon;
	Image genericProfileIconDel;

	public Text firstLastName;
	Text firstLastNameDel;
	
	// === Settler Attributes === \\
	public Image settlerHealthImage, settlerStaminaImage, settlerMoraleImage, settlerHungerImage, settlerThirstImage;
	Image settlerHealthImageDel, settlerStaminaImageDel, settlerMoraleImageDel, settlerHungerImageDel, settlerThirstImageDel;

	public Text attributesTitle, settlerHealthText, settlerStaminaText, settlerMoraleText, settlerHungerText, settlerThirstText;
	Text attributesTitleDel, settlerHealthTextDel, settlerStaminaTextDel, settlerMoraleTextDel, settlerHungerTextDel, settlerThirstTextDel;

	// === Settler Traits === \\
	public Image settlerStrengthImage, settlerIntelligenceImage, settlerAgilityImage, settlerPerceptionImage, settlerCharismaImage;
	Image settlerStrengthImageDel, settlerIntelligenceImageDel, settlerAgilityImageDel, settlerPerceptionImageDel, settlerCharismaImageDel;
	
	public Text settlerStrengthText, settlerIntelligenceText, settlerAgilityText, settlerPerceptionText, settlerCharismaText;
	Text settlerStrengthTextDel, settlerIntelligenceTextDel, settlerAgilityTextDel, settlerPerceptionTextDel, settlerCharismaTextDel;

	int rndHP,rndStam, rndMor, rndHung, rndThir, rndStr, rndInt, rndAgil, rndPerc, rndChar;
	
	// === Settler Inventory === \\
	public Text inventoryTitle;
	Text inventoryTitleDel;

	public Text inventoryFoodText;
	Text inventoryFoodTextDel;
	
	// === Settler Assign Role === \\
	public Text rolesTitle;
	Text rolesTitleDel;

	//Font
	public Font font_hero;
	
	public Button farmerRoleButton, hydrologistRoleButton, powerEngineerRoleButton, traineeRoleButton;
	Button farmerRoleButtonDel, hydrologistRoleButtonDel, powerEngineerRoleButtonDel, traineeRoleButtonDel;

	// === Close Window Button === \\
	public Button exBtn;
	Button exBtnDel;

	public GameObject myCamObj;

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
		traininggroundAvailable = false;


		_gameController = GameObject.Find ("GameController").GetComponent<GameController> ();

		myCamObj = GameObject.Find ("CameraObject");

        myCanvas = GameObject.Find ("Canvas").GetComponent <Canvas>();
        selectedIcon = GetComponentInChildren<SpriteRenderer>();

        //===============================\\
        //=== Settler Info Background ===\\
        //===============================\\
        SettlerInfoDelBg = (Image)Instantiate (SettlerInfoBg);
		SettlerInfoDelBg.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		SettlerInfoDelBg.rectTransform.sizeDelta = new Vector2 (821, 306);
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
		firstLastNameDel = (Text)Instantiate (firstLastName);
		firstLastNameDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		firstLastNameDel.rectTransform.sizeDelta = new Vector2 (600, 50);
		firstLastNameDel.transform.position = new Vector2 (500, 279);
		
		firstLastNameDel.fontSize = 28;
		firstLastNameDel.gameObject.SetActive (false);

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
		settlerHealthImageDel = (Image)Instantiate (settlerHealthImage);
		settlerHealthImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerHealthImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerHealthImageDel.transform.Translate (240, 177, 0);
		settlerHealthImageDel.gameObject.SetActive (false);

			//Text
			settlerHealthTextDel = (Text)Instantiate (settlerHealthText);
			settlerHealthTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerHealthTextDel.rectTransform.sizeDelta = new Vector2 (300, 100);
			settlerHealthTextDel.transform.position = new Vector2 (settlerHealthImageDel.rectTransform.position.x + 45, settlerHealthImageDel.rectTransform.position.y);
			settlerHealthTextDel.gameObject.SetActive (false);
			settlerHealthTextDel.fontSize = 18;
		
		//Stamina
		settlerStaminaImageDel = (Image)Instantiate (settlerStaminaImage);
		settlerStaminaImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerStaminaImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerStaminaImageDel.transform.Translate (settlerHealthImageDel.rectTransform.position.x, settlerHealthImageDel.rectTransform.position.y - 50, 0);
		settlerStaminaImageDel.gameObject.SetActive (false);
		
			//Text
			settlerStaminaTextDel = (Text)Instantiate (settlerStaminaText);
			settlerStaminaTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerStaminaTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerStaminaTextDel.transform.position = new Vector2 (settlerStaminaImageDel.rectTransform.position.x + 45, settlerStaminaImageDel.rectTransform.position.y);
			settlerStaminaTextDel.gameObject.SetActive (false);
			settlerStaminaTextDel.fontSize = 18;

		//Hunger
		settlerHungerImageDel = (Image)Instantiate (settlerHungerImage);
		settlerHungerImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerHungerImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerHungerImageDel.transform.Translate (settlerHealthImageDel.rectTransform.position.x, settlerStaminaImageDel.rectTransform.position.y - 50, 0);
		settlerHungerImageDel.gameObject.SetActive (false);
		
			//Text
			settlerHungerTextDel = (Text)Instantiate (settlerHungerText);
			settlerHungerTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerHungerTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerHungerTextDel.transform.position = new Vector2 (settlerHungerImageDel.rectTransform.position.x + 45, settlerHungerImageDel.rectTransform.position.y);
			settlerHungerTextDel.gameObject.SetActive (false);
			settlerHungerTextDel.fontSize = 18;

		//Thirst
		settlerThirstImageDel = (Image)Instantiate (settlerThirstImage);
		settlerThirstImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerThirstImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerThirstImageDel.transform.Translate (settlerHealthImageDel.rectTransform.position.x, settlerHungerImageDel.rectTransform.position.y - 50, 0);
		settlerThirstImageDel.gameObject.SetActive (false);
		
			//Text
			settlerThirstTextDel = (Text)Instantiate (settlerThirstText);
			settlerThirstTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerThirstTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerThirstTextDel.transform.position = new Vector2 (settlerThirstImageDel.rectTransform.position.x + 45, settlerThirstImageDel.rectTransform.position.y);
			settlerThirstTextDel.gameObject.SetActive (false);
			settlerThirstTextDel.fontSize = 18;

		//======================\\
		//=== Settler Traits ===\\
		//======================\\
		//Strength
		settlerStrengthImageDel = (Image)Instantiate (settlerStrengthImage);
		settlerStrengthImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerStrengthImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerStrengthImageDel.transform.Translate (settlerHealthImageDel.transform.position.x + 115, settlerHealthImageDel.rectTransform.position.y, 0);
		settlerStrengthImageDel.gameObject.SetActive (false);
		
			//Text
			settlerStrengthTextDel = (Text)Instantiate (settlerStrengthText);
			settlerStrengthTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerStrengthTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerStrengthTextDel.transform.position = new Vector2 (settlerStrengthImageDel.rectTransform.position.x + 45, settlerStrengthImageDel.rectTransform.position.y);
			settlerStrengthTextDel.gameObject.SetActive (false);
			settlerStrengthTextDel.fontSize = 18;

		//Intelligence
		settlerIntelligenceImageDel = (Image)Instantiate (settlerIntelligenceImage);
		settlerIntelligenceImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerIntelligenceImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerIntelligenceImageDel.transform.Translate (settlerStrengthImageDel.rectTransform.position.x, settlerStrengthImageDel.rectTransform.position.y - 37.5f, 0);
		settlerIntelligenceImageDel.gameObject.SetActive (false);
		
			//Text
			settlerIntelligenceTextDel = (Text)Instantiate (settlerIntelligenceText);
			settlerIntelligenceTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerIntelligenceTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerIntelligenceTextDel.transform.position = new Vector2 (settlerIntelligenceImageDel.rectTransform.position.x + 45, settlerIntelligenceImageDel.rectTransform.position.y);
			settlerIntelligenceTextDel.gameObject.SetActive (false);
			settlerIntelligenceTextDel.fontSize = 18;

		//Agility
		settlerAgilityImageDel = (Image)Instantiate (settlerAgilityImage);
		settlerAgilityImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerAgilityImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerAgilityImageDel.transform.Translate (settlerStrengthImageDel.rectTransform.position.x, settlerIntelligenceImageDel.rectTransform.position.y - 37.5f, 0);
		settlerAgilityImageDel.gameObject.SetActive (false);
		
			//Text
			settlerAgilityTextDel = (Text)Instantiate (settlerAgilityText);
			settlerAgilityTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerAgilityTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerAgilityTextDel.transform.position = new Vector2 (settlerAgilityImageDel.rectTransform.position.x + 45, settlerAgilityImageDel.rectTransform.position.y);
			settlerAgilityTextDel.gameObject.SetActive (false);
			settlerAgilityTextDel.fontSize = 18;

		//Perception
		settlerPerceptionImageDel = (Image)Instantiate (settlerPerceptionImage);
		settlerPerceptionImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerPerceptionImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerPerceptionImageDel.transform.Translate (settlerStrengthImageDel.rectTransform.position.x, settlerAgilityImageDel.rectTransform.position.y - 37.5f, 0);
		settlerPerceptionImageDel.gameObject.SetActive (false);
		
			//Text
			settlerPerceptionTextDel = (Text)Instantiate (settlerPerceptionText);
			settlerPerceptionTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerPerceptionTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerPerceptionTextDel.transform.position = new Vector2 (settlerPerceptionImageDel.rectTransform.position.x + 45, settlerPerceptionImageDel.rectTransform.position.y);
			settlerPerceptionTextDel.gameObject.SetActive (false);
			settlerPerceptionTextDel.fontSize = 18;

		//Charisma
		settlerCharismaImageDel = (Image)Instantiate (settlerCharismaImage);
		settlerCharismaImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerCharismaImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerCharismaImageDel.transform.Translate (settlerStrengthImageDel.rectTransform.position.x, settlerPerceptionImageDel.rectTransform.position.y - 37.5f, 0);
		settlerCharismaImageDel.gameObject.SetActive (false);
		
			//Text
			settlerCharismaTextDel = (Text)Instantiate (settlerCharismaText);
			settlerCharismaTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerCharismaTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerCharismaTextDel.transform.position = new Vector2 (settlerCharismaImageDel.rectTransform.position.x + 45, settlerCharismaImageDel.rectTransform.position.y);
			settlerCharismaTextDel.gameObject.SetActive (false);
			settlerCharismaTextDel.fontSize = 18;
		
		//=========================\\
		//=== Settler Inventory ===\\
		//=========================\\
		// Inventory Title
		inventoryTitleDel = (Text)Instantiate (inventoryTitle);
		inventoryTitleDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		inventoryTitleDel.text = "Inventory";
		
		inventoryTitleDel.fontSize = 28;
		inventoryTitleDel.transform.position = new Vector2 (515, 230);
		inventoryTitleDel.rectTransform.sizeDelta = new Vector2 (150, 100);
		inventoryTitleDel.gameObject.SetActive (false);

		//Inventory Food
		inventoryFoodTextDel = (Text)Instantiate (inventoryFoodText);
		inventoryFoodTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		inventoryFoodTextDel.text = "Food: " + agentLogic.foodStored;
		inventoryFoodTextDel.transform.position = new Vector2 (settlerHealthTextDel.rectTransform.position.x + 220, settlerHealthTextDel.rectTransform.position.y);
		inventoryFoodTextDel.rectTransform.sizeDelta = new Vector2 (150, 50);
		inventoryFoodTextDel.gameObject.SetActive (false);
		inventoryFoodTextDel.fontSize = 18;
		
		//====================\\
		//=== Settler Role ===\\
		//====================\\
		//Roles Title
		rolesTitleDel = (Text)Instantiate (rolesTitle);
		rolesTitleDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		rolesTitleDel.text = "Role";
		
		rolesTitleDel.fontSize = 28;
		rolesTitleDel.transform.position = new Vector2 (715, 230);
		rolesTitleDel.rectTransform.sizeDelta = new Vector2 (200, 50);
		rolesTitleDel.gameObject.SetActive (false);

		//Farmer Role Button
		farmerRoleButtonDel = (Button)Instantiate (farmerRoleButton);
		farmerRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		farmerRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (160, 35);
		farmerRoleButtonDel.transform.Translate (settlerHealthImageDel.rectTransform.position.x + 475, settlerHealthImageDel.rectTransform.position.y, 0);
		farmerRoleButtonDel.GetComponentInChildren<Text> ().text = "Farmer";
		farmerRoleButtonDel.GetComponentInChildren<Text> ().font = font_hero;
		farmerRoleButtonDel.onClick.AddListener (() => farmerRoleClicked());
		farmerRoleButtonDel.gameObject.SetActive (false);
		
		//Hydrologist Role Button
		hydrologistRoleButtonDel = (Button)Instantiate (hydrologistRoleButton);
		hydrologistRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		hydrologistRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (160, 35);
		hydrologistRoleButtonDel.transform.Translate (farmerRoleButtonDel.image.rectTransform.position.x, farmerRoleButtonDel.image.rectTransform.position.y - 37.5f, 0);
		hydrologistRoleButtonDel.GetComponentInChildren<Text> ().text = "Hydrologist";
		hydrologistRoleButtonDel.GetComponentInChildren<Text> ().font = font_hero;
		hydrologistRoleButtonDel.onClick.AddListener (() => waterPurifierRoleClicked());
		hydrologistRoleButtonDel.gameObject.SetActive (false);

		//Power Engineer Role Button
		powerEngineerRoleButtonDel = (Button)Instantiate (powerEngineerRoleButton);
		powerEngineerRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		powerEngineerRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (160, 35);
		powerEngineerRoleButtonDel.transform.Translate (farmerRoleButtonDel.image.rectTransform.position.x, hydrologistRoleButtonDel.image.rectTransform.position.y - 37.5f, 0);
		powerEngineerRoleButtonDel.GetComponentInChildren<Text> ().text = "Power Engineer";
		powerEngineerRoleButtonDel.GetComponentInChildren<Text> ().font = font_hero;
		powerEngineerRoleButtonDel.onClick.AddListener (() => powerEngineerRoleClicked());
		powerEngineerRoleButtonDel.gameObject.SetActive (false);

		//Trainee Role Button
		traineeRoleButtonDel = (Button)Instantiate (traineeRoleButton);
		traineeRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		traineeRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (160, 35);
		traineeRoleButtonDel.transform.Translate (farmerRoleButtonDel.image.rectTransform.position.x, powerEngineerRoleButtonDel.image.rectTransform.position.y - 37.5f, 0);
		traineeRoleButtonDel.GetComponentInChildren<Text> ().text = "Trainee";
		traineeRoleButtonDel.GetComponentInChildren<Text> ().font = font_hero;
		traineeRoleButtonDel.onClick.AddListener (() => traineeRoleClicked());
		traineeRoleButtonDel.gameObject.SetActive (false);

		//Close Button
		exBtnDel = (Button)Instantiate (exBtn);
		exBtnDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		exBtnDel.image.rectTransform.sizeDelta = new Vector2 (20, 20);
		exBtnDel.transform.Translate (795, 286, 0);
		exBtnDel.GetComponentInChildren<Text> ().text = "";
		exBtnDel.gameObject.SetActive (false);
		exBtnDel.onClick.AddListener (() => exBtnClicked());

		agentAttributes = GetComponent <AgentAttributes> ();
    }

	//=================\\
	//=== Functions ===\\
	//=================\\
	void OnMouseUp () {
		// When you click, change the variables value
		if (showMenu) {
			showMenu = false;
			myCamObj.GetComponent<CameraTargetController>().following = false;

			_gameController.currentSettlerUI = null;

			print ("The currently selected object is: " + gameObject);
		} else{
			showMenu = true;

			if( _gameController.currentSettlerUI != null ){
				_gameController.currentSettlerUI.exBtnClicked();
			}
			_gameController.currentSettlerUI = this;

			firstLastNameDel.gameObject.SetActive (true);

			//here
			myCamObj.GetComponent<CameraTargetController>().followTarget = this.gameObject;
			myCamObj.GetComponent<CameraTargetController>().following = true;

			//Randomizing attributes when settler info box pops up
			rndHP = UnityEngine.Random.Range (1, 101);
			rndStam = UnityEngine.Random.Range (0, 101);
			rndMor = UnityEngine.Random.Range (0, 101);
			rndHung = UnityEngine.Random.Range (0, 101);
			rndThir = UnityEngine.Random.Range (0, 101);
			rndStr = UnityEngine.Random.Range (0, 11);
			rndInt = UnityEngine.Random.Range (0, 11);
			rndAgil = UnityEngine.Random.Range (0, 11);
			rndPerc = UnityEngine.Random.Range (0, 11);
			rndChar = UnityEngine.Random.Range (0, 11);
		}
	}

	void resetJoblists (AgentLogic_07.jobSubState oldState) {
		if (oldState == AgentLogic_07.jobSubState.Farmer) {
			_gameController.farmerList.Remove(this.gameObject);
		}
		if (oldState == AgentLogic_07.jobSubState.PowerWorker) {
			_gameController.powerWorkerList.Remove(this.gameObject);
		}
		if (oldState == AgentLogic_07.jobSubState.Hydrologist) {
			_gameController.waterWorkerList.Remove(this.gameObject);
		}
	}

	void farmerRoleClicked () {
		if ((agentLogic.jobState != AgentLogic_07.jobSubState.Farmer) && farmAvailable) {
			//Obtain all farm waypoints that the agent should move between when working
			agentLogic.workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("FarmWaypoint"));
			
			//Set the agent to working
			agentLogic.aState = AgentLogic_07.agentState.Working;

			if (agentLogic.jobState != AgentLogic_07.jobSubState.Default)
				resetJoblists (agentLogic.jobState);
			//Define the working state as farming
			agentLogic.jobState = AgentLogic_07.jobSubState.Farmer;
		}
	}

	void waterPurifierRoleClicked () {
		if ((agentLogic.jobState != AgentLogic_07.jobSubState.Hydrologist) && waterstationAvailable) {
			agentLogic.workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("WaterWaypoint"));
			
			//Set the agent to working
			agentLogic.aState = AgentLogic_07.agentState.Working;
			if( agentLogic.jobState != AgentLogic_07.jobSubState.Default)
				resetJoblists (agentLogic.jobState);
			//Define the working state as farming
			agentLogic.jobState = AgentLogic_07.jobSubState.Hydrologist;
		}
	}

	void powerEngineerRoleClicked () {
		if ((agentLogic.jobState != AgentLogic_07.jobSubState.PowerWorker) && powerstationAvailable) {
			//Obtain all farm waypoints that the agent should move between when working
			agentLogic.workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("PowerWaypoint"));
			if (agentLogic.jobState != AgentLogic_07.jobSubState.Default)
				resetJoblists (agentLogic.jobState);
			//Set the agent to working
			agentLogic.aState = AgentLogic_07.agentState.Working;
			
			//Define the working state as farming
			agentLogic.jobState = AgentLogic_07.jobSubState.PowerWorker;
		}
	}

//	void medicRoleClicked () {
//		if ((agentLogic.jobState != AgentLogic_07.jobSubState.Medic) && hospitalAvailable) {
//			agentLogic.workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("HospitalWaypoint"));
//		
//			//Shuffle the order of the waypoints
//			for (int i = 0; i < agentLogic.workWaypoints.Count; i++){
//				
//				//Set the current list value to a temp var
//				GameObject temp = agentLogic.workWaypoints[i];
//				
//				//Obtain a random index value within the scope of the waypoint list size
//				int randomIndex = UnityEngine.Random.Range (i, agentLogic.workWaypoints.Count);
//				
//				//Set the current list index to the new shuffled index
//				agentLogic.workWaypoints[i] = agentLogic.workWaypoints[randomIndex];
//				
//				//Replace the contents into the list
//				agentLogic.workWaypoints[randomIndex] = temp;
//			}
//			
//			//Set the agent to working
//			agentLogic.aState = AgentLogic_07.agentState.Working;
//			
//			//Define the working state as farming
//			agentLogic.jobState = AgentLogic_07.jobSubState.Medic;
//		}
//	}

	void traineeRoleClicked () {
        if ((agentLogic.jobState != AgentLogic_07.jobSubState.Trainee) && traininggroundAvailable)
        {
            agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("TrainingWaypoint"));

            //Shuffle the order of the waypoints
            for (int i = 0; i < agentLogic.workWaypoints.Count; i++)
            {

                //Set the current list value to a temp var
                GameObject temp = agentLogic.workWaypoints[i];

                //Obtain a random index value within the scope of the waypoint list size
                int randomIndex = UnityEngine.Random.Range(i, agentLogic.workWaypoints.Count);

                //Set the current list index to the new shuffled index
                agentLogic.workWaypoints[i] = agentLogic.workWaypoints[randomIndex];

                //Replace the contents into the list
                agentLogic.workWaypoints[randomIndex] = temp;
            }

            //Set the agent to working
            agentLogic.aState = AgentLogic_07.agentState.Working;

            //Define the working state as farming
            agentLogic.jobState = AgentLogic_07.jobSubState.Trainee;
        }
    }

	//When the close button is clicked
	public void exBtnClicked () {
		showMenu = false;
		_gameController.currentSettlerUI = null;
		myCamObj.GetComponent<CameraTargetController>().following = false;
	}

	//==================\\
	//===== Update =====\\
	//==================\\

    void Update() {
		switch (showMenu) {
		case true:
			selectedIcon.enabled = true;
			firstLastNameDel.gameObject.SetActive (true);

			selectedIcon.enabled = true;
			inventoryTitleDel.gameObject.SetActive (true);
			rolesTitleDel.gameObject.SetActive (true);
			attributesTitleDel.gameObject.SetActive (true);
			SettlerInfoDelBg.gameObject.SetActive (true);
			
			//Buttons
			farmerRoleButtonDel.gameObject.SetActive (true);
			hydrologistRoleButtonDel.gameObject.SetActive (true);
			powerEngineerRoleButtonDel.gameObject.SetActive (true);
			traineeRoleButtonDel.gameObject.SetActive (true);
			exBtnDel.gameObject.SetActive (true);
			
			genericProfileIconDel.gameObject.SetActive (true);
			inventoryFoodTextDel.gameObject.SetActive (true);
			
			//Attributes
			settlerHealthImageDel.gameObject.SetActive (true);
			settlerStaminaImageDel.gameObject.SetActive (true);
			settlerHungerImageDel.gameObject.SetActive (true);
			settlerThirstImageDel.gameObject.SetActive (true);
			
			settlerHealthTextDel.gameObject.SetActive (true);
			settlerStaminaTextDel.gameObject.SetActive (true);
			settlerHungerTextDel.gameObject.SetActive (true);
			settlerThirstTextDel.gameObject.SetActive (true);
			
			//Traits
			settlerStrengthImageDel.gameObject.SetActive (true);
			settlerIntelligenceImageDel.gameObject.SetActive (true);
			settlerAgilityImageDel.gameObject.SetActive (true);
			settlerPerceptionImageDel.gameObject.SetActive (true);
			settlerCharismaImageDel.gameObject.SetActive (true);
			settlerStrengthTextDel.gameObject.SetActive (true);
			settlerIntelligenceTextDel.gameObject.SetActive (true);
			settlerAgilityTextDel.gameObject.SetActive (true);
			settlerPerceptionTextDel.gameObject.SetActive (true);
			settlerCharismaTextDel.gameObject.SetActive (true);
			break;
		case false:
			selectedIcon.enabled = false;
			inventoryTitleDel.gameObject.SetActive (false);
			rolesTitleDel.gameObject.SetActive (false);
			attributesTitleDel.gameObject.SetActive (false);
			SettlerInfoDelBg.gameObject.SetActive (false);
			
			//Buttons
			farmerRoleButtonDel.gameObject.SetActive (false);
			hydrologistRoleButtonDel.gameObject.SetActive (false);
			powerEngineerRoleButtonDel.gameObject.SetActive (false);
			traineeRoleButtonDel.gameObject.SetActive (false);
			exBtnDel.gameObject.SetActive (false);
			
			genericProfileIconDel.gameObject.SetActive (false);
			firstLastNameDel.gameObject.SetActive (false);
			inventoryFoodTextDel.gameObject.SetActive (false);
			
			//Attributes
			settlerHealthImageDel.gameObject.SetActive (false);
			settlerStaminaImageDel.gameObject.SetActive (false);
			settlerHungerImageDel.gameObject.SetActive (false);
			settlerThirstImageDel.gameObject.SetActive (false);
			
			settlerHealthTextDel.gameObject.SetActive (false);
			settlerStaminaTextDel.gameObject.SetActive (false);
			settlerHungerTextDel.gameObject.SetActive (false);
			settlerThirstTextDel.gameObject.SetActive (false);
			
			//Traits
			settlerStrengthImageDel.gameObject.SetActive (false);
			settlerIntelligenceImageDel.gameObject.SetActive (false);
			settlerAgilityImageDel.gameObject.SetActive (false);
			settlerPerceptionImageDel.gameObject.SetActive (false);
			settlerCharismaImageDel.gameObject.SetActive (false);
			
			settlerStrengthTextDel.gameObject.SetActive (false);
			settlerIntelligenceTextDel.gameObject.SetActive (false);
			settlerAgilityTextDel.gameObject.SetActive (false);
			settlerPerceptionTextDel.gameObject.SetActive (false);
			settlerCharismaTextDel.gameObject.SetActive (false);
			break;
		}



																						//=== General ===\\
		firstLastNameDel.text = agentLogic.settlerNameAndRole;							//Name
																						//Picture
																						//=== Attributes ===\\
		settlerHealthTextDel.text = agentLogic.health.ToString ();						//Health
		settlerStaminaTextDel.text = rndStam.ToString ();								//Stamina
		settlerHungerTextDel.text = agentLogic.hungerValue.ToString ();					//Hunger
		settlerThirstTextDel.text = rndThir.ToString ();								//Thirst
																						//=== Traits ===\\
		settlerStrengthTextDel.text = agentAttributes.agentStrength.ToString ();		//Strength
		settlerIntelligenceTextDel.text = rndInt.ToString ();							//Intelligence
		settlerAgilityTextDel.text = agentAttributes.agentAgility.ToString ();			//Agility
		settlerPerceptionTextDel.text = agentAttributes.agentPerception.ToString ();	//Perception
		settlerCharismaTextDel.text = rndChar.ToString ();								//Charisma
                                                                                        //=== Inventory ===\\
        inventoryFoodTextDel.text = "Food: " + agentLogic.foodStored;                   //Current amount of food stored

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
			hydrologistRoleButtonDel.interactable = false;
        }
        else
        {
            waterstationAvailable = true;
			hydrologistRoleButtonDel.interactable = true;
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

        if (!GameObject.FindWithTag ("TrainingArea")) {
            traininggroundAvailable = false;
            traineeRoleButtonDel.interactable = false;
        }
        else {
			traininggroundAvailable = true;
			traineeRoleButtonDel.interactable = true;
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