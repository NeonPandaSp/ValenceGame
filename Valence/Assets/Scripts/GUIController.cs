using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GUIController : MonoBehaviour {
	public InputController _inputController;
	public GameObject GUIObject;

	public Text scrapText, popText, moraleText, foodText, waterText, powerText;
	//public Button shelterButton, foodButton, powerButton;

	Vector2 lastMousePos;

	public int scrap, population;
	public float morale, food, water, power;

	// Use this for initialization
	void Start () {
		scrap = 0;
		population = 0;
		morale = 100.0f;
		food = 0;
		water = 0;
		power = 0;

		setScrapText ();
		setPopText ();
		setMoraleText ();
		setFoodText ();
		setWaterText ();
		setPowerText ();

		lastMousePos = Input.mousePosition;
	}

	// Update is called once per frame
	void Update () {
		scrap++;
		population++;
		morale--;
		food--;
		water++;
		power++;

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
	}

	//Setting Global Texts
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
		foodText.text = "Hunger: " + food.ToString ();
	}

	void setWaterText (){
		waterText.text = "Water: " + water.ToString ();
	}

	void setPowerText (){
		powerText.text = "Power: " + power.ToString ();
	}

	/*
	public void shelterPressed(){
		_inputController.selectedMaterial ("blue");
		Debug.Log ("Green!");
	}
	public void foodPressed(){
		_inputController.selectedMaterial ("green");
	}
	public void powerPressed(){
		_inputController.selectedMaterial ("yellow");
	}
	*/

		void OnGUI() {
		if (GUI.Button (new Rect (845, 10, 100, 100), "CLICK ME!"))
			print (morale);

		DateTime time = DateTime.Now;
		String hour = time.Hour.ToString().PadLeft(2, '0');
		String minute = time.Minute.ToString().PadLeft(2, '0');
		string second = time.Second.ToString().PadLeft(2, '0');
		
		GUILayout.Label(hour +":"+ minute +":"+ second);
	}
}
