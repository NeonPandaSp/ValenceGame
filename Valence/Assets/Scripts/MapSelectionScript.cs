using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MapSelectionScript : MonoBehaviour {
	public int selectedMap = 0;
	
	public Canvas MapSelectCanvas;

	public Text stationName;
	public Image stationGraphic;
	public Image LeftPanelSwitch;

	public int scrapRate;
	public int recruitRate;
	public int weaponRate;

	public Image[] scrapRateIcons;
	public Image[] weaponsRateIcons;
	public Image[] recruitsRateIcons;

	public Image selectIcon;

	public Button[] stationIcons;
	public Image stationLine_Blue;
	public Image stationLine_Green;
	public Image stationLine_Orange;
	public Image stationLine_Yellow;

	public string[] stationNameTexts;
	public Sprite[] stationGraphics;
	public Sprite[] leftPanelBackgrounds;
	
	public Texture2D cursorTexture;
	public Vector2 cursorHotspot = Vector2.zero;

	//=================\\
	//===== Start =====\\
	//=================\\

	// Use this for initialization
	void Start () {
		Cursor.SetCursor (cursorTexture, cursorHotspot, CursorMode.Auto);

		selectedMap = 2; 

		scrapRate = 5;
		recruitRate = 3;
		weaponRate = 4;
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
		//Map Selection
		switch (selectedMap){
		case 4:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[1].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[1];
			stationName.text = stationNameTexts[1];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[1];
			break;
		case 5:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[2].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[2];
			stationName.text = stationNameTexts[2];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[2];
			break;
		case 6:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[3].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[3];
			stationName.text = stationNameTexts[3];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[3];
			break;
		case 7:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[4].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[4];
			stationName.text = stationNameTexts[4];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[4];
			break;
		case 8:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[5].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[5];
			stationName.text = stationNameTexts[5];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[5];
			break;
		case 9:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[6].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[6];
			stationName.text = stationNameTexts[6];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[6];
			break;
		default:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[0].GetComponent<RectTransform>().localPosition;
			stationGraphic.sprite = stationGraphics[0];
			stationName.text = stationNameTexts[0];
			LeftPanelSwitch.sprite = leftPanelBackgrounds[0];
			break;
		}
		//stationIcons[0].GetComponent<RectTransform>().localPosition;
		//new Vector2 (1900, 100);

		//Scrap Reward Rate
		for (int i = 0; i < 10; i++){
			if (i <= (scrapRate - 1)){
				scrapRateIcons[i].CrossFadeAlpha (1.0f, 0, false);
			}
			else{
				scrapRateIcons[i].CrossFadeAlpha (0.0f, 0, false);
			}
		}

		//Weapons Reward Rate
		for (int i = 0; i < 10; i++){
			if (i <= (weaponRate - 1)){
				weaponsRateIcons[i].CrossFadeAlpha (1.0f, 0, false);
			}
			else{
				weaponsRateIcons[i].CrossFadeAlpha (0.0f, 0, false);
			}
		} 
		
		//Recruits Reward Rate
		for (int i = 0; i < 10; i++){
			if (i <= (recruitRate - 1)){
				recruitsRateIcons[i].CrossFadeAlpha (1.0f, 0, false);
			}
			else{
				recruitsRateIcons[i].CrossFadeAlpha (0.0f, 0, false);
			}
		}
	}
}