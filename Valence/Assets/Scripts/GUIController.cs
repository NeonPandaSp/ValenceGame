using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GUIController : MonoBehaviour {
	public InputController _inputController;
	public GameObject GUIObject;

	//FPS variables
	private float updateInterval = 0.5F;
	private double lastInterval;
	private int frames = 0;
	private float fps;

	int hour;
	int minute;
	int second;

	public Text timeText, scrapText, popText, moraleText, foodText, waterText, powerText;
	//public Button shelterButton, foodButton, powerButton;

	//Buttons
	public Texture2D buildIcon;
	public Texture2D destroyIcon;


	Vector2 lastMousePos;

	public int scrap, population;
	public float morale, food, water, power;

	//=================\\
	//===== Start =====\\
	//=================\\

	// Use this for initialization
	void Start () {
		scrap = 0;
		population = 0;
		morale = 100.0f;
		food = 0;
		water = 0;
		power = 0;

		setTimeText ();
		setScrapText ();
		setPopText ();
		setMoraleText ();
		setFoodText ();
		setWaterText ();
		setPowerText ();

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

		setTimeText ();
		setScrapText ();
		setPopText ();
		setMoraleText ();
		setFoodText ();
		setWaterText ();
		setPowerText ();

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
		hour = Mathf.FloorToInt( Time.realtimeSinceStartup / (60 * 60));
		minute = Mathf.FloorToInt( Time.realtimeSinceStartup / 60) - (hour * 60);
		second = (int) Time.realtimeSinceStartup - (minute * 60);

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
	//==== Functions ===\\
	//==================\\

	//Setting Global Texts
	void setTimeText (){
		timeText.text = hour.ToString () + ":" + minute.ToString () + ":" + second.ToString ();
	}

	void setScrapText (){
		scrapText.text = "Scrap: " + scrap.ToString ();
	}

	void setPopText (){
		popText.text = "Population: " + population.ToString ();
	}

	void setMoraleText (){
		moraleText.text = "Morale: " + morale.ToString ();
	}

	void setFoodText (){
		foodText.text = "Food: " + food.ToString ();
	}

	void setWaterText (){
		waterText.text = "Water: " + water.ToString ();
	}

	void setPowerText (){
		powerText.text = "Power: " + power.ToString ();
	}

	//==================\\
	//===== ON GUI =====\\
	//==================\\

	void OnGUI() {
		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 100, 100), buildIcon)) {
			print ("Build Icon clicked");
		}

		if (GUI.Button (new Rect (Screen.width / 2 - 200, Screen.height / 2 - 200, 100, 100), destroyIcon)) {
			print ("Destroy Icon clicked");
		}
	
		if (GUI.Button (new Rect (845, 10, 100, 100), "Build"))
			print (morale);

	
 	GUI.BeginGroup (new Rect (Screen.width -100, 0, 200, 200));
		GUILayout.Label ("FPS: " + fps.ToString ("f2"));
	GUI.EndGroup ();
	}
}