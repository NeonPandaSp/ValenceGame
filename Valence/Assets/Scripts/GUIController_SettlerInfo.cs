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
    bool farmAvailable, hospitalAvailable, waterstationAvailable, powerstationAvailable;

    //Return true if error message should be shown
    bool showError;

	//\\
	public Canvas myCanvas;
	
	public Image SettlerInfoBg;
	Image SettlerInfoDelBg;
	
	// === Settler Attributes === \\
	public Text attributesTitle, settlerHealthText, settlerStaminaText, settlerMoraleText, settlerHungerText, settlerThirstText;
	Text attributesTitleDel, settlerHealthTextDel, settlerStaminaTextDel, settlerMoraleTextDel, settlerHungerTextDel, settlerThirstTextDel;
	
	public Text settlerStrengthText, settlerIntelligenceText, settlerAgilityText, settlerPerceptionText, settlerCharismaText;
	Text settlerStrengthTextDel, settlerIntelligenceTextDel, settlerAgilityTextDel, settlerPerceptionTextDel, settlerCharismaTextDel;
	
	// === Settler Inventory === \\
	public Text inventoryTitle;
	Text inventoryTitleDel;
	
	// === Settler Assign Role === \\
	public Text rolesTitle;
	Text rolesTitleDel;
	
	public Button farmerRoleButton, waterPurifierRoleButton, powerEngineerRoleButton, storageWorkerRoleButton, medicRoleButton, teacherRoleButton, worshipperRoleButton, bartenderRoleButton;
	Button farmerRoleButtonDel, waterPurifierRoleButtonDel, powerEngineerRoleButtonDel, storageWorkerRoleButtonDel, medicRoleButtonDel, teacherRoleButtonDel, worshipperRoleButtonDel, bartenderRoleButtonDel;

	//=================\\
	//===== Start =====\\
	//=================\\

    void Start() {

        showError = false;
        hospitalAvailable = false;
        farmAvailable = false;
        waterstationAvailable = false;
        powerstationAvailable = false;

		myCanvas = GameObject.Find ("Canvas").GetComponent <Canvas>();

		// === Settler Info Background === \\
		SettlerInfoDelBg = (Image)Instantiate (SettlerInfoBg);
		SettlerInfoDelBg.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		SettlerInfoDelBg.rectTransform.sizeDelta = new Vector2 (820, 305);
		SettlerInfoDelBg.transform.Translate (410, 152.5f, 0);
		SettlerInfoDelBg.gameObject.SetActive (false);
		
		// === Settler Attributes === \\
		// Attributes Title
		attributesTitleDel = (Text)Instantiate (attributesTitle);
		attributesTitleDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		attributesTitleDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		attributesTitleDel.transform.Translate (960, Screen.height - 50, 0);
		attributesTitleDel.text = "Attributes";
			
		attributesTitleDel.fontSize = 28;
		attributesTitleDel.transform.position = new Vector2 (365, 222);
		attributesTitleDel.rectTransform.sizeDelta = new Vector2 (200, 50);
		attributesTitleDel.gameObject.SetActive (false);
		
		//		//Settler Health
		//		settlerHealthTextDel = (Text)Instantiate (settlerHealthText);
		//		settlerHealthTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//		
		//		settlerHealthTextDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		//		settlerHealthTextDel.transform.Translate (960, Screen.height - 50, 0);
		//
		//		//Settler Stamina
		//		settlerStaminaTextDel = (Text)Instantiate (settlerStaminaText);
		//		settlerStaminaTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//		
		//		settlerStaminaTextDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		//		settlerStaminaTextDel.transform.Translate (960, Screen.height - 50, 0);
		//
		//		//Settler Hunger
		//		settlerHungerTextDel = (Text)Instantiate (settlerHungerText);
		//		settlerHungerTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//		
		//		settlerHungerTextDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		//		settlerHungerTextDel.transform.Translate (960, Screen.height - 50, 0);
		//
		//		//Settler Morale
		//		settlerMoraleTextDel = (Text)Instantiate (settlerMoraleText);
		//		settlerMoraleTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//		
		//		settlerMoraleTextDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		//		settlerMoraleTextDel.transform.Translate (960, Screen.height - 50, 0);
		//
		//		//Settler Strength
		//		settlerStrengthTextDel = (Text)Instantiate (settlerStrengthText);
		//		settlerStrengthTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//		
		//		settlerStrengthTextDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		//		settlerStrengthTextDel.transform.Translate (960, Screen.height - 50, 0);
		//
		//		//Settler Intelligence
		//		settlerIntelligenceTextDel = (Text)Instantiate (settlerIntelligenceText);
		//		settlerIntelligenceTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//		
		//		settlerIntelligenceTextDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		//		settlerIntelligenceTextDel.transform.Translate (960, Screen.height - 50, 0);
		//
		//		//Settler Agility
		//		settlerAgilityTextDel = (Text)Instantiate (settlerAgilityText);
		//		settlerAgilityTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//		
		//		settlerAgilityTextDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		//		settlerAgilityTextDel.transform.Translate (960, Screen.height - 50, 0);
		//
		//		//Settler Perception
		//		settlerPerceptionTextDel = (Text)Instantiate (settlerPerceptionText);
		//		settlerPerceptionTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//		
		//		settlerPerceptionTextDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		//		settlerPerceptionTextDel.transform.Translate (960, Screen.height - 50, 0);
		//
		//		//Settler Charisma
		//		settlerCharismaTextDel = (Text)Instantiate (settlerCharismaText);
		//		settlerCharismaTextDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//		
		//		settlerCharismaTextDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		//		settlerCharismaTextDel.transform.Translate (960, Screen.height - 50, 0);
		//
		// === Settler Inventory === \\
		// Inventory Title
		inventoryTitleDel = (Text)Instantiate (inventoryTitle);
		inventoryTitleDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		inventoryTitleDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		inventoryTitleDel.transform.Translate (960, Screen.height - 50, 0);
		inventoryTitleDel.text = "Inventory";
		
		inventoryTitleDel.fontSize = 28;
		inventoryTitleDel.transform.position = new Vector2 (557, 222);
		inventoryTitleDel.rectTransform.sizeDelta = new Vector2 (200, 50);
		inventoryTitleDel.gameObject.SetActive (false);
		
		// === Settler Assign Role === \\
		//Roles Title
		rolesTitleDel = (Text)Instantiate (rolesTitle);
		rolesTitleDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		rolesTitleDel.rectTransform.sizeDelta = new Vector2 (1920, 100);
		rolesTitleDel.transform.Translate (960, Screen.height - 50, 0);
		rolesTitleDel.text = "Role";
		
		rolesTitleDel.fontSize = 28;
		rolesTitleDel.transform.position = new Vector2 (775, 222);
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
		}
		else {
			showMenu = true;
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
		}
    }

	void farmerRoleClicked ()
	{
		if ((agentLogic.jobState != AgentLogic_07.jobSubState.Farmer) && farmAvailable) {
			//Obtain all farm waypoints that the agent should move between when working
			agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag ("FarmWaypoint"));
			
			//Set the agent to working
			agentLogic.aState = AgentLogic_07.agentState.Working;
			
			//Define the working state as farming
			agentLogic.jobState = AgentLogic_07.jobSubState.Farmer;
		}
	}

	void waterPurifierRoleClicked ()
	{
		if ((agentLogic.jobState != AgentLogic_07.jobSubState.WaterPurifier) && waterstationAvailable) {
			agentLogic.workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("WaterWaypoint"));
			
			//Set the agent to working
			agentLogic.aState = AgentLogic_07.agentState.Working;
			
			//Define the working state as farming
			agentLogic.jobState = AgentLogic_07.jobSubState.WaterPurifier;
		}
	}

	void powerEngineerRoleClicked ()
	{
		if ((agentLogic.jobState != AgentLogic_07.jobSubState.PowerWorker) && powerstationAvailable) {
			//Obtain all farm waypoints that the agent should move between when working
			agentLogic.workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("PowerWaypoint"));
			
			//Set the agent to working
			agentLogic.aState = AgentLogic_07.agentState.Working;
			
			//Define the working state as farming
			agentLogic.jobState = AgentLogic_07.jobSubState.PowerWorker;
		}
	}

