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
	
	public Image selectIcon;
	public Image stationGraphic;
	public Text stationName;
	
	public Button[] myButtons;
	public Sprite[] stationGraphics;
	public string[] stationNameTexts;
	
	public Canvas myCanvas;

	public Texture2D cursorTexture_default;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	public Image HUDBg;
	Image HUDDelBg;

	// === BUTTONS === \\
	//public Button[] buildBtnArray = new Button[1];
	
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
		BackgroundImageDel.transform.Translate (Screen.width / 2 + 192.5f, Screen.height / 2, 0);

		//TO CHANGE ALHPA BackgroundDel.CrossFadeAlpha (0.9f, 0, false);


		//===========================\\
		// === GLOBAL ATTRIBUTES === \\
		//===========================\\
		//Scrap
//		scrapIconDel = (Image)Instantiate (scrapIcon);
//		scrapIconDel.gameObject.transform.SetParent (myCanvas.gameObject.transform);
//
//		scrapIconDel.rectTransform.sizeDelta = new Vector2 (50, 50);
//		scrapIconDel.transform.Translate (((HUDDelBg.gameObject.transform.position.x) - 30), Screen.height - 42.5f, 0);
//
//			//Text
//			scrapDelText = (Text)Instantiate (scrapText);
//			scrapDelText.gameObject.transform.SetParent (myCanvas.gameObject.transform);
//			
//			scrapDelText.text = "";
//			scrapDelText.transform.position = new Vector2 (scrapIconDel.rectTransform.position.x + 62.5f,  scrapIconDel.rectTransform.position.y);
//			scrapDelText.rectTransform.sizeDelta = new Vector2 (200, 50);
	}

	//=================\\
	//=== Functions ===\\
	//=================\\
	public void selectMapIndex(int index){
		selectedMap = index;
	}

	//==================\\
	//===== Update =====\\
	//==================\\

	// Update is called once per frame
	// Update is called once per frame
	void Update () {
		switch (selectedMap){
		case 4:
			selectIcon.GetComponent<RectTransform>().localPosition = myButtons[selectedMap-3].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[selectedMap-3];
			stationName.text = stationNameTexts[selectedMap-3];
			break;
		default:
			selectIcon.GetComponent<RectTransform>().localPosition = myButtons[0].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[0];
			stationName.text = stationNameTexts[0];
			break;
		}
	}
}