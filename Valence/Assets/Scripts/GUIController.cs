using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using System.Collections.Generic;

	public class GUIController : MonoBehaviour {

	//HUD Variables
	//GameObject globalAttributes;
	public Text scrapText, populationText, moraleText, foodText, waterText, powerText, timeText;
	Text scrapDelText, populationDelText, moraleDelText, foodDelText, waterDelText, powerDelText, timeDelText;

    AgentSpawner aSpawner;

	public GameController globalAttributes;
	public string setBuildingTypeName;

	int scrap, population;
	float morale, food, water, power;

	//Time variables
	int hour;
	int minute;
	int second;
	String hourText;
	String minText;
	String secText;

	//FPS variables
	private float updateInterval = 0.5F;
	private double lastInterval;
	private int frames = 0;
	private float fps;
	
	public Canvas myCanvas;

	public Image HUDBg;
	Image HUDDelBg;

	// === BUTTONS === \\
	//public Button[] buildBtnArray = new Button[1];
	public Button buildBtn;
	Button buildBtnDel;

	//public Button destroyBtn;
	//Button destroyBtnDel;

	public Button shelterBtn, farmBtn, waterStationBtn, powerStationBtn, storageBtn, shrineBtn, tavernBtn, hospitalBtn, schoolBtn;
	Button shelterDelBtn, farmDelBtn, waterStationDelBtn, powerStationDelBtn, storageDelBtn, shrineDelBtn, tavernDelBtn, hospitalDelBtn, schoolDelBtn;

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
		
		HUDDelBg.rectTransform.sizeDelta = new Vector2 (1920, 100);
		HUDDelBg.transform.Translate (960, Screen.height - 50, 0);
		
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
		buildBtnDel.transform.position = new Vector2 (40, 630);
		buildBtnDel.image.rectTransform.sizeDelta = new Vector2 (75, 75);
		buildBtnDel.onClick.AddListener (() => buildBtnClicked ());

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

		//Tavern Button
		tavernDelBtn = (Button)Instantiate (tavernBtn);
		tavernDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		tavernDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		tavernDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 137.5f, buildBtnDel.transform.position.y - 32.5f);
		tavernDelBtn.GetComponentInChildren<Text> ().text = "Tavern";
		tavernDelBtn.onClick.AddListener (() => switchStructure ("tavern"));
		tavernDelBtn.gameObject.SetActive (false);
		
		//Hospital Button
		hospitalDelBtn = (Button)Instantiate (hospitalBtn);
		hospitalDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		hospitalDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		hospitalDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 72.5f, buildBtnDel.transform.position.y - 97.5f);
		hospitalDelBtn.GetComponentInChildren<Text> ().text = "Hospital";
		hospitalDelBtn.onClick.AddListener (() => switchStructure ("hospital"));
		hospitalDelBtn.gameObject.SetActive (false);
		
		//School Button
		schoolDelBtn = (Button)Instantiate (schoolBtn);
		schoolDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		schoolDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		schoolDelBtn.transform.position = new Vector2 (buildBtnDel.transform.position.x + 137.5f, buildBtnDel.transform.position.y - 97.5f);
		schoolDelBtn.GetComponentInChildren<Text> ().text = "School";
		schoolDelBtn.onClick.AddListener (() => switchStructure ("school"));
		schoolDelBtn.gameObject.SetActive (false);

		//Switch Modes
		switchModeDelBtn = (Button)Instantiate (switchModeBtn);
		switchModeDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		switchModeDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		switchModeDelBtn.transform.Translate (Screen.width - 32.5f, 32.5f, 0);
		switchModeDelBtn.GetComponentInChildren<Text> ().text = "";
		switchModeDelBtn.onClick.AddListener (() => switchMode ());

		//===========================\\
		// === GLOBAL ATTRIBUTES === \\
		//===========================\\
		//Scrap
		scrapDelText = (Text)Instantiate (scrapText);
		scrapDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		scrapDelText.text = "";
		scrapDelText.fontSize = 28;
		scrapDelText.transform.position = new Vector2 (122, Screen.height - 50);
		scrapDelText.rectTransform.sizeDelta = new Vector2 (200, 50);
		
		//Population
		populationDelText = (Text)Instantiate (populationText);
		populationDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		populationDelText.text = "";
		populationDelText.fontSize = 20;
		populationDelText.transform.position = new Vector2 (scrapDelText.transform.position.x + 150, scrapDelText.transform.position.y + 15);
		
		//Morale		
		moraleDelText = (Text)Instantiate (moraleText);
		moraleDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		moraleDelText.text = "";
		moraleDelText.fontSize = 20;
		moraleDelText.transform.position = new Vector2 (populationDelText.transform.position.x + 160, scrapDelText.transform.position.y + 15);
		
		//Food
		foodDelText = (Text)Instantiate (foodText);
		foodDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		foodDelText.text = "";
		foodDelText.fontSize = 20;
		foodDelText.transform.position = new Vector2 (moraleDelText.transform.position.x + 160, scrapDelText.transform.position.y + 15);
		
		//Water
		waterDelText = (Text)Instantiate (waterText);
		waterDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		waterDelText.text = "";
		waterDelText.fontSize = 20;
		waterDelText.transform.position = new Vector2 (foodDelText.transform.position.x + 150, scrapDelText.transform.position.y + 15);
		
		//Power
		powerDelText = (Text)Instantiate (powerText);
		powerDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		powerDelText.text = "";
		powerDelText.fontSize = 20;
		powerDelText.transform.position = new Vector2 (waterDelText.transform.position.x + 140, scrapDelText.transform.position.y + 15);
		
		//Time
		timeDelText = (Text)Instantiate (timeText);
		timeDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		timeDelText.text = "";
		timeDelText.fontSize = 20;
		timeDelText.transform.position = new Vector2 (scrapDelText.transform.position.x + 1770, scrapDelText.transform.position.y + 15);
		timeDelText.color = new Color (0.0509803921568627f, 0.0509803921568627f, 0.0509803921568627f);

		//Time
		lastInterval = Time.realtimeSinceStartup;
		frames = 0;
		hour = 0;
		minute = 0;
		second = 0;
	}

	//=================\\
	//=== Functions ===\\
	//=================\\
	void buildBtnClicked () {
		Debug.Log ("Build button clicked");
		buildClicked = true;
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
			print ("HIIIIIIIIIIII");
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
		case "tavern":
			setBuildingTypeName = "tavern";
			break;
		case "school":
			setBuildingTypeName = "school";
			break;
		case "empty":
			setBuildingTypeName = "Null";
			break;
		default:
			setBuildingTypeName = "Null";
			break;
		}

		buildClicked = false;
	}
	void switchMode ()
	{
		Debug.Log ("Switch Mode button clicked");
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
			schoolDelBtn.gameObject.SetActive (true);
			tavernDelBtn.gameObject.SetActive (true);
			hospitalDelBtn.gameObject.SetActive (true);
			break;
		case false:
			shelterDelBtn.gameObject.SetActive (false);
			farmDelBtn.gameObject.SetActive (false);
			waterStationDelBtn.gameObject.SetActive (false);
			powerStationDelBtn.gameObject.SetActive (false);
			storageDelBtn.gameObject.SetActive (false);
			schoolDelBtn.gameObject.SetActive (false);
			tavernDelBtn.gameObject.SetActive (false);
			hospitalDelBtn.gameObject.SetActive (false);
			break;
		}

		//Scrap
		scrap = globalAttributes.scrap;
		scrapDelText.text = "Scrap: " + scrap;
		scrapDelText.color = new Color (244, 244, 244);
			
		if (scrap < 50)
			scrapDelText.color = new Color (0.4509803921568627f, 0.3529411764705882f, 0.3176470588235294f);
		else if (scrap >= 50 || scrap <= 100)
			scrapDelText.color = new Color (0.0509803921568627f, 0.0509803921568627f, 0.0509803921568627f);
		else if (scrap > 100) {
			scrapDelText.color = new Color (0.7372549019607843f, 0.8196078431372549f, 0.7098039215686275f);
		}

		//Population
		//population = globalAttributes.population;
		population = 5;
<<<<<<< HEAD
		populationDelText.text = "Pop: " + aSpawner.popSize;
=======
		populationDelText.text = "Population: " + aSpawner.popSize + "/" + globalAttributes.popLimit;
>>>>>>> origin/master

		if (aSpawner.popSize < 5)
			populationDelText.color = new Color (0.4509803921568627f, 0.3529411764705882f, 0.3176470588235294f);
		else if (aSpawner.popSize > 5 || population < 30)
			populationDelText.color = new Color (0.0509803921568627f, 0.0509803921568627f, 0.0509803921568627f);
		else if (aSpawner.popSize > 30)
			populationDelText.color = new Color (0.7372549019607843f, 0.8196078431372549f, 0.7098039215686275f);

		//Morale
		//morale = globalAttributes.morale;
		morale = 0;
		moraleDelText.text = "Morale: " + morale;

		if (morale < 50)
			moraleDelText.color = new Color (0.4509803921568627f, 0.3529411764705882f, 0.3176470588235294f);
		else if (morale >= 50 || morale < 80)
			moraleDelText.color = new Color (0.0509803921568627f, 0.0509803921568627f, 0.0509803921568627f);
		else if (morale >= 80)
			moraleDelText.color = new Color (0.7372549019607843f, 0.8196078431372549f, 0.7098039215686275f);

		//Food
		food = globalAttributes.food;
		foodDelText.text = "Food: " + food;
		if (food <= 30)
			foodDelText.color = new Color (0.4509803921568627f, 0.3529411764705882f, 0.3176470588235294f);
		else if (food > 30 || food < 300)
			foodDelText.color = new Color (0.0509803921568627f, 0.0509803921568627f, 0.0509803921568627f);
		else if (food >= 300)
			foodDelText.color = new Color (0.7372549019607843f, 0.8196078431372549f, 0.7098039215686275f);

		//Water
		water = globalAttributes.water;
		waterDelText.text = "Water: " + water.ToString ();
		if (water <= 30)
			waterDelText.color = new Color (0.4509803921568627f, 0.3529411764705882f, 0.3176470588235294f);
		else if (water > 30 || water < 300)
			waterDelText.color = new Color (0.0509803921568627f, 0.0509803921568627f, 0.0509803921568627f);
		else if (water >= 300)
			waterDelText.color = new Color (0.7372549019607843f, 0.8196078431372549f, 0.7098039215686275f);

		//Power
		power = globalAttributes.power;
		powerDelText.text = "Power: " + power.ToString ();
		if (power <= 30)
			powerDelText.color = new Color (0.4509803921568627f, 0.3529411764705882f, 0.3176470588235294f);
		else if (power > 30 || power < 300)
			powerDelText.color = new Color (0.0509803921568627f, 0.0509803921568627f, 0.0509803921568627f);
		else if (power >= 300)
			powerDelText.color = new Color (0.7372549019607843f, 0.8196078431372549f, 0.7098039215686275f);

		//Time
		hour = Mathf.FloorToInt (Time.realtimeSinceStartup / (60 * 60));
		minute = Mathf.FloorToInt (Time.realtimeSinceStartup / 60) - (hour * 60);
		second = (int) Time.realtimeSinceStartup - (minute * 60);
		
		if (hour < 10) {
			hourText = "0" + hour.ToString ();
		} else
			hourText = hour.ToString ();
		
		if (minute < 10) {
			minText = "0" + minute.ToString ();
		} else
			minText = minute.ToString ();
		
		if (second < 10) {
			secText = "0" + second.ToString ();
		} else
			secText = second.ToString ();

		timeDelText.text = hourText + ":" + minText + ":" + secText;

		//Frames
		++frames;
		float timeNow = Time.realtimeSinceStartup;
		if (timeNow > lastInterval + updateInterval) {
			fps = (float) (frames / (timeNow - lastInterval));
			frames = 0;
			lastInterval = timeNow;
		}

		//String whatButtonIsIt = EventSystem.current.currentSelectedGameObject.name.ToString ();		// Checks what the current pointer is hovering over
	}

	//==================\\
	//===== ON GUI =====\\
	//==================\\

	void OnGUI() {
		//FPS
		GUI.BeginGroup (new Rect (Screen.width - 75, 0, 200, 200));
		GUILayout.Label ("FPS: " + fps.ToString ("f2"));
		GUI.EndGroup ();
	}
}