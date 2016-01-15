using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

	public class GUIController : MonoBehaviour {
	public InputController _inputController;

	Camera GUICam;

	//FPS variables
	private float updateInterval = 0.5F;
	private double lastInterval;
	private int frames = 0;
	private float fps;

	//Time variables
	int hour;
	int minute;
	int second;
	String hourText;
	String minText;
	String secText;

	//HUD Variables
	public int scrap, population;
	public float morale, food, water, power;

	//Settler Variables
	public float settlerHealth, settlerStrength, settlerAgility, settlerPerception, settlerIntelligence, settlerMorale, settlerHunger, settlerThirst;

	public Canvas myCanvas;

	public Texture2D buildIcon;
	public Texture2D destroyIcon;
	public Texture2D HUDBg;

	public Button buildButton;
	public Button destroyButton;

	//Building Buttons
	public Button[] buildBtnArray = new Button[11];

	bool togBuildButtons;

	//=================\\
	//===== Start =====\\
	//=================\\

	// Use this for initialization
	void Start () {
		GUICam = Camera.main;

		//Global Attributes
		scrap = 0;
		population = 0;
		morale = 100.0f;
		food = 0;
		water = 0;
		power = 0;

		//Settler Attributes
		settlerHealth = 100;
		settlerStrength = 0;
		settlerAgility = 0;
		settlerPerception = 0;
		settlerIntelligence = 0;
		settlerMorale = 0;
		settlerHunger = 0;
		settlerThirst = 0;

		//Building Buttons
		for (int i = 0; i < buildBtnArray.Length; i++)
		{
			Button tempButton = (Button)Instantiate (buildBtnArray[i], Vector3.zero, Quaternion.identity);
			tempButton.gameObject.transform.SetParent (myCanvas.gameObject.transform);
			buildBtnArray[i] = tempButton;
		}

		//	GUI.Button (new Rect (1150, 0, 75, 75), "Shelter");
		//	GUI.Button (new Rect (1225, 0, 75, 75), "Farm");
		//	GUI.Button (new Rect (1300, 0, 75, 75), "Water plant");
		//	GUI.Button (new Rect (1375, 0, 75, 75), "Power plant");
		//	GUI.Button (new Rect (1450, 0, 75, 75), "Storage");
		//	GUI.Button (new Rect (1525, 0, 75, 75), "Shrine");
		//	GUI.Button (new Rect (1600, 0, 75, 75), "Tavern");
		//	GUI.Button (new Rect (1675, 0, 75, 75), "Hospital");
		//	GUI.Button (new Rect (1750, 0, 75, 75), "School");

		//Build Button
		buildBtnArray [0].name = "buildBtn";
		buildBtnArray [0].image.rectTransform.sizeDelta = new Vector2 (75, 75);
		buildBtnArray [0].transform.Translate (32.5f, Screen.height - 155, 0);

		//Destroy Button
		buildBtnArray [1].name = "destroyBtn";
		buildBtnArray [1].image.rectTransform.sizeDelta = new Vector2 (75, 75);
		buildBtnArray [1].transform.Translate (32.5f, Screen.height - 75, 0);

		//Shelter Button
		buildBtnArray [2].name = "shelterBtn";
		buildBtnArray [2].image.rectTransform.sizeDelta = new Vector2 (65, 65);
		buildBtnArray [2].transform.Translate (97.5f, Screen.height - 155, 0);

		//Farm Button
		buildBtnArray [3].name = "farmBtn";
		buildBtnArray [3].image.rectTransform.sizeDelta = new Vector2 (65, 65);
		buildBtnArray [3].transform.Translate (97.5f, Screen.height - 210, 0);

		//Water Station Button
		buildBtnArray [4].name = "waterStationBtn";
		buildBtnArray [4].image.rectTransform.sizeDelta = new Vector2 (65, 65);
		buildBtnArray [4].transform.Translate (97.5f, Screen.height - 275, 0);

		//Power Station Button
		buildBtnArray [5].name = "powerStationBtn";
		buildBtnArray [5].image.rectTransform.sizeDelta = new Vector2 (65, 65);
		buildBtnArray [5].transform.Translate (97.5f, Screen.height - 355, 1);

		//Storage Button
		buildBtnArray [6].name = "storageBtn";
		buildBtnArray [6].image.rectTransform.sizeDelta = new Vector2 (65, 65);
		buildBtnArray [6].transform.Translate (97.5f, Screen.height - 410, 0);

		//Shrine Button
		buildBtnArray [7].name = "shrineBtn";
		buildBtnArray [7].image.rectTransform.sizeDelta = new Vector2 (65, 65);
		buildBtnArray [7].transform.Translate (97.5f, Screen.height - 155, 0);

		//Tavern Button
		buildBtnArray [8].name = "tavernBtn";
		buildBtnArray [8].image.rectTransform.sizeDelta = new Vector2 (65, 65);
		buildBtnArray [8].transform.Translate (97.5f, 0, 0);

		//Hospital Button
		buildBtnArray [9].name = "hospitalBtn";
		buildBtnArray [9].image.rectTransform.sizeDelta = new Vector2 (65, 65);
		buildBtnArray [9].transform.Translate (97.5f, 0, 0);

		//School Button
		buildBtnArray [10].name = "schoolBtn";
		buildBtnArray [10].image.rectTransform.sizeDelta = new Vector2 (65, 65);
		buildBtnArray [10].transform.Translate (97.5f, 0, 0);

		togBuildButtons = false;

		//Time
		lastInterval = Time.realtimeSinceStartup;
		frames = 0;
		hour = 0;
		minute = 0;
		second = 0;
	}
	 
	//==================\\
	//===== Update =====\\
	//==================\\

	// Update is called once per frame
	void Update () {

		scrap++;
		population++;
		morale--;
		food--;
		water++;
		power++;

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
	}

	//==================\\
	//===== ON GUI =====\\
	//==================\\

	void OnGUI() {
		/* ///// HUD \\\\\ */
		//FPS
		GUI.BeginGroup (new Rect (Screen.width - 75, 0, 200, 200));
		GUILayout.Label ("FPS: " + fps.ToString ("f2"));
		GUI.EndGroup ();
		
		GUIStyle HUDStyle = new GUIStyle ();
		HUDStyle.font = (Font)Resources.Load ("Segoe_UI_Light", typeof(Font));
		HUDStyle.normal.textColor = new Color (244, 244, 244);
		HUDStyle.fontSize = 28;

		//Time
		Rect timePos = new Rect (25, 25, 100, 100);

		GUIStyle HUDStyle2 = new GUIStyle ();
		HUDStyle2.font = (Font)Resources.Load ("Segoe_UI_Light", typeof(Font));
		HUDStyle2.normal.textColor = new Color (244, 244, 244);
		HUDStyle2.fontSize = 20;

		//Global Attributes
		Rect scrapPos = new Rect (timePos.x + 175, 15, 100, 100);
		Rect popPos = new Rect (scrapPos.x + 127, 15, 100, 100);
		Rect moralePos = new Rect (popPos.x + 165, 15, 100, 100);
		Rect foodPos = new Rect (moralePos.x + 150, 15, 100, 100);
		Rect waterPos = new Rect (foodPos.x + 150, 15, 100, 100);
		Rect powerPos = new Rect (waterPos.x + 150, 15, 100, 100);
		
		GUI.DrawTexture (new Rect (0, 0, 1070, 100), HUDBg);
		GUI.Label (timePos, hourText + ":" + minText + ":" + secText, HUDStyle);
		GUI.Label (scrapPos, "Scrap: " + scrap.ToString (), HUDStyle2);
		GUI.Label (popPos, "Population: " + population.ToString (), HUDStyle2);
		GUI.Label (moralePos, "Morale: " + morale.ToString (), HUDStyle2);
		GUI.Label (foodPos, "Food: " + food.ToString (), HUDStyle2);
		GUI.Label (waterPos, "Water: " + water.ToString (), HUDStyle2);
		GUI.Label (powerPos, "Power: " + power.ToString (), HUDStyle2);

		/* ///// BUTTONS \\\\\ */
		//buildButton (new Rect (0, 100, 75, 75), buildIcon);
		GUI.Button (new Rect (0, 175, 75, 75), destroyIcon);

		if (Input.GetMouseButtonDown (0) )
		{
			//if (EventSystem.current.IsPointerOverGameObject (buildBtnArray[0]))
				//Debug.Log ("Button has been clicked!");
			//else Debug.Log ("It's just a regular ass left-click!");
		}

		settlerHealth = 100;
		settlerStrength = 0;
		settlerAgility = 0;
		settlerPerception = 0;
		settlerIntelligence = 0;
		settlerMorale = 0;
		settlerHunger = 0;
		settlerThirst = 0;

		Rect setHPPos = new Rect (350, 1050, 50, 50);
		Rect setStrPos = new Rect (setHPPos.x + 50, 1050, 50, 50);
		Rect setAglPos = new Rect (setStrPos.x + 55, 1050, 50, 50);
		Rect setPrcPos = new Rect (setAglPos.x + 50, 1050, 50, 50);
		Rect setIntPos = new Rect (setPrcPos.x + 50, 1050, 50, 50);
		Rect setMrlPos = new Rect (setIntPos.x + 50, 1050, 50, 50);
		Rect setHngPos = new Rect (setMrlPos.x + 50, 1050, 50, 50);
		Rect setThrPos = new Rect (setHngPos.x + 50, 1050, 50, 50);

		GUI.DrawTexture (new Rect (0, 0, 1070, 100), HUDBg);
		GUI.Label (timePos, hourText + ":" + minText + ":" + secText, HUDStyle);
		GUI.Label (scrapPos, "Scrap: " + scrap.ToString (), HUDStyle2);
		GUI.Label (popPos, "Population: " + population.ToString (), HUDStyle2);
		GUI.Label (moralePos, "Morale: " + morale.ToString (), HUDStyle2);
		GUI.Label (foodPos, "Food: " + food.ToString (), HUDStyle2);
		GUI.Label (waterPos, "Water: " + water.ToString (), HUDStyle2);
		GUI.Label (powerPos, "Power: " + power.ToString (), HUDStyle2);

		if (togBuildButtons == true) {
			//Button newButton = new Button();
		
			//Button farmButton = new Button ();
			//(new Rect (1075, 0, 75, 75), "Farm");
			print ("hi");
		} else {
			//
		}
	}
}