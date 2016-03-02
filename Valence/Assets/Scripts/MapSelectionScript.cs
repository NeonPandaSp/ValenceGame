using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MapSelectionScript : MonoBehaviour {
	//HUD Variables
	//GameObject globalAttributes;
	int selectedMap = 0;
	
	public Canvas MapSelectCanvas;
	
	public Image BackgroundImage;
	Image BackgroundImageDel;

	public Text stationName;
	Text stationNameDel;

	public Image stationGraphic;
	Image stationGraphicDel;

	public string setStation;

	public Button stnHomeBtn, stn1Btn, stn2Btn, stn3Btn, stn4Btn, stn5Btn, stn6Btn;
	Button stnHomeBtnDel, stn1BtnDel, stn2BtnDel, stn3BtnDel, stn4BtnDel, stn5BtnDel, stn6BtnDel;
	
	//public Image selectIcon;

	public Button[] myButtons;
	public Sprite[] stationGraphics;
	public string[] stationNameTexts;
	
	public Texture2D cursorTexture_default;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	//=================\\
	//===== Start =====\\
	//=================\\

	// Use this for initialization
	void Start () {
		//cursorTexture_default.Resize (9, 11);
		Cursor.SetCursor(cursorTexture_default, hotSpot, CursorMode.Auto);

		// === HUD Background ===\\
		BackgroundImageDel = (Image)Instantiate (BackgroundImage);
		BackgroundImageDel.gameObject.transform.SetParent (MapSelectCanvas.gameObject.transform);
		
		BackgroundImageDel.rectTransform.sizeDelta = new Vector2 (1920, 1080);
		BackgroundImageDel.transform.Translate (Screen.width / 2 + 192.5f, Screen.height / 2 + 300, 0);
		//BackgroundImageDel.gameObject.SetActive (false);

		//TO CHANGE ALHPA BackgroundDel.CrossFadeAlpha (0.9f, 0, false);

		//========================\\
		//=== SELECTED STATION ===\\
		//========================\\

		//Station Name
		stationNameDel = (Text)Instantiate (stationName);
		stationNameDel.gameObject.transform.SetParent (MapSelectCanvas.gameObject.transform);
		
		stationNameDel.text = "";
		stationNameDel.fontSize = 40;
		stationNameDel.transform.position = new Vector2 (110, Screen.height - 60);

		//Station Graphic
		stationGraphicDel = (Image)Instantiate (stationGraphic);
		stationGraphicDel.gameObject.transform.SetParent (MapSelectCanvas.gameObject.transform);
		
		stationGraphicDel.rectTransform.sizeDelta = new Vector2 (50, 50);
		stationGraphicDel.transform.Translate (110, stationNameDel.rectTransform.position.y - 250, 0);
	
		//================\\
		//=== STATIONS ===\\
		//================\\

		//Home Station
		stnHomeBtnDel = (Button)Instantiate (stnHomeBtn);
		stnHomeBtnDel.gameObject.transform.SetParent (MapSelectCanvas.gameObject.transform);
		
		stnHomeBtnDel.GetComponentInChildren<Text> ().text = "";
		stnHomeBtnDel.transform.position = new Vector2 (694, 582.8f);
		stnHomeBtnDel.image.rectTransform.sizeDelta = new Vector2 (42, 42);
		stnHomeBtnDel.onClick.AddListener (() => switchStation ("home"));
		stnHomeBtnDel.gameObject.SetActive (true);
		
		//stnHomeClicked = false;

		//Station 1
		stn1BtnDel = (Button)Instantiate (stn1Btn);
		stn1BtnDel.gameObject.transform.SetParent (MapSelectCanvas.gameObject.transform);
		
		stn1BtnDel.GetComponentInChildren<Text> ().text = "";
		stn1BtnDel.transform.position = new Vector2 (663.1f, 977.9f);
		stn1BtnDel.image.rectTransform.sizeDelta = new Vector2 (42, 42);
		stn1BtnDel.onClick.AddListener (() => switchStation ("stn1"));
		stn1BtnDel.gameObject.SetActive (true);
		
		//stn1Clicked = false;

		//Station 2
		stn2BtnDel = (Button)Instantiate (stn2Btn);
		stn2BtnDel.gameObject.transform.SetParent (MapSelectCanvas.gameObject.transform);
		
		stn2BtnDel.GetComponentInChildren<Text> ().text = "";
		stn2BtnDel.transform.position = new Vector2 (1222.6f, 817.4f);
		stn2BtnDel.image.rectTransform.sizeDelta = new Vector2 (42, 42);
		stn2BtnDel.onClick.AddListener (() => switchStation ("stn2"));
		stn2BtnDel.gameObject.SetActive (true);
		
		//stn2Clicked = false;

		//Station 3
		stn3BtnDel = (Button)Instantiate (stn3Btn);
		stn3BtnDel.gameObject.transform.SetParent (MapSelectCanvas.gameObject.transform);
		
		stn3BtnDel.GetComponentInChildren<Text> ().text = "";
		stn3BtnDel.transform.position = new Vector2 (1594.5f, 850.4f);
		stn3BtnDel.image.rectTransform.sizeDelta = new Vector2 (42, 42);
		stn3BtnDel.onClick.AddListener (() => switchStation ("stn3"));
		stn3BtnDel.gameObject.SetActive (true);
		
		//stn3Clicked = false;

		//Station 4
		stn4BtnDel = (Button)Instantiate (stn4Btn);
		stn4BtnDel.gameObject.transform.SetParent (MapSelectCanvas.gameObject.transform);
		
		stn4BtnDel.GetComponentInChildren<Text> ().text = "";
		stn4BtnDel.transform.position = new Vector2 (1627.4f, 510.8f);
		stn4BtnDel.image.rectTransform.sizeDelta = new Vector2 (42, 42);
		stn4BtnDel.onClick.AddListener (() => switchStation ("stn4"));
		stn4BtnDel.gameObject.SetActive (true);
		
		//stn4Clicked = false;

		//Station 5
		stn5BtnDel = (Button)Instantiate (stn5Btn);
		stn5BtnDel.gameObject.transform.SetParent (MapSelectCanvas.gameObject.transform);
		
		stn5BtnDel.GetComponentInChildren<Text> ().text = "";
		stn5BtnDel.transform.position = new Vector2 (778, 150.2f);
		stn5BtnDel.image.rectTransform.sizeDelta = new Vector2 (42, 42);
		stn5BtnDel.onClick.AddListener (() => switchStation ("stn5"));
		stn5BtnDel.gameObject.SetActive (true);
		
		//stn5Clicked = false;

		//Station 6
		stn6BtnDel = (Button)Instantiate (stn6Btn);
		stn6BtnDel.gameObject.transform.SetParent (MapSelectCanvas.gameObject.transform);
		
		stn6BtnDel.GetComponentInChildren<Text> ().text = "";
		stn6BtnDel.transform.position = new Vector2 (694, 582.8f);
		stn6BtnDel.image.rectTransform.sizeDelta = new Vector2 (42, 42);
		stn6BtnDel.onClick.AddListener (() => switchStation ("stn6"));
		stn6BtnDel.gameObject.SetActive (true);
	}

	//=================\\
	//=== Functions ===\\
	//=================\\
	public void selectMapIndex(int index){
		selectedMap = index;
	}

	void switchStation (string s) {
		switch (s) {
		case "home":
			setStation = "Home";
			break;
		case "stn1":
			setStation = "Station 1";
			break;
		case "stn2":
			setStation = "Station 2";
			break;
		case "stn3":
			setStation = "Station 3";
			break;
		case "stn4":
			setStation = "Station 4";
			break;
		case "stn5":
			setStation = "Station 5";
			break;
		case "stn6":
			setStation = "Station 6";
			break;
		default:
			setStation = "Null";
			break;
		}
	}

	//==================\\
	//===== Update =====\\
	//==================\\
	void Update () {
		//switch (selectedMap){
		//case 4:
			//selectIcon.GetComponent<RectTransform>().localPosition = myButtons[selectedMap-3].GetComponent<RectTransform>().localPosition;
			//stationGraphic.sprite = stationGraphics[selectedMap-3];
			//stationName.text = stationNameTexts[selectedMap-3];
			//break;
		//default:
			//selectIcon.GetComponent<RectTransform>().localPosition = myButtons[0].GetComponent<RectTransform>().localPosition;
			//stationGraphic.sprite = stationGraphics[0];
			//stationName.text = "will be changed in next committ"; //stationNameTexts[0];
			//break;
		//}
	}
}