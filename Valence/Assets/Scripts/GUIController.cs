using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

	public class GUIController : MonoBehaviour {
	public InputController _inputController;

	Camera GUICam;

	//HUD Variables
	//GameObject globalAttributes;
	public Text scrapText, populationText, moraleText, foodText, waterText, powerText, timeText;
	Text scrapDelText, populationDelText, moraleDelText, foodDelText, waterDelText, powerDelText, timeDelText;

	GameController globalAttributes;

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
	
	//Settler Variables
	public float settlerHealth, settlerStrength, settlerAgility, settlerPerception, settlerIntelligence, settlerMorale, settlerHunger, settlerThirst;

	public Canvas myCanvas;

	public Texture2D buildIcon;
	public Texture2D destroyIcon;
	public Texture2D HUDBg;

	//Building Buttons
	public Button[] buildBtnArray = new Button[2];
	bool togBuildButtons;

	public Button shelterBtn, farmBtn, waterStationBtn, powerStationBtn, storageBtn, shrineBtn, tavernBtn, hospitalBtn, schoolBtn;
	Button shelterDelBtn, farmDelBtn, waterStationDelBtn, powerStationDelBtn, storageDelBtn, shrineDelBtn, tavernDelBtn, hospitalDelBtn, schoolDelBtn;

	public Button switchModeBtn;
	Button switchModeDelBtn;

	//test button
	public Button mFG;

	//=================\\
	//===== Start =====\\
	//=================\\

	// Use this for initialization
	void Start () {
		GUICam = Camera.main;
		globalAttributes = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();

		//Settler Attributes
		settlerHealth = 100;
		settlerStrength = 0;
		settlerAgility = 0;
		settlerPerception = 0;
		settlerIntelligence = 0;
		settlerMorale = 0;
		settlerHunger = 0;
		settlerThirst = 0;

		// === Building Buttons === \\
		for (int i = 0; i < buildBtnArray.Length; i++) {
			Button tempButton = (Button)Instantiate (buildBtnArray [i], Vector3.zero, Quaternion.identity);
			tempButton.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			buildBtnArray [i] = tempButton;
		}

		//Build Button
		buildBtnArray [0].name = "buildBtn";
		buildBtnArray [0].image.rectTransform.sizeDelta = new Vector2 (75, 75);
		buildBtnArray [0].transform.Translate (40, Screen.height - 155, 0);
		buildBtnArray [0].GetComponentInChildren<Text> ().text = "";
		buildBtnArray [0].onClick.AddListener (() => buildBtneClicked ());

		//Destroy Button
		buildBtnArray [1].name = "destroyBtn";
		buildBtnArray [1].image.rectTransform.sizeDelta = new Vector2 (75, 75);
		buildBtnArray [1].transform.Translate (40, Screen.height - 235, 0);
		buildBtnArray [1].GetComponentInChildren<Text> ().text = "";

		// === Structure Buttons === \\
		//Shelter Button				
		shelterDelBtn = (Button)Instantiate (shelterBtn);
		shelterDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		shelterDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		shelterDelBtn.transform.Translate (112.5f, Screen.height - 155, 0);
		shelterDelBtn.GetComponentInChildren<Text> ().text = "Shelter";
		shelterDelBtn.gameObject.SetActive (false);

		//Farm Button
		farmDelBtn = (Button)Instantiate (farmBtn);
		farmDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		farmDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		farmDelBtn.transform.Translate (112.5f, Screen.height - 220, 0);
		farmDelBtn.GetComponentInChildren<Text> ().text = "Farm";
		farmDelBtn.gameObject.SetActive (false);
		
		//Water Station Button
		waterStationDelBtn = (Button)Instantiate (waterStationBtn);
		waterStationDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		waterStationDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		waterStationDelBtn.transform.Translate (112.5f, Screen.height - 285, 0);
		waterStationDelBtn.GetComponentInChildren<Text> ().text = "Water Station";
		waterStationDelBtn.gameObject.SetActive (false);
		
		//Power Station Button
		powerStationDelBtn = (Button)Instantiate (powerStationBtn);
		powerStationDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		powerStationDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		powerStationDelBtn.transform.Translate (112.5f, Screen.height - 350, 1);
		powerStationDelBtn.GetComponentInChildren<Text> ().text = "Power Station";
		powerStationDelBtn.gameObject.SetActive (false);
		
		//Storage Button
		storageDelBtn = (Button)Instantiate (storageBtn);
		storageDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		storageDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		storageDelBtn.transform.Translate (112.5f, Screen.height - 415, 0);
		storageDelBtn.GetComponentInChildren<Text> ().text = "Storage";
		storageDelBtn.gameObject.SetActive (false);
		
		//Shrine Button
		shrineDelBtn = (Button)Instantiate (shrineBtn);
		shrineDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		shrineDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		shrineDelBtn.transform.Translate (112.5f, Screen.height - 480, 0);
		shrineDelBtn.GetComponentInChildren<Text> ().text = "Shrine";
		shrineDelBtn.gameObject.SetActive (false);
		
		//Tavern Button
		tavernDelBtn = (Button)Instantiate (tavernBtn);
		tavernDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		tavernDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		tavernDelBtn.transform.Translate (112.5f, Screen.height - 545, 0);
		tavernDelBtn.GetComponentInChildren<Text> ().text = "Tavern";
		tavernDelBtn.gameObject.SetActive (false);
		
		//Hospital Button
		hospitalDelBtn = (Button)Instantiate (hospitalBtn);
		hospitalDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		hospitalDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		hospitalDelBtn.transform.Translate (112.5f, Screen.height - 610, 0);
		hospitalDelBtn.GetComponentInChildren<Text> ().text = "Hospital";
		hospitalDelBtn.gameObject.SetActive (false);
		
		//School Button
		schoolDelBtn = (Button)Instantiate (schoolBtn);
		schoolDelBtn.gameObject.transform.SetParent (myCanvas.gameObject.transform);
		
		schoolDelBtn.image.rectTransform.sizeDelta = new Vector2 (65, 65);
		schoolDelBtn.transform.Translate (112.5f, Screen.height - 675, 0);
		schoolDelBtn.GetComponentInChildren<Text> ().text = "School";
		schoolDelBtn.gameObject.SetActive (false);

		//Time
		lastInterval = Time.realtimeSinceStartup;
		frames = 0;
		hour = 0;
		minute = 0;
		second = 0;

//		//Test button
//		Button mfg = (Button)Instantiate(mFG);
//		mfg.gameObject.transform.SetParent(myCanvas.gameObject.transform);
//		mfg.onClick.AddListener(() => ButtonClicked());
//		mfg.GetComponentInChildren<Text> ().text = "mFG Button";

		// === Global Attributes === \\
		// FOR SCRAP: Color (13, 13, 13); AND fontSize = 28;
		// FOR THE OTHER GLOBAL VARS Color (244, 244, 244); AND fontSize = 20;

		//Scrap
		scrapDelText = (Text)Instantiate (scrapText);
		scrapDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		scrapText.text = "";
		scrapText.fontSize = 14;
		scrapText.transform.position = new Vector2 (130, Screen.height / 2);
		//scrapDelText.transform.Translate (30, Screen.height - 55, 1);

		//Population
		populationDelText = (Text)Instantiate (populationText);
		populationDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		populationText.text = "";
		populationText.fontSize = 20;
		populationText.transform.position = new Vector2 (scrapText.transform.position.x + 127, Screen.height - 22.5f);

		//Morale		
		moraleDelText = (Text)Instantiate (moraleText);
		moraleDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		moraleText.text = "";
		moraleText.fontSize = 20;
		moraleText.transform.position = new Vector2 (populationText.rectTransform.position.x + 165, Screen.height - 22.5f);
				
		//Food
		foodDelText = (Text)Instantiate (foodText);
		foodDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		foodText.text = "";
		foodText.fontSize = 20;
		foodText.transform.position = new Vector2 (moraleText.rectTransform.position.x + 150, Screen.height - 22.5f);
		
		//Water
		waterDelText = (Text)Instantiate (waterText);
		waterDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		waterText.text = "";
		waterText.fontSize = 20;
		waterText.transform.position = new Vector2 (foodText.rectTransform.position.x + 150, Screen.height - 22.5f);
		
		//Power
		powerDelText = (Text)Instantiate (powerText);
		powerDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		powerText.text = "";
		powerText.fontSize = 20;
		powerText.transform.position = new Vector2 (waterText.rectTransform.position.x + 150, Screen.height - 22.5f);
		
		//Time
		timeDelText = (Text)Instantiate (timeText);
		timeDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);

		timeText.text = "";
		timeText.fontSize = 20;
		timeText.transform.position = new Vector2 (1810, Screen.height - 22.5f);
		timeText.color = new Color (1, 1, 1);

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
	void buildBtneClicked ()
	{
		Debug.Log ("Build button clicked");
		shelterDelBtn.gameObject.SetActive (true);
		farmDelBtn.gameObject.SetActive (true);
		waterStationDelBtn.gameObject.SetActive (true);
		powerStationDelBtn.gameObject.SetActive (true);
		storageDelBtn.gameObject.SetActive (true);
		shrineDelBtn.gameObject.SetActive (true);
		tavernDelBtn.gameObject.SetActive (true);
		hospitalDelBtn.gameObject.SetActive (true);
	}

	void switchMode ()
	{
		Debug.Log ("Switch Mode button clicked");
		scrap = scrap + UnityEngine.Random.Range (10, 101);
		print ("Scrap is now: " + scrap);

		population = population + UnityEngine.Random.Range (10, 101);
		print ("Population is now: " + population);
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
		
		//Scrap
		scrap = globalAttributes.scrap;
		scrapText.text = "Scrap: " + scrap.ToString ();
		scrapText.color = new Color (244, 244, 244);
		print ("SCRAP POS IS: " + scrapText.transform.position);

		//Population
		//population = 0;		//Placeholder ---- globalAttributes.population;
		populationText.text = "Population: " + population.ToString (); //.ToString ();
		if (population < 5)
			populationText.color = new Color (1, 0, 0);
		else if (population > 5 || population < 30)
			populationText.color = new Color (1, 1, 1);
		else if (population > 30)
			populationText.color = new Color (0, 1, 0);

		print ("Population = " + population.ToString ());

		//Morale
		//morale = 0;			//Placeholder ---- globalAttributes.morale;
		moraleText.text = "Morale: " + morale.ToString ();
		if (morale < 50)
			moraleText.color = new Color (1, 0, 0);
		else if (morale >= 50 || morale < 80)
			moraleText.color = new Color (1, 1, 1);
		else if (morale >= 80)
			moraleText.color = new Color (0, 1, 0);

		//Food
		food = globalAttributes.food;
		foodText.text = "Food: " + food.ToString ();
		if (food <= 30)
			foodText.color = new Color (1, 0, 0);
		else if (food > 30 || food < 300)
			foodText.color = new Color (1, 1, 1);
		else if (food >= 300)
			foodText.color = new Color (0, 1, 0);

		//Water
		water = globalAttributes.water;
		waterText.text = "Water: " + water.ToString ();
		if (water <= 30)
			waterText.color = new Color (1, 0, 0);
		else if (water > 30 || water < 300)
			waterText.color = new Color (1, 1, 1);
		else if (water >= 300)
			waterText.color = new Color (0, 1, 0);

		//Power
		power = globalAttributes.power;
		powerText.text = "Power: " + power.ToString ();
		if (power <= 30)
			powerText.color = new Color (1, 0, 0);
		else if (power > 30 || power < 300)
			powerText.color = new Color (1, 1, 1);
		else if (power >= 300)
			powerText.color = new Color (0, 1, 0);

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

		timeText.text = hourText + ":" + minText + ":" + secText;

		//Frames
		++frames;
		float timeNow = Time.realtimeSinceStartup;
		if (timeNow > lastInterval + updateInterval) {
			fps = (float) (frames / (timeNow - lastInterval));
			frames = 0;
			lastInterval = timeNow;
		}

		//String whatButtonIsIt = EventSystem.current.currentSelectedGameObject.name.ToString ();		// Checks what the current pointer is hovering over
		/*///// BUTTONS \\\\\*/
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("This isn't the button you are looking for");
			//buildBtnArray[0].interactable = false;
			shelterDelBtn.gameObject.SetActive (false);
			farmDelBtn.gameObject.SetActive (false);
			waterStationDelBtn.gameObject.SetActive (false);
			powerStationDelBtn.gameObject.SetActive (false);
			storageDelBtn.gameObject.SetActive (false);
			shrineDelBtn.gameObject.SetActive (false);
			tavernDelBtn.gameObject.SetActive (false);
			hospitalDelBtn.gameObject.SetActive (false);
			schoolDelBtn.gameObject.SetActive (false);
		}
	}

	//==================\\
	//===== ON GUI =====\\
	//==================\\

	void OnGUI() {
		//FPS
		GUI.BeginGroup (new Rect (Screen.width - 75, 0, 200, 200));
		GUILayout.Label ("FPS: " + fps.ToString ("f2"));
		GUI.EndGroup ();

		GUI.DrawTexture (new Rect (0, 0, 1920, 100), HUDBg);

		/*///// Settler Attributes (Currently invisbile) \\\\\*/
		Rect setHPPos = new Rect (350, 1050, 50, 50);
		Rect setStrPos = new Rect (setHPPos.x + 50, 1050, 50, 50);
		Rect setAglPos = new Rect (setStrPos.x + 55, 1050, 50, 50);
		Rect setPrcPos = new Rect (setAglPos.x + 50, 1050, 50, 50);
		Rect setIntPos = new Rect (setPrcPos.x + 50, 1050, 50, 50);
		Rect setMrlPos = new Rect (setIntPos.x + 50, 1050, 50, 50);
		Rect setHngPos = new Rect (setMrlPos.x + 50, 1050, 50, 50);
		Rect setThrPos = new Rect (setHngPos.x + 50, 1050, 50, 50);
	}
}