//	void storageWorkerRoleClicked ()
//	{
//		//STORAGE WORKER
//	}

	void medicRoleClicked ()
	{
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

//	void teacherRoleClicked ()
//	{
//		//TEACHER
//	}
//
//	void worshipperRoleClicked ()
//	{
//		//WORSHIPPER
//	}
//
//	void bartenderRoleClicked ()
//	{
//		//BARTENDER
//	}

	//==================\\
	//===== Update =====\\
	//==================\\

    void Update() {
        //Check to see if there are any gameobjects with the appropriate building tag
		if (GameObject.FindWithTag ("Farm"))
		{
			farmAvailable = true;
			farmerRoleButtonDel.interactable = true;
		}
		else {
			farmAvailable = false;
			farmerRoleButtonDel.interactable = false;
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

//		if (!GameObject.FindWithTag ("Storage"))
//		{
//			storageAvailable = false;
//			storageWorkerRoleButtonDel.interactable = false;
//		}
//		else {
//			storageAvailable = true;
//			storageWorkerRoleButtonDel.interactable = true;
//		}
//
//		if (!GameObject.FindWithTag ("School"))
//		{
//			schoolAvailable = false;
//			teacherRoleButtonDel.interactable = false;
//		}
//		else {
//			schoolAvailable = true;
//			teacherRoleButtonDel.interactable = true;
//		}

//		if (!GameObject.FindWithTag ("Shrine"))
//		{
//			shrineAvailable = false;
//			worshipperRoleButtonDel.interactable = false;
//		}
//		else {
//			shrineAvailable = true;
//			worshipperRoleButtonDel.interactable = true;
//		}

//		if (!GameObject.FindWithTag ("Tavern"))
//		{
//			tavernAvailable = false;
//			bartenderRoleButtonDel.interactable = false;
//		}
//		else {
//			tavernAvailable = true;
//			bartenderRoleButtonDel.interactable = true;
//		}
	}

    void OnGUI() {
        //Here it becomes a little complex, itterate through all buildings and see what's available. Then create a button to assign an agent to that building, when pressed find all waypoints with the correct building tag and move there.
        switch (showMenu) {
            case true:
                //Check if there is a farm
                switch (farmAvailable){
                    case true:
                        if (GUI.Button(new Rect(10, 10, 100, 20), "Assign Farmer") && (agentLogic.jobState != AgentLogic_07.jobSubState.Farmer))
                        {
                           //Obtain all farm waypoints that the agent should move between when working
                            agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag ("FarmWaypoint"));

                            //Set the agent to working
                            agentLogic.aState = AgentLogic_07.agentState.Working;

                            //Define the working state as farming
                            agentLogic.jobState = AgentLogic_07.jobSubState.Farmer;
                        }
                        break;

                    case false:
                        StartCoroutine (MissingBuildingError(3.0f, "Farm"));
                        break;

                    default:
                        print("Default reached in GUIToggle_07.cs Line 98");
                        break;
                }

                switch (waterstationAvailable)
                {
                    case true:
                        if (GUI.Button(new Rect (10, 30, 150, 20), "Assign Water Purifier") && (agentLogic.jobState != AgentLogic_07.jobSubState.WaterPurifier))
                        {
                            //Obtain all farm waypoints that the agent should move between when working
                            agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag ("WaterWaypoint"));

                            //Set the agent to working
                            agentLogic.aState = AgentLogic_07.agentState.Working;

                            //Define the working state as farming
                            agentLogic.jobState = AgentLogic_07.jobSubState.WaterPurifier;
                        }
                        break;

                    case false:
                        StartCoroutine(MissingBuildingError (3.0f, "Water Station"));
                        break;

                    default:
                        print("Default reached in GUIToggle_07.cs Line 98");
                        break;
                }

                switch (powerstationAvailable)
                {
                    case true:
                        if (GUI.Button (new Rect (10, 50, 150, 20), "Assign Power Engineer") && (agentLogic.jobState != AgentLogic_07.jobSubState.PowerWorker))
                        {
                            //Obtain all farm waypoints that the agent should move between when working
                            agentLogic.workWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("PowerWaypoint"));

                            //Set the agent to working
                            agentLogic.aState = AgentLogic_07.agentState.Working;

                            //Define the working state as farming
                            agentLogic.jobState = AgentLogic_07.jobSubState.PowerWorker;
                        }
                        break;

                    case false:
                        StartCoroutine(MissingBuildingError (3.0f, "Power Station"));
                        break;
                    default:
                        print("Default reached in GUIToggle_07.cs Line 98");
                        break;
                }

                //Check if there is a hospital
                //if (GameObject.FindWithTag("Hospital")) {
                switch (hospitalAvailable)
                {
                    case true:
                        if (GUI.Button (new Rect (10, 70, 100, 20), "Assign Medic") && (agentLogic.jobState != AgentLogic_07.jobSubState.Medic)) {
                    
                        //Obtain all farm waypoints that the agent should move between when working
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
                        break;
                    case false:

                        //Display warning of missing building with tag hospital
                        StartCoroutine(MissingBuildingError (3.0f, "Hospital"));
                        break;
                    default:
                        print("Default reached in GUIToggle_07.cs Line 150");
                        break;
                }
                break;

            case false:
                //Reset warning messages when user closes the GUI
                showError = true;
                break;
        }
    }

    IEnumerator MissingBuildingError (float wait, string building) {
        if (showError)
        {
            GUI.Box (new Rect(Screen.width / 2 - 150, Screen.height / 2 - 50, 250, 25), "No Building with tag " + building + " placed...");
            yield return new WaitForSeconds (wait);
            showError = false;
        }
    }
}