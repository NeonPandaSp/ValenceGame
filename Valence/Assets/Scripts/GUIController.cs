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
	private Text timeText;
	Text scrapText, populationText, moraleText, foodText, waterText, powerText;

	//public float moraleValue, foodValue, waterValue, powerValue;

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

	//test button
	public Button mFG;

	//=================\\
	//===== Start =====\\
	//=================\\

	// Use this for initialization
	void Start () {
		GUICam = Camera.main;

//		var globalAttributes : GameObject[];
//		GameController flower = globalAttributes.GetComponent <GameController> ();
//		Debug.Log ("FWWWWWWWWW: " + flower);

//		GameObject gameControllerObject =  GameObject.FindGameObjectWithTag("scrap");
//		_myGameController = gameControllerObject.GetComponent<GameController> ();

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
		for (int i = 0; i < buildBtnArray.Length; i++)
		{
			Button tempButton = (Button)Instantiate (buildBtnArray[i], Vector3.zero, Quaternion.identity);
			tempButton.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			buildBtnArray[i] = tempButton;
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

		// === Building Buttons === \\
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
	 
	//==================\\
	//===== Update =====\\
	//==================\\

	// Update is called once per frame
	void Update () {
		/*/////HUD Text\\\\\*/
		//Scrap
		//scrapText.text = "Scrap: " + globalAttributes.ToString ();
		//scrapText.color = new Color (13, 13, 13);
		//scrapText.fontSize = 28;

		//Population
		//populationText.text = "Population: " + 0; //.ToString ();

		//Morale
		//moraleText.text = "Morale: " + 0; //.ToString ();

		//Food
		//foodText.text = "Food: " + 0; //oodValue.ToString ();

		//Water
		//waterText.text = "Water: " + 0; //waterValue.ToString ();

		//Power
		//powerText.text = "Power: " + 0; //powerValue.ToString ();

		//Time
		//timeText.text = hourText + ":" + minText + ":" + secText;

		//Time
		bool hourZero = false;
		bool minZero = false;
		bool secZero = false;
		
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
		
		//HUD Styles
		GUIStyle HUDStyle1 = new GUIStyle ();
		HUDStyle1.font = (Font)Resources.Load ("Segoe_UI_Light", typeof(Font));
		HUDStyle1.normal.textColor = new Color (13, 13, 13);
		HUDStyle1.fontSize = 28;

		GUIStyle HUDStyle2 = new GUIStyle ();
		HUDStyle2.font = (Font)Resources.Load ("Segoe_UI_Light", typeof(Font));
		HUDStyle2.normal.textColor = new Color (244, 244, 244);
		HUDStyle2.fontSize = 20;

		/*///// Global Attributes \\\\\*/
		Rect scrapPos = new Rect (30, 25, 100, 100);
		Rect popPos = new Rect (scrapPos.x + 127, 15, 100, 100);
		Rect moralePos = new Rect (popPos.x + 165, 15, 100, 100);
		Rect foodPos = new Rect (moralePos.x + 150, 15, 100, 100);
		Rect waterPos = new Rect (foodPos.x + 150, 15, 100, 100);
		Rect powerPos = new Rect (waterPos.x + 150, 15, 100, 100);
		Rect timePos = new Rect (1810, 25, 100, 100);
		
		GUI.DrawTexture (new Rect (0, 0, 1920, 100), HUDBg);

//		//Text
//		GUI.Label (scrapPos, "Scrap: " + globalAttributes.ToString (), HUDStyle1);
//		GUI.Label (popPos, "Population: " + populationValue.ToString (), HUDStyle2);
//		GUI.Label (moralePos, "Morale: " + moraleValue.ToString (), HUDStyle2);
//		GUI.Label (foodPos, "Food: " + foodValue.ToString (), HUDStyle2);
//		GUI.Label (waterPos, "Water: " + waterValue.ToString (), HUDStyle2);
//		GUI.Label (powerPos, "Power: " + powerValue.ToString (), HUDStyle2);
//		GUI.Label (timePos, hourText + ":" + minText + ":" + secText, HUDStyle2);
		
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