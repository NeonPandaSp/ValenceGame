using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using System.Collections.Generic;

	public class GUIController : MonoBehaviour {

	//HUD Variables
	//GameObject globalAttributes;
	public Text scrapText, populationText, foodText, waterText, powerText;
	Text scrapDelText, populationDelText, foodDelText, waterDelText, powerDelText;
	public Image scrapIcon, populationIcon, foodIcon, waterIcon, powerIcon;
	Image scrapIconDel, populationIconDel, foodIconDel, waterIconDel, powerIconDel;

	AgentSpawner aSpawner;

	//Colours
	Color redValue, whiteValue, greenValue;

	float populationPercentage;

	public GameController globalAttributes;
	public string setBuildingTypeName;

	int scrap, population;
	float food, water, power;

	public Canvas myCanvas;

	public Texture2D cursorTexture_default;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	public Image HUDBg;
	Image HUDDelBg;

	// === BUTTONS === \\
	//public Button[] buildBtnArray = new Button[1];

	public Button buildBtn;
	Button buildBtnDel;

	public Button destroyBtn;
	Button destroyBtnDel;

	public Button shelterBtn, farmBtn, waterStationBtn, powerStationBtn, trainingGroundBtn;
	Button shelterDelBtn, farmDelBtn, waterStationDelBtn, powerStationDelBtn, trainingGroundDelBtn;

	public Button switchModeBtn;
	Button switchModeDelBtn;

	//test button
	public Button mFG;

	bool buildClicked;
	bool structureBtnClicked;

	public loadScene _loadScreen;

	public AudioController _audioController; // Audio controller

	//=================\\
	//===== Start =====\\
	//=================\\
	void Start () {
		globalAttributes = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		aSpawner = GameObject.Find("ASpawner").GetComponent<AgentSpawner>();
        // === HUD Background ===\\
		HUDDelBg = (Image)Instantiate (HUDBg);
		HUDDelBg.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		HUDDelBg.rectTransform.sizeDelta = new Vector2 (960, 109);
		HUDDelBg.transform.Translate (Screen.width / 2, Screen.height - 54.5f, 0);
		HUDDelBg.CrossFadeAlpha (0.9f, 0, false);

		//cursorTexture_default.Resize (9, 11);
		Cursor.SetCursor(cursorTexture_default, hotSpot, CursorMode.Auto);

		//===========================\\
		// === GLOBAL ATTRIBUTES === \\
		//===========================\\
		//Scrap
		scrapIconDel = (Image)Instantiate (scrapIcon);
		scrapIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		scrapIconDel.rectTransform.sizeDelta = new Vector2 (90, 72);
		scrapIconDel.transform.Translate (((HUDDelBg.gameObject.transform.position.x) - 30), Screen.height - 42.5f, 0);

			//Text
			scrapDelText = (Text)Instantiate (scrapText);
			scrapDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			scrapDelText.text = "";
			scrapDelText.transform.position = new Vector2 (HUDDelBg.rectTransform.position.x + 42.5f, scrapIconDel.rectTransform.position.y);
			scrapDelText.rectTransform.sizeDelta = new Vector2 (200, 50);

		//Population
		populationIconDel = (Image)Instantiate (populationIcon);
		populationIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		populationIconDel.rectTransform.sizeDelta = new Vector2 (70, 70);
		populationIconDel.transform.Translate (scrapIconDel.transform.position.x - 380, scrapIconDel.rectTransform.position.y - 25.5f, 0);

			//Text
			populationDelText = (Text)Instantiate (populationText);
			populationDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			populationDelText.text = "";
			populationDelText.fontSize = 20;
			populationDelText.transform.position = new Vector2 (populationIconDel.transform.position.x + 70, scrapDelText.transform.position.y - 25.5f);
		
		//Power
		powerIconDel = (Image)Instantiate (powerIcon);
		powerIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		powerIconDel.rectTransform.sizeDelta = new Vector2 (100, 100);
		powerIconDel.transform.Translate (populationIconDel.transform.position.x + 185, scrapIconDel.rectTransform.position.y - 25.5f, 0);
		
			//Text
			powerDelText = (Text)Instantiate (powerText);
			powerDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			powerDelText.text = "";
			powerDelText.transform.position = new Vector2 (powerIconDel.transform.position.x + 70, scrapDelText.transform.position.y - 25.5f);
			powerDelText.rectTransform.sizeDelta = new Vector2 (200, 50);

		//Food
		foodIconDel = (Image)Instantiate (foodIcon);
		foodIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		foodIconDel.rectTransform.sizeDelta = new Vector2 (120, 120);
		foodIconDel.transform.Translate (powerIconDel.transform.position.x + 390, scrapIconDel.rectTransform.position.y - 17.5f, 0);

			//Text
			foodDelText = (Text)Instantiate (foodText);
			foodDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			foodDelText.text = "";
			foodDelText.transform.position = new Vector2 (foodIconDel.transform.position.x + 70, scrapDelText.transform.position.y - 25.5f);
			foodDelText.rectTransform.sizeDelta = new Vector2 (100, 100);
		
		//Water
		waterIconDel = (Image)Instantiate (waterIcon);
		waterIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		waterIconDel.rectTransform.sizeDelta = new Vector2 (100, 100);
		waterIconDel.transform.Translate (foodIconDel.transform.position.x + 185, scrapIconDel.rectTransform.position.y - 20.5f, 0);

			//Text
			waterDelText = (Text)Instantiate (waterText);
			waterDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			
			waterDelText.text = "";
			waterDelText.transform.position = new Vector2 (waterIconDel.transform.position.x + 70, scrapDelText.transform.position.y - 25.5f);
			waterDelText.rectTransform.sizeDelta = new Vector2 (200, 50);


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

		//Switch Modes
		switchModeDelBtn = (Button)Instantiate (switchModeBtn);
		switchModeDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		switchModeDelBtn.image.rectTransform.sizeDelta = new Vector2 (75, 75);
		switchModeDelBtn.transform.position = new Vector2 (57.5f, Screen.height - 57.5f);
		switchModeDelBtn.GetComponentInChildren<Text> ().text = "";
		switchModeDelBtn.onClick.AddListener (() => switchMode ());

		//Build Button
		buildBtnDel = (Button)Instantiate (buildBtn);
		buildBtnDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		buildBtnDel.GetComponentInChildren<Text> ().text = "";
		buildBtnDel.transform.position = new Vector2 (switchModeDelBtn.transform.position.x, switchModeDelBtn.transform.position.y - 95);
		buildBtnDel.image.rectTransform.sizeDelta = new Vector2 (75, 75);
		buildBtnDel.onClick.AddListener (() => buildBtnClicked ());
		buildBtnDel.gameObject.SetActive (true);

		buildClicked = false;
		
		//Destroy Button //HIDDEN FOR BETA PRESENTATION
//		destroyBtnDel = (Button)Instantiate (destroyBtn);
//		destroyBtnDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
//		
//		destroyBtnDel.GetComponentInChildren<Text> ().text = "";
//		destroyBtnDel.transform.position = new Vector2 (buildBtnDel.transform.position.x, buildBtnDel.transform.position.y - 95);
//		destroyBtnDel.image.rectTransform.sizeDelta = new Vector2 (75, 75);
//		destroyBtnDel.onClick.AddListener (() => buildBtnClicked ());

		// === STRUCTURE BUTTONS === \\
		//Shelter Button				
		shelterDelBtn = (Button)Instantiate (shelterBtn);
		shelterDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		shelterDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		shelterDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 72.5f, buildBtnDel.transform.position.y);
		shelterDelBtn.GetComponentInChildren<Text> ().text = "Shelter";
		shelterDelBtn.onClick.AddListener (() => switchStructure ("shelter"));
		shelterDelBtn.gameObject.SetActive (false);
		
		//Farm Button
		farmDelBtn = (Button)Instantiate (farmBtn);
		farmDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		farmDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		farmDelBtn.transform.position = new Vector2 (shelterDelBtn.transform.position.x + 67.5f, buildBtnDel.transform.position.y);
		farmDelBtn.GetComponentInChildren<Text> ().text = "Farm";
		farmDelBtn.onClick.AddListener (() => switchStructure ("farm"));
		farmDelBtn.gameObject.SetActive (false);
		
		//Water Station Button
		waterStationDelBtn = (Button)Instantiate (waterStationBtn);
		waterStationDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		waterStationDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		waterStationDelBtn.transform.position = new Vector2 (shelterDelBtn.transform.position.x, buildBtnDel.transform.position.y - 67.5f);
		waterStationDelBtn.GetComponentInChildren<Text> ().text = "Water Station";
		waterStationDelBtn.onClick.AddListener (() => switchStructure ("water"));
		waterStationDelBtn.gameObject.SetActive (false);
		
		//Power Station Button
		powerStationDelBtn = (Button)Instantiate (powerStationBtn);
		powerStationDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		powerStationDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		powerStationDelBtn.transform.position = new Vector2 (waterStationDelBtn.transform.position.x + 67.5f, buildBtnDel.transform.position.y - 67.5f);
		powerStationDelBtn.GetComponentInChildren<Text> ().text = "Power Station";
		powerStationDelBtn.onClick.AddListener (() => switchStructure ("power"));
		powerStationDelBtn.gameObject.SetActive (false);

		//Training Ground Button
		trainingGroundDelBtn = (Button)Instantiate (trainingGroundBtn);
		trainingGroundDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		trainingGroundDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		trainingGroundDelBtn.transform.position = new Vector2 (powerStationDelBtn.transform.position.x + 67.5f, buildBtnDel.transform.position.y);
		trainingGroundDelBtn.GetComponentInChildren<Text> ().text = "Training Ground";
		trainingGroundDelBtn.onClick.AddListener (() => switchStructure ("training"));
		trainingGroundDelBtn.gameObject.SetActive (false);

		//Colours
		redValue = new Color (255 / 255f, 70 / 255f, 82 / 255f);
		whiteValue = new Color (244 / 255f, 244 / 255f, 244 / 255f);
		greenValue = new Color (115 / 255f, 255 / 255f, 149 / 255f);
	}

	//=================\\
	//=== Functions ===\\
	//=================\\
	void buildBtnClicked () {

		_audioController.playAudioClipOnce (1, Vector3.zero, 500); //play Sound

		transform.Translate (Vector3.forward * Time.deltaTime);
		//Debug.Log ("Build button clicked");
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
			case "hospital":
				setBuildingTypeName = "hospital";
				break;
			case "training":
				setBuildingTypeName = "training";
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
		//loadScreen.SetActive (true);
		//Application.LoadLevelAsync (3);
		_loadScreen.initLoadScene (3);
		//globalAttributes.scrap = scrap + UnityEngine.Random.Range (10, 101);
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

		//print ("this shit is: " + (scrapIconDel.transform.position.x - 315).ToString ());

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
			trainingGroundDelBtn.gameObject.SetActive (true);
			break;
		case false:
			shelterDelBtn.gameObject.SetActive (false);
			farmDelBtn.gameObject.SetActive (false);
			waterStationDelBtn.gameObject.SetActive (false);
			powerStationDelBtn.gameObject.SetActive (false);
			trainingGroundDelBtn.gameObject.SetActive (false);
			break;
		}

		//Scrap
		scrap = globalAttributes.scrap;
		scrapDelText.text = scrap.ToString ();

		if (scrap < 50) {
			scrapDelText.color = redValue;
			scrapDelText.fontSize = 24;
		} else if (scrap >= 50 && scrap <= 99) {
			scrapDelText.color = whiteValue;
			scrapDelText.fontSize = 22;
		} else if (scrap > 99) {
			scrapDelText.color = greenValue;
			scrapDelText.fontSize = 18;
		} else if (scrap > 999) {
			scrapDelText.fontSize = 16;
		}

		//Population
		population = globalAttributes.population.Count;
		populationDelText.text = population + "/" + globalAttributes.popLimit;
		populationPercentage = population / globalAttributes.popLimit;

		Color popColour = Color.Lerp (greenValue, redValue, populationPercentage);
		populationDelText.color = popColour;

		//Food
		food = (int)globalAttributes.food;
		foodDelText.text = food.ToString ();

		if (food <= 30) {
			foodDelText.color = redValue;
			foodDelText.fontSize = 24;
		} else if (food >= 50 && food <= 99) {
			foodDelText.color = whiteValue;
			foodDelText.fontSize = 22;
		} else if (food > 99) {
			foodDelText.fontSize = 18;
		} else if (food > 999) {
			foodDelText.color = greenValue;
			foodDelText.fontSize = 16;
		}

		//Water
		water = (int) globalAttributes.water;
		waterDelText.text = water.ToString ();

		if (water <= 30) {
			waterDelText.color = redValue;
			waterDelText.fontSize = 24;
		} else if (water >= 50 && water <= 99) {
			waterDelText.color = whiteValue;
			waterDelText.fontSize = 22;
		} else if (water > 99) {
			waterDelText.fontSize = 18;
		} else if (water > 999) {
			waterDelText.color = greenValue;
			waterDelText.fontSize = 16;
		}

		//Power
		power = (int) globalAttributes.power;
		powerDelText.text = power.ToString ();

		if (power <= 30) {
			powerDelText.color = redValue;
			powerDelText.fontSize = 24;
		} else if (power >= 50 && power <= 99) {
			powerDelText.color = whiteValue;
			powerDelText.fontSize = 22;
		} else if (power > 99) {
			powerDelText.fontSize = 18;
		} else if (power > 999) {
			powerDelText.color = greenValue;
			powerDelText.fontSize = 16;
		}

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