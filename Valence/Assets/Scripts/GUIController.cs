using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using System.Collections.Generic;

	public class GUIController : MonoBehaviour {

	//HUD Variables
	//GameObject globalAttributes;
	public Text scrapText, populationText, foodText, waterText, powerText, timeText;
	Text scrapDelText, populationDelText, foodDelText, waterDelText, powerDelText, timeDelText;
	public Image scrapIcon, populationIcon, foodIcon, waterIcon, powerIcon;
	Image scrapIconDel, populationIconDel, foodIconDel, waterIconDel, powerIconDel;

    AgentSpawner aSpawner;

	public GameController globalAttributes;
	public string setBuildingTypeName;

	int scrap, population;
	float food, water, power;

//	//Time variables
//	int hour;
//	int minute;
//	int second;
//	String hourText;
//	String minText;
//	String secText;
	
	public Canvas myCanvas;

	public Image HUDBg;
	Image HUDDelBg;

	// === BUTTONS === \\
	//public Button[] buildBtnArray = new Button[1];
	public Button buildBtn;
	Button buildBtnDel;

	//public Button destroyBtn;
	//Button destroyBtnDel;

	public Button shelterBtn, farmBtn, waterStationBtn, powerStationBtn, storageBtn, hospitalBtn, trainingGroundBtn;
	Button shelterDelBtn, farmDelBtn, waterStationDelBtn, powerStationDelBtn, storageDelBtn, hospitalDelBtn, trainingGroundDelBtn;

	public Button switchModeBtn;
	Button switchModeDelBtn;

	//test button
	public Button mFG;

	bool buildClicked;
	bool structureBtnClicked;

	//=================\\
	//===== Start =====\\
	//=================\\

	// Use this for initialization
	void Start () {
		globalAttributes = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
        aSpawner = GameObject.Find("ASpawner").GetComponent<AgentSpawner>();
		// === HUD Background ===\\
		HUDDelBg = (Image)Instantiate (HUDBg);
		HUDDelBg.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		HUDDelBg.rectTransform.sizeDelta = new Vector2 (770, 100);
		HUDDelBg.transform.Translate (385, Screen.height - 50, 0);
//		HUDDelBg.CrossFadeAlpha (0.5f, 0, false);
		
		//===========================\\
		// === GLOBAL ATTRIBUTES === \\
		//===========================\\
		//Scrap
		scrapIconDel = (Image)Instantiate (scrapIcon);
		scrapIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		scrapIconDel.rectTransform.sizeDelta = new Vector2 (50, 50);
		scrapIconDel.transform.Translate (50, Screen.height - 50, 0);

			//Text
			scrapDelText = (Text)Instantiate (scrapText);
			scrapDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			scrapDelText.text = "";
			scrapDelText.fontSize = 20;
			scrapDelText.transform.position = new Vector2 (125, Screen.height - 50);
			scrapDelText.rectTransform.sizeDelta = new Vector2 (200, 50);

		//Population
		populationIconDel = (Image)Instantiate (populationIcon);
		populationIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		populationIconDel.rectTransform.sizeDelta = new Vector2 (50, 50);
		populationIconDel.transform.Translate (scrapIconDel.transform.position.x + 150, Screen.height - 50, 0);

			//Text
			populationDelText = (Text)Instantiate (populationText);
			populationDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			populationDelText.text = "";
			populationDelText.fontSize = 20;
			populationDelText.transform.position = new Vector2 (scrapDelText.transform.position.x + 150, scrapDelText.transform.position.y);
		
		//Food
		foodIconDel = (Image)Instantiate (foodIcon);
		foodIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		foodIconDel.rectTransform.sizeDelta = new Vector2 (50, 50);
		foodIconDel.transform.Translate (populationIconDel.transform.position.x + 150, Screen.height - 50, 0);

			//Text
			foodDelText = (Text)Instantiate (foodText);
			foodDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			foodDelText.text = "";
			foodDelText.fontSize = 20;
			foodDelText.transform.position = new Vector2 (populationDelText.transform.position.x + 150, scrapDelText.transform.position.y);
		
		//Water
		waterIconDel = (Image)Instantiate (waterIcon);
		waterIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		waterIconDel.rectTransform.sizeDelta = new Vector2 (50, 50);
		waterIconDel.transform.Translate (foodIconDel.transform.position.x + 150, Screen.height - 50, 0);

			//Text
			waterDelText = (Text)Instantiate (waterText);
			waterDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			waterDelText.text = "";
			waterDelText.fontSize = 20;
			waterDelText.transform.position = new Vector2 (foodDelText.transform.position.x + 150, scrapDelText.transform.position.y);
		
		//Power
		powerIconDel = (Image)Instantiate (powerIcon);
		powerIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		powerIconDel.rectTransform.sizeDelta = new Vector2 (50, 50);
		powerIconDel.transform.Translate (waterIconDel.transform.position.x + 150, Screen.height - 50, 0);

			//Text
			powerDelText = (Text)Instantiate (powerText);
			powerDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			powerDelText.text = "";
			powerDelText.fontSize = 20;
			powerDelText.transform.position = new Vector2 (waterDelText.transform.position.x + 150, scrapDelText.transform.position.y);
		
		//		//Time
		//		timeDelText = (Text)Instantiate (timeText);
		//		timeDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//		
		//		timeDelText.text = "";
		//		timeDelText.fontSize = 20;
		//		timeDelText.transform.position = new Vector2 (scrapDelText.transform.position.x + 1770, scrapDelText.transform.position.y);
		//		timeDelText.color = new Color (0.0509803921568627f, 0.0509803921568627f, 0.0509803921568627f);
		
		//		//Time
		//		hour = 0;
		//		minute = 0;
		//		second = 0;

		//===============\\
		//=== BUTTONS ===\\
		//===============\\

		// === Building Buttons === \\
		//OLD WAY FOR USING AN ARRAY TO MAKE THE BUILD AND DESTROY BUTTON. MAY BE USED LATER FOR ALL STRUCTURE BUTTONS.
		//		for (int i = 0; i < buildBtnArray.Length; i++) {
		//			Button tempButton = (Button)Instantiate (buildBtnArray [i], Vector3.zero, Quaternion.identity);
		//			tempButton.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		//			buildBtnArray [i] = tempButton;
		//		}

		//Build Button
		buildBtnDel = (Button)Instantiate (buildBtn);
		buildBtnDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		buildBtnDel.GetComponentInChildren<Text> ().text = "";
		buildBtnDel.transform.position = new Vector2 (40, Screen.height - 300);
		buildBtnDel.image.rectTransform.sizeDelta = new Vector2 (75, 75);
		buildBtnDel.onClick.AddListener (() => buildBtnClicked ());
		buildBtnDel.gameObject.SetActive (true);

		buildClicked = false;
		
		//Destroy Button //HIDDEN FOR ALPHA PRESENTATION
//		destroyBtnDel = (Button)Instantiate (destroyBtn);
//		destroyBtnDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
//		
//		destroyBtnDel.GetComponentInChildren<Text> ().text = "";
//		destroyBtnDel.transform.position = new Vector2 (40, Screen.height - 155);
//		destroyBtnDel.image.rectTransform.sizeDelta = new Vector2 (75, 75);
//		destroyBtnDel.onClick.AddListener (() => buildBtnClicked ());

		// === STRUCTURE BUTTONS === \\
		//Shelter Button				
		shelterDelBtn = (Button)Instantiate (shelterBtn);
		shelterDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		shelterDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		shelterDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 72.5f, buildBtnDel.transform.position.y + 97.5f);
		shelterDelBtn.GetComponentInChildren<Text> ().text = "Shelter";
		shelterDelBtn.onClick.AddListener (() => switchStructure ("shelter"));
		shelterDelBtn.gameObject.SetActive (false);
		
		//Farm Button
		farmDelBtn = (Button)Instantiate (farmBtn);
		farmDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		farmDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		farmDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 137.5f, buildBtnDel.transform.position.y + 97.5f);
		farmDelBtn.GetComponentInChildren<Text> ().text = "Farm";
		farmDelBtn.onClick.AddListener (() => switchStructure ("farm"));
		farmDelBtn.gameObject.SetActive (false);
		
		//Water Station Button
		waterStationDelBtn = (Button)Instantiate (waterStationBtn);
		waterStationDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		waterStationDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		waterStationDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 72.5f, buildBtnDel.transform.position.y + 32.5f);
		waterStationDelBtn.GetComponentInChildren<Text> ().text = "Water Station";
		waterStationDelBtn.onClick.AddListener (() => switchStructure ("water"));
		waterStationDelBtn.gameObject.SetActive (false);
		
		//Power Station Button
		powerStationDelBtn = (Button)Instantiate (powerStationBtn);
		powerStationDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		powerStationDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		powerStationDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 137.5f, buildBtnDel.transform.position.y + 32.5f);
		powerStationDelBtn.GetComponentInChildren<Text> ().text = "Power Station";
		powerStationDelBtn.onClick.AddListener (() => switchStructure ("power"));
		powerStationDelBtn.gameObject.SetActive (false);
		
		//Storage Button
		storageDelBtn = (Button)Instantiate (storageBtn);
		storageDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		storageDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		storageDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 72.5f, buildBtnDel.transform.position.y - 32.5f);
		storageDelBtn.GetComponentInChildren<Text> ().text = "Storage";
		storageDelBtn.onClick.AddListener (() => switchStructure ("storage"));
		storageDelBtn.gameObject.SetActive (false);

		//Hospital Button
		hospitalDelBtn = (Button)Instantiate (hospitalBtn);
		hospitalDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		hospitalDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		hospitalDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 72.5f, buildBtnDel.transform.position.y - 97.5f);
		hospitalDelBtn.GetComponentInChildren<Text> ().text = "Hospital";
		hospitalDelBtn.onClick.AddListener (() => switchStructure ("hospital"));
		hospitalDelBtn.gameObject.SetActive (false);
		
		//Training Ground Button
		trainingGroundDelBtn = (Button)Instantiate (trainingGroundBtn);
		trainingGroundDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		trainingGroundDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		trainingGroundDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 137.5f, buildBtnDel.transform.position.y - 97.5f);
		trainingGroundDelBtn.GetComponentInChildren<Text> ().text = "Training Ground";
		trainingGroundDelBtn.onClick.AddListener (() => switchStructure ("Training Ground"));
		trainingGroundDelBtn.gameObject.SetActive (false);

		//Switch Modes
		switchModeDelBtn = (Button)Instantiate (switchModeBtn);
		switchModeDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		switchModeDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		switchModeDelBtn.transform.Translate (Screen.width - 32.5f, 32.5f, 0);
		switchModeDelBtn.GetComponentInChildren<Text> ().text = "";
		switchModeDelBtn.onClick.AddListener (() => switchMode ());
	}

	//=================\\
	//=== Functions ===\\
	//=================\\
	void buildBtnClicked () {
		Debug.Log ("Build button clicked");
		buildClicked = !buildClicked;
		structureBtnClicked = false;
	}

//	void deleteBtnClicked () {
//		//DELETE buildings
//	}

	void switchStructure (string s) {
		//Structure Button clicked
		structureBtnClicked = true;
		
		switch (s) {
			case "shelter":
			setBuildingTypeName = "shelter";
				break;
			case "farm":
				setBuildingTypeName = "farm";
				break;
			case "water":
				setBuildingTypeName = "water";
				break;
			case "power":
				setBuildingTypeName = "power";
				break;
			case "storage":
				setBuildingTypeName = "storage";
				break;
			case "hospital":
				setBuildingTypeName = "hospital";
				break;
			case "training ground":
				setBuildingTypeName = "training ground";
				break;
			case "empty":
				setBuildingTypeName = "Null";
				break;
			default:
				setBuildingTypeName = "Null";
				break;
		}

		if (Input.GetMouseButtonUp(0)) {
			buildClicked = !buildClicked;
		}
	}

	void switchMode ()
	{
		Debug.Log ("Switch Mode button clicked");
		/// create new save data
		///
		globalAttributes.saveCurrentSettlement ();
		Application.LoadLevel (3);
		globalAttributes.scrap = scrap + UnityEngine.Random.Range (10, 101);
		print ("Scrap is now: " + scrap);
	}
	 
	//==================\\
	//===== Update =====\\
	//==================\\

	// Update is called once per frame
	void Update () {
		/*/////HUD Text\\\\\*/
		bool hourZero = false;
		bool minZero = false;
		bool secZero = false;

		if (buildClicked == false && structureBtnClicked == false && Input.GetMouseButtonDown (0)) {
			switchStructure ("empty");
		}

		//Build button clicked
		switch (buildClicked) {
		case true:
			shelterDelBtn.gameObject.SetActive (true);
			farmDelBtn.gameObject.SetActive (true);
			waterStationDelBtn.gameObject.SetActive (true);
			powerStationDelBtn.gameObject.SetActive (true);
			storageDelBtn.gameObject.SetActive (true);
			trainingGroundDelBtn.gameObject.SetActive (true);
			hospitalDelBtn.gameObject.SetActive (true);
			break;
		case false:
			shelterDelBtn.gameObject.SetActive (false);
			farmDelBtn.gameObject.SetActive (false);
			waterStationDelBtn.gameObject.SetActive (false);
			powerStationDelBtn.gameObject.SetActive (false);
			storageDelBtn.gameObject.SetActive (false);
			trainingGroundDelBtn.gameObject.SetActive (false);
			hospitalDelBtn.gameObject.SetActive (false);
			break;
		}

		//Scrap
		scrap = globalAttributes.scrap;
		scrapDelText.text = scrap.ToString ();
		scrapDelText.color = new Color (244, 244, 244);

		if (scrap < 50)
			scrapDelText.color = new Color (255, 47, 37);
		else if (scrap >= 50 || scrap <= 100)
			scrapDelText.color = new Color (244, 244, 244);
		else if (scrap > 100) {
			scrapDelText.color = new Color (0, 115, 42);
		} else if (scrap > 999) {
			scrapDelText.fontSize = 18;
		}

		//Population
		//population = globalAttributes.population;
		population = 5;

		populationDelText.text = aSpawner.popSize + "/" + globalAttributes.popLimit;

		if (aSpawner.popSize < 5)
			populationDelText.color = new Color (255, 47, 37);
		else if (aSpawner.popSize > 5 || population < 30)
			populationDelText.color = new Color (244, 244, 244);
		else if (aSpawner.popSize > 30)
			populationDelText.color = new Color (0, 115, 42);

		//Food
		food = globalAttributes.food;
		foodDelText.text = food.ToString ();
		if (food <= 30)
			foodDelText.color = new Color (255, 47, 37);
		else if (food > 30 || food < 300)
			foodDelText.color = new Color (244, 244, 244);
		else if (food >= 300)
			foodDelText.color = new Color (0, 115, 42);

		//Water
		water = globalAttributes.water;
		waterDelText.text = water.ToString ();
		if (water <= 30)
			waterDelText.color = new Color (255, 47, 37);
		else if (water > 30 || water < 300)
			waterDelText.color = new Color (244, 244, 244);
		else if (water >= 300)
			waterDelText.color = new Color (0, 115, 42);

		//Power
		power = globalAttributes.power;
		powerDelText.text = power.ToString ();
		if (power <= 30)
			powerDelText.color = new Color (255, 47, 37);
		else if (power > 30 || power < 300)
			powerDelText.color = new Color (244, 244, 244);
		else if (power >= 300)
			powerDelText.color = new Color (0, 115, 42);

//		//Time
//		hour = Mathf.FloorToInt (Time.realtimeSinceStartup / (60 * 60));
//		minute = Mathf.FloorToInt (Time.realtimeSinceStartup / 60) - (hour * 60);
//		second = (int) Time.realtimeSinceStartup - (minute * 60);
//		
//		if (hour < 10) {
//			hourText = "0" + hour.ToString ();
//		} else
//			hourText = hour.ToString ();
//		
//		if (minute < 10) {
//			minText = "0" + minute.ToString ();
//		} else
//			minText = minute.ToString ();
//		
//		if (second < 10) {
//			secText = "0" + second.ToString ();
//		} else
//			secText = second.ToString ();
//
//		timeDelText.text = hourText + ":" + minText + ":" + secText;

		//String whatButtonIsIt = EventSystem.current.currentSelectedGameObject.name.ToString ();		// Checks what the current pointer is hovering over
	}
}