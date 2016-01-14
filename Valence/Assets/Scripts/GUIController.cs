using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class GUIController : MonoBehaviour {
	public InputController _inputController;
	public GameObject GUIObject;

	Camera GUICam;

	//FPS variables
	private float updateInterval = 0.5F;
	private double lastInterval;
	private int frames = 0;
	private float fps;

	Vector2 lastMousePos;

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
	//public Text timeText, scrapText, popText, moraleText, foodText, waterText, powerText;

	//Buttons Variables
	public Texture2D buildIcon;
	public Texture2D destroyIcon;
	public Texture2D HUDBg;

	//=================\\
	//===== Start =====\\
	//=================\\

	// Use this for initialization
	void Start () {
		GUICam = Camera.main;

		scrap = 0;
		population = 0;
		morale = 100.0f;
		food = 0;
		water = 0;
		power = 0;
		
		lastMousePos = Input.mousePosition;

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

		int x, y;
		if (Input.mousePosition.x > lastMousePos.x) {
			x = -1;
		} else if (Input.mousePosition.x < lastMousePos.x) {
			x = 1;
		} else {
			x = 0;
		}

		if (Input.mousePosition.y > lastMousePos.y) {
			y = -1;
		} else if (Input.mousePosition.y < lastMousePos.y) {
			y = 1;
		} else {
			y = 0;
		}

		lastMousePos = Input.mousePosition;

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
		GUI.BeginGroup (new Rect (Screen.width -100, 0, 200, 200));
		GUILayout.Label ("FPS: " + fps.ToString ("f2"));
		GUI.EndGroup ();
		
		GUIStyle HUDStyle = new GUIStyle ();
		HUDStyle.font = (Font)Resources.Load ("Segoe_UI_Light", typeof(Font));
		HUDStyle.normal.textColor = new Color (244, 244, 244);
		HUDStyle.fontSize = 28;

		//Time
		Rect timePos = new Rect (0, 0, 100, 100);
		GUI.color = new Color (109, 110, 113);

		//Global Attributes
		GUIStyle HUDStyle2 = new GUIStyle ();
		HUDStyle2.fontSize = 20;
		
		Rect scrapPos = new Rect (timePos.x + 100, 0, 100, 100);
		Rect popPos = new Rect (scrapPos.x + 100, 0, 100, 100);
		Rect moralePos = new Rect (popPos.x + 175, 0, 100, 100);
		Rect foodPos = new Rect (moralePos.x + 100, 0, 100, 100);
		Rect waterPos = new Rect (foodPos.x + 100, 0, 100, 100);
		Rect powerPos = new Rect (waterPos.x + 100, 0, 100, 100);
		
		GUI.DrawTexture (new Rect (0, 0, 1070, 100), HUDBg);
		GUI.Label (timePos, hourText + ":" + minText + ":" + secText, HUDStyle);
		GUI.Label (scrapPos, "Scrap: " + scrap.ToString (), HUDStyle);
		GUI.Label (popPos, "Population: " + population.ToString (), HUDStyle);
		GUI.Label (moralePos, "Morale: " + morale.ToString (), HUDStyle);
		GUI.Label (foodPos, "Food: " + food.ToString (), HUDStyle);
		GUI.Label (waterPos, "Water: " + water.ToString (), HUDStyle);
		GUI.Label (powerPos, "Power: " + power.ToString (), HUDStyle);

		/* ///// BUTTONS \\\\\ */
		if (GUI.Button (new Rect (0, 100, 75, 75), buildIcon)) {
			print ("hi");
			GUI.Button (new Rect (0, (Screen.height - 205) - 200, 75, 75), "Farm");
			GUI.Button (new Rect (0, (Screen.height - 205) - 250, 75, 75), "Shelter");
			GUI.Button (new Rect (0, (Screen.height - 205) - 300, 75, 75), "Hospital");
			GUI.Button (new Rect (0, (Screen.height - 205) - 350, 75, 75), "Water plant");
			GUI.Button (new Rect (0, (Screen.height - 205) - 400, 75, 75), "Power plant");
			GUI.Button (new Rect (0, (Screen.height - 205) - 100, 75, 75), "Storage");
			GUI.Button (new Rect (0, (Screen.height - 205) - 100, 75, 75), "Shrine");
			GUI.Button (new Rect (0, (Screen.height - 205) - 100, 75, 75), "Tavern");
			GUI.Button (new Rect (0, (Screen.height - 205) - 100, 75, 75), "Hospital");
			GUI.Button (new Rect (0, (Screen.height - 205) - 100, 75, 75), "School");
		}

		GUI.Button (new Rect (0, 175, 75, 75), destroyIcon);
	}
}