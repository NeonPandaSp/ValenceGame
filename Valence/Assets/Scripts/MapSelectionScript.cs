using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MapSelectionScript : MonoBehaviour {
	//HUD Variables
	//GameObject globalAttributes;
	public int selectedMap = 0;
	
	public Canvas MapSelectCanvas;

	public Text stationName;
	public Image stationGraphic;
	public Image LeftPanelSwitch;

	public Image selectIcon;

	public Button[] myButtons;
	public Sprite[] stationGraphics;
	public string[] stationNameTexts;
	public Sprite[] leftPanelBackgrounds;
	
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
	void Update () {
		switch (selectedMap){
		case 4:
			selectIcon.GetComponent<RectTransform>().localPosition = myButtons[1].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[1];
			stationName.text = stationNameTexts[1];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[1];
			break;
		case 5:
			selectIcon.GetComponent<RectTransform>().localPosition = myButtons[2].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[2];
			stationName.text = stationNameTexts[2];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[2];
			break;
		case 6:
			selectIcon.GetComponent<RectTransform>().localPosition = myButtons[3].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[3];
			stationName.text = stationNameTexts[3];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[3];
			break;
		case 7:
			selectIcon.GetComponent<RectTransform>().localPosition = myButtons[4].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[4];
			stationName.text = stationNameTexts[4];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[4];
			break;
		case 8:
			selectIcon.GetComponent<RectTransform>().localPosition = myButtons[5].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[5];
			stationName.text = stationNameTexts[5];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[5];
			break;
		case 9:
			selectIcon.GetComponent<RectTransform>().localPosition = myButtons[6].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[6];
			stationName.text = stationNameTexts[6];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[6];
			break;
		default:
			selectIcon.GetComponent<RectTransform>().localPosition = myButtons[0].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[0];
			stationName.text = stationNameTexts[0];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[0];
			break;
		}
	}
}