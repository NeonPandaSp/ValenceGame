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
	
	public Button farmerRoleButton, waterPurifierRoleButton, powerEngineerRoleButton, storageWorkerRoleButton, medicRoleButton, traineeRoleButton, worshipperRoleButton;
	Button farmerRoleButtonDel, waterPurifierRoleButtonDel, powerEngineerRoleButtonDel, storageWorkerRoleButtonDel, medicRoleButtonDel, traineeRoleButtonDel, worshipperRoleButtonDel;

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
		traininggroundAvailable = false;


		_gameController = GameObject.Find ("GameController").GetComponent<GameController> ();

        myCanvas = GameObject.Find ("Canvas").GetComponent <Canvas>();
        selectedIcon = GetComponentInChildren<SpriteRenderer>();

        //===============================\\
        //=== Settler Info Background ===\\
        //===============================\\
        SettlerInfoDelBg = (Image)Instantiate (SettlerInfoBg);
		SettlerInfoDelBg.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		SettlerInfoDelBg.rectTransform.sizeDelta = new Vector2 (821, 306);
		SettlerInfoDelBg.transform.Translate (410, 152.5f, 0);
		SettlerInfoDelBg.CrossFadeAlpha (1.0f, 0, false);

		//=======================\\
		//=== Settler Picture ===\\
		//=======================\\
		genericProfileIconDel = (Image)Instantiate (genericProfileIcon);
		genericProfileIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		genericProfileIconDel.rectTransform.sizeDelta = new Vector2 (200, 300);
		genericProfileIconDel.transform.Translate (105, 150, 0);
		genericProfileIconDel.CrossFadeAlpha (1.0f, 0, false);

		//====================\\
		//=== Settler Name ===\\
		//====================\\
		firstLastNameDel = (Text)Instantiate (firstLastName);
		firstLastNameDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		firstLastNameDel.rectTransform.sizeDelta = new Vector2 (600, 50);
		firstLastNameDel.transform.position = new Vector2 (500, 279);
		
		firstLastNameDel.fontSize = 28;
		firstLastNameDel.CrossFadeAlpha (1.0f, 0, false);

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
		attributesTitleDel.CrossFadeAlpha (1.0f, 0, false);
		
		//Health
		settlerHealthImageDel = (Image)Instantiate (settlerHealthImage);
		settlerHealthImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerHealthImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerHealthImageDel.transform.Translate (240, 177, 0);
		settlerHealthImageDel.CrossFadeAlpha (1.0f, 0, false);

			//Text
			settlerHealthTextDel = (Text)Instantiate (settlerHealthText);
			settlerHealthTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerHealthTextDel.rectTransform.sizeDelta = new Vector2 (300, 100);
			settlerHealthTextDel.transform.position = new Vector2 (settlerHealthImageDel.rectTransform.position.x + 45, settlerHealthImageDel.rectTransform.position.y);
			settlerHealthTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerHealthTextDel.fontSize = 18;
		
		//Stamina
		settlerStaminaImageDel = (Image)Instantiate (settlerStaminaImage);
		settlerStaminaImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerStaminaImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerStaminaImageDel.transform.Translate (settlerHealthImageDel.rectTransform.position.x, settlerHealthImageDel.rectTransform.position.y - 50, 0);
		settlerStaminaImageDel.CrossFadeAlpha (1.0f, 0, false);
		
			//Text
			settlerStaminaTextDel = (Text)Instantiate (settlerStaminaText);
			settlerStaminaTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerStaminaTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerStaminaTextDel.transform.position = new Vector2 (settlerStaminaImageDel.rectTransform.position.x + 45, settlerStaminaImageDel.rectTransform.position.y);
			settlerStaminaTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerStaminaTextDel.fontSize = 18;

		//Hunger
		settlerHungerImageDel = (Image)Instantiate (settlerHungerImage);
		settlerHungerImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerHungerImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerHungerImageDel.transform.Translate (settlerHealthImageDel.rectTransform.position.x, settlerStaminaImageDel.rectTransform.position.y - 50, 0);
		settlerHungerImageDel.CrossFadeAlpha (1.0f, 0, false);
		
			//Text
			settlerHungerTextDel = (Text)Instantiate (settlerHungerText);
			settlerHungerTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerHungerTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerHungerTextDel.transform.position = new Vector2 (settlerHungerImageDel.rectTransform.position.x + 45, settlerHungerImageDel.rectTransform.position.y);
			settlerHungerTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerHungerTextDel.fontSize = 18;

		//Thirst
		settlerThirstImageDel = (Image)Instantiate (settlerThirstImage);
		settlerThirstImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerThirstImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerThirstImageDel.transform.Translate (settlerHealthImageDel.rectTransform.position.x, settlerHungerImageDel.rectTransform.position.y - 50, 0);
		settlerThirstImageDel.CrossFadeAlpha (1.0f, 0, false);
		
			//Text
			settlerThirstTextDel = (Text)Instantiate (settlerThirstText);
			settlerThirstTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerThirstTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerThirstTextDel.transform.position = new Vector2 (settlerThirstImageDel.rectTransform.position.x + 45, settlerThirstImageDel.rectTransform.position.y);
			settlerThirstTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerThirstTextDel.fontSize = 18;

		//======================\\
		//=== Settler Traits ===\\
		//======================\\
		//Strength
		settlerStrengthImageDel = (Image)Instantiate (settlerStrengthImage);
		settlerStrengthImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerStrengthImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerStrengthImageDel.transform.Translate (settlerHealthImageDel.transform.position.x + 115, settlerHealthImageDel.rectTransform.position.y, 0);
		settlerStrengthImageDel.CrossFadeAlpha (1.0f, 0, false);
		
			//Text
			settlerStrengthTextDel = (Text)Instantiate (settlerStrengthText);
			settlerStrengthTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerStrengthTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerStrengthTextDel.transform.position = new Vector2 (settlerStrengthImageDel.rectTransform.position.x + 45, settlerStrengthImageDel.rectTransform.position.y);
			settlerStrengthTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerStrengthTextDel.fontSize = 18;

		//Intelligence
		settlerIntelligenceImageDel = (Image)Instantiate (settlerIntelligenceImage);
		settlerIntelligenceImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerIntelligenceImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerIntelligenceImageDel.transform.Translate (settlerStrengthImageDel.rectTransform.position.x, settlerStrengthImageDel.rectTransform.position.y - 37.5f, 0);
		settlerIntelligenceImageDel.CrossFadeAlpha (1.0f, 0, false);
		
			//Text
			settlerIntelligenceTextDel = (Text)Instantiate (settlerIntelligenceText);
			settlerIntelligenceTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerIntelligenceTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerIntelligenceTextDel.transform.position = new Vector2 (settlerIntelligenceImageDel.rectTransform.position.x + 45, settlerIntelligenceImageDel.rectTransform.position.y);
			settlerIntelligenceTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerIntelligenceTextDel.fontSize = 18;

		//Agility
		settlerAgilityImageDel = (Image)Instantiate (settlerAgilityImage);
		settlerAgilityImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerAgilityImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerAgilityImageDel.transform.Translate (settlerStrengthImageDel.rectTransform.position.x, settlerIntelligenceImageDel.rectTransform.position.y - 37.5f, 0);
		settlerAgilityImageDel.CrossFadeAlpha (1.0f, 0, false);
		
			//Text
			settlerAgilityTextDel = (Text)Instantiate (settlerAgilityText);
			settlerAgilityTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerAgilityTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerAgilityTextDel.transform.position = new Vector2 (settlerAgilityImageDel.rectTransform.position.x + 45, settlerAgilityImageDel.rectTransform.position.y);
			settlerAgilityTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerAgilityTextDel.fontSize = 18;

		//Perception
		settlerPerceptionImageDel = (Image)Instantiate (settlerPerceptionImage);
		settlerPerceptionImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerPerceptionImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerPerceptionImageDel.transform.Translate (settlerStrengthImageDel.rectTransform.position.x, settlerAgilityImageDel.rectTransform.position.y - 37.5f, 0);
		settlerPerceptionImageDel.CrossFadeAlpha (1.0f, 0, false);
		
			//Text
			settlerPerceptionTextDel = (Text)Instantiate (settlerPerceptionText);
			settlerPerceptionTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerPerceptionTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerPerceptionTextDel.transform.position = new Vector2 (settlerPerceptionImageDel.rectTransform.position.x + 45, settlerPerceptionImageDel.rectTransform.position.y);
			settlerPerceptionTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerPerceptionTextDel.fontSize = 18;

		//Charisma
		settlerCharismaImageDel = (Image)Instantiate (settlerCharismaImage);
		settlerCharismaImageDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		settlerCharismaImageDel.rectTransform.sizeDelta = new Vector2 (30, 30);
		settlerCharismaImageDel.transform.Translate (settlerStrengthImageDel.rectTransform.position.x, settlerPerceptionImageDel.rectTransform.position.y - 37.5f, 0);
		settlerCharismaImageDel.CrossFadeAlpha (1.0f, 0, false);
		
			//Text
			settlerCharismaTextDel = (Text)Instantiate (settlerCharismaText);
			settlerCharismaTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			settlerCharismaTextDel.rectTransform.sizeDelta = new Vector2 (150, 100);
			settlerCharismaTextDel.transform.position = new Vector2 (settlerCharismaImageDel.rectTransform.position.x + 45, settlerCharismaImageDel.rectTransform.position.y);
			settlerCharismaTextDel.CrossFadeAlpha (1.0f, 0, false);
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
		inventoryTitleDel.CrossFadeAlpha (1.0f, 0, false);

		//Inventory Food
		inventoryFoodTextDel = (Text)Instantiate (inventoryFoodText);
		inventoryFoodTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		inventoryFoodTextDel.text = "Food: 120";
		inventoryFoodTextDel.transform.position = new Vector2 (settlerHealthTextDel.rectTransform.position.x + 220, settlerHealthTextDel.rectTransform.position.y);
		inventoryFoodTextDel.rectTransform.sizeDelta = new Vector2 (150, 50);
		inventoryFoodTextDel.CrossFadeAlpha (1.0f, 0, false);
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
		rolesTitleDel.CrossFadeAlpha (1.0f, 0, false);

		//Farmer Role Button
		farmerRoleButtonDel = (Button)Instantiate (farmerRoleButton);
		farmerRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		farmerRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (160, 35);
		farmerRoleButtonDel.transform.Translate (settlerHealthImageDel.rectTransform.position.x + 475, settlerHealthImageDel.rectTransform.position.y, 0);
		farmerRoleButtonDel.GetComponentInChildren<Text> ().text = "Farmer";
		farmerRoleButtonDel.GetComponentInChildren<Text> ().font = font_hero;
		farmerRoleButtonDel.onClick.AddListener (() => farmerRoleClicked());
		farmerRoleButtonDel.image.CrossFadeAlpha (1.0f, 0, false);
		
		//Hydrologist Role Button
		waterPurifierRoleButtonDel = (Button)Instantiate (waterPurifierRoleButton);
		waterPurifierRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		waterPurifierRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (160, 35);
		waterPurifierRoleButtonDel.transform.Translate (farmerRoleButtonDel.image.rectTransform.position.x, farmerRoleButtonDel.image.rectTransform.position.y - 37.5f, 0);
		waterPurifierRoleButtonDel.GetComponentInChildren<Text> ().text = "Hydrologist";
		waterPurifierRoleButtonDel.GetComponentInChildren<Text> ().font = font_hero;
		waterPurifierRoleButtonDel.onClick.AddListener (() => waterPurifierRoleClicked());
		waterPurifierRoleButtonDel.image.CrossFadeAlpha (1.0f, 0, false);

		//Power Engineer Role Button
		powerEngineerRoleButtonDel = (Button)Instantiate (powerEngineerRoleButton);
		powerEngineerRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		powerEngineerRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (160, 35);
		powerEngineerRoleButtonDel.transform.Translate (farmerRoleButtonDel.image.rectTransform.position.x, waterPurifierRoleButtonDel.image.rectTransform.position.y - 37.5f, 0);
		powerEngineerRoleButtonDel.GetComponentInChildren<Text> ().text = "Power Engineer";
		powerEngineerRoleButtonDel.GetComponentInChildren<Text> ().font = font_hero;
		powerEngineerRoleButtonDel.onClick.AddListener (() => powerEngineerRoleClicked());
		powerEngineerRoleButtonDel.image.CrossFadeAlpha (1.0f, 0, false);

		//Medic Role Button
		medicRoleButtonDel = (Button)Instantiate (medicRoleButton);
		medicRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		medicRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (160, 35);
		medicRoleButtonDel.transform.Translate (farmerRoleButtonDel.image.rectTransform.position.x, powerEngineerRoleButtonDel.image.rectTransform.position.y - 37.5f, 0);
		medicRoleButtonDel.GetComponentInChildren<Text> ().text = "Medic";
		medicRoleButtonDel.GetComponentInChildren<Text> ().font = font_hero;
		medicRoleButtonDel.onClick.AddListener (() => medicRoleClicked());
		medicRoleButtonDel.image.CrossFadeAlpha (1.0f, 0, false);

		//Trainee Role Button
		traineeRoleButtonDel = (Button)Instantiate (traineeRoleButton);
		traineeRoleButtonDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		traineeRoleButtonDel.image.rectTransform.sizeDelta = new Vector2 (160, 35);
		traineeRoleButtonDel.transform.Translate (farmerRoleButtonDel.image.rectTransform.position.x, medicRoleButtonDel.image.rectTransform.position.y - 37.5f, 0);
		traineeRoleButtonDel.GetComponentInChildren<Text> ().text = "Trainee";
		traineeRoleButtonDel.GetComponentInChildren<Text> ().font = font_hero;
		traineeRoleButtonDel.onClick.AddListener (() => traineeRoleClicked());
		traineeRoleButtonDel.image.CrossFadeAlpha (1.0f, 0, false);

		//Close Button
		exBtnDel = (Button)Instantiate (exBtn);
		exBtnDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		exBtnDel.image.rectTransform.sizeDelta = new Vector2 (20, 20);
		exBtnDel.transform.Translate (795, 286, 0);
		exBtnDel.GetComponentInChildren<Text> ().text = "";
		exBtnDel.image.CrossFadeAlpha (1.0f, 0, false);
		exBtnDel.onClick.AddListener (() => exBtnClicked());

		agentAttributes = GetComponent <AgentAttributes> ();
    }

	//=================\\
	//=== Functions ===\\
	//=================\\
    void OnMouseUp() {
        // When you click, change the variables value
		showMenu = !showMenu;

		//Randomizing attributes when settler panel opens
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

		if (showMenu) {
			showMenu = !showMenu;
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

	void traineeRoleClicked () {
		//TRAINEE
	}

	//When the close button is clicked
	void exBtnClicked () {
		showMenu = !showMenu;
	}

	//==================\\
	//===== Update =====\\
	//==================\\

    void Update() {
		switch (showMenu) {
		case true:
			selectedIcon.enabled = true;
			firstLastNameDel.gameObject.SetActive (true);

			inventoryTitleDel.CrossFadeAlpha (1.0f, 0, false);
			rolesTitleDel.CrossFadeAlpha (1.0f, 0, false);
			attributesTitleDel.CrossFadeAlpha (1.0f, 0, false);
			SettlerInfoDelBg.CrossFadeAlpha (1.0f, 0, false);
			
			//Buttons
			farmerRoleButtonDel.image.CrossFadeAlpha (1.0f, 0, false);
			waterPurifierRoleButtonDel.image.CrossFadeAlpha (1.0f, 0, false);
			powerEngineerRoleButtonDel.image.CrossFadeAlpha (1.0f, 0, false);
			medicRoleButtonDel.image.CrossFadeAlpha (1.0f, 0, false);
			traineeRoleButtonDel.image.CrossFadeAlpha (1.0f, 0, false);
			exBtnDel.image.CrossFadeAlpha (1.0f, 0, false);
			
			genericProfileIconDel.CrossFadeAlpha (1.0f, 0, false);
			firstLastNameDel.CrossFadeAlpha (1.0f, 0, false);
			inventoryFoodTextDel.CrossFadeAlpha (1.0f, 0, false);
			
			//Attributes
			settlerHealthImageDel.CrossFadeAlpha (1.0f, 0, false);
			settlerStaminaImageDel.CrossFadeAlpha (1.0f, 0, false);
			settlerHungerImageDel.CrossFadeAlpha (1.0f, 0, false);
			settlerThirstImageDel.CrossFadeAlpha (1.0f, 0, false);
			
			settlerHealthTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerStaminaTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerHungerTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerThirstTextDel.CrossFadeAlpha (1.0f, 0, false);

			//Traits
			settlerStrengthImageDel.CrossFadeAlpha (1.0f, 0, false);
			settlerIntelligenceImageDel.CrossFadeAlpha (1.0f, 0, false);
			settlerAgilityImageDel.CrossFadeAlpha (1.0f, 0, false);
			settlerPerceptionImageDel.CrossFadeAlpha (1.0f, 0, false);
			settlerCharismaImageDel.CrossFadeAlpha (1.0f, 0, false);
			
			settlerStrengthTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerIntelligenceTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerAgilityTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerPerceptionTextDel.CrossFadeAlpha (1.0f, 0, false);
			settlerCharismaTextDel.CrossFadeAlpha (1.0f, 0, false);
			break;
		case false:
			selectedIcon.enabled = false;
			firstLastNameDel.gameObject.SetActive (false);

			inventoryTitleDel.CrossFadeAlpha (0.0f, 0, false);
			rolesTitleDel.CrossFadeAlpha (0.0f, 0, false);
			attributesTitleDel.CrossFadeAlpha (0.0f, 0, false);
			SettlerInfoDelBg.CrossFadeAlpha (0.0f, 0, false);
			
			//Buttons
			farmerRoleButtonDel.image.CrossFadeAlpha (0.0f, 0, false);
			waterPurifierRoleButtonDel.image.CrossFadeAlpha (0.0f, 0, false);
			powerEngineerRoleButtonDel.image.CrossFadeAlpha (0.0f, 0, false);
			medicRoleButtonDel.image.CrossFadeAlpha (0.0f, 0, false);
			traineeRoleButtonDel.image.CrossFadeAlpha (0.0f, 0, false);
			exBtnDel.image.CrossFadeAlpha (0.0f, 0, false);
			
			genericProfileIconDel.CrossFadeAlpha (0.0f, 0, false);
			firstLastNameDel.CrossFadeAlpha (0.0f, 0, false);
			inventoryFoodTextDel.CrossFadeAlpha (0.0f, 0, false);
			
			//Attributes
			settlerHealthImageDel.CrossFadeAlpha (0.0f, 0, false);
			settlerStaminaImageDel.CrossFadeAlpha (0.0f, 0, false);
			settlerHungerImageDel.CrossFadeAlpha (0.0f, 0, false);
			settlerThirstImageDel.CrossFadeAlpha (0.0f, 0, false);
			
			settlerHealthTextDel.CrossFadeAlpha (0.0f, 0, false);
			settlerStaminaTextDel.CrossFadeAlpha (0.0f, 0, false);
			settlerHungerTextDel.CrossFadeAlpha (0.0f, 0, false);
			settlerThirstTextDel.CrossFadeAlpha (0.0f, 0, false);
			
			//Traits
			settlerStrengthImageDel.CrossFadeAlpha (0.0f, 0, false);
			settlerIntelligenceImageDel.CrossFadeAlpha (0.0f, 0, false);
			settlerAgilityImageDel.CrossFadeAlpha (0.0f, 0, false);
			settlerPerceptionImageDel.CrossFadeAlpha (0.0f, 0, false);
			settlerCharismaImageDel.CrossFadeAlpha (0.0f, 0, false);
			
			settlerStrengthTextDel.CrossFadeAlpha (0.0f, 0, false);
			settlerIntelligenceTextDel.CrossFadeAlpha (0.0f, 0, false);
			settlerAgilityTextDel.CrossFadeAlpha (0.0f, 0, false);
			settlerPerceptionTextDel.CrossFadeAlpha (0.0f, 0, false);
			settlerCharismaTextDel.CrossFadeAlpha (0.0f, 0, false);
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