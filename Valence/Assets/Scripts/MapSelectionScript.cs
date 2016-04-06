using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MapSelectionScript : MonoBehaviour {
	public int selectedMap = 0;
	
	public Canvas MapSelectCanvas;

	public Image LeftPanelSwitch;

	public int scrapRate;
	public int recruitRate;
	public int weaponRate;

	public Image[] scrapRateIcons;
	public Image[] weaponsRateIcons;
	public Image[] recruitsRateIcons;

	public Image selectIcon;

	public Button[] stationIcons;

	public Sprite[] stationGraphics;
	public Sprite[] leftPanelBackgrounds;

	public Texture2D cursorTexture;
	public Vector2 cursorHotspot = Vector2.zero;
		
	public Button proceedButton;
	//=================\\
	//===== Start =====\\
	//=================\\

	// Use this for initialization
	void Start () {
		Cursor.SetCursor (cursorTexture, cursorHotspot, CursorMode.Auto);

		selectedMap = 2; 

		scrapRate = 0;
		recruitRate = 0;
		weaponRate = 0;
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

		selectIcon.transform.Rotate (0, 0, -2);

		//Note: The scrap values have been set 2, 4, 6, which rougly translate to 100, 200, 300

		switch (selectedMap){
			//THE SETTLEMENT
		default:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[0].GetComponent<RectTransform>().localPosition;
			selectIcon.rectTransform.sizeDelta = new Vector2 (140, 140);
			selectIcon.color = new Color (184/ 255f, 253 / 255f, 106/255f, 255 / 255f);
			LeftPanelSwitch.sprite = leftPanelBackgrounds[0];
			proceedButton.GetComponentInChildren<Text> ().text = "Return Home";
			scrapRate = 0;
			recruitRate = 0;
			weaponRate = 0;
		break;
			//RAILS STAION
		case 4:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[1].GetComponent<RectTransform>().localPosition;
			selectIcon.rectTransform.sizeDelta = new Vector2 (100, 100);
			selectIcon.color = new Color (253/ 255f, 106 / 255f, 106/255f, 255 / 255f);
			LeftPanelSwitch.sprite = leftPanelBackgrounds[1];
			proceedButton.GetComponentInChildren<Text> ().text = "Travel";
			scrapRate = 4;
			recruitRate = 5;
			weaponRate = 6;
		break;
			//CARGO STATION
		case 5:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[2].GetComponent<RectTransform>().localPosition;
			selectIcon.rectTransform.sizeDelta = new Vector2 (100, 100);
			selectIcon.color = new Color (253/ 255f, 106 / 255f, 106/255f, 255 / 255f);
			LeftPanelSwitch.sprite = leftPanelBackgrounds[2];
			proceedButton.GetComponentInChildren<Text> ().text = "Travel";
			scrapRate = 2;
			recruitRate = 3;
			weaponRate = 5;
		break;
			//SHORE STATION
		case 6:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[3].GetComponent<RectTransform>().localPosition;
			selectIcon.rectTransform.sizeDelta = new Vector2 (100, 100);
			selectIcon.color = new Color (253/ 255f, 106 / 255f, 106/255f, 255 / 255f);
			LeftPanelSwitch.sprite = leftPanelBackgrounds[3];
			proceedButton.GetComponentInChildren<Text> ().text = "Travel";
			scrapRate = 6;
			recruitRate = 5;
			weaponRate = 9;
		break;
			//RELAY STATION
		case 7:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[4].GetComponent<RectTransform>().localPosition;
			selectIcon.rectTransform.sizeDelta = new Vector2 (100, 100);
			selectIcon.color = new Color (253/ 255f, 106 / 255f, 106/255f, 255 / 255f);
			LeftPanelSwitch.sprite = leftPanelBackgrounds[4];
			proceedButton.GetComponentInChildren<Text> ().text = "Travel";
			scrapRate = 6;
			recruitRate = 5;
			weaponRate = 4;
		break;
			//GLADIATOR STATION
		case 8:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[5].GetComponent<RectTransform>().localPosition;
			selectIcon.color = new Color (253/ 255f, 106 / 255f, 106/255f, 255 / 255f);
			LeftPanelSwitch.sprite = leftPanelBackgrounds[5];
			proceedButton.GetComponentInChildren<Text> ().text = "Travel";
			scrapRate = 4;
			recruitRate = 3;
			weaponRate = 3;
		break;
			//OUTPOST STATION
		case 9:
			selectIcon.GetComponent<RectTransform>().localPosition = stationIcons[6].GetComponent<RectTransform>().localPosition;
			selectIcon.rectTransform.sizeDelta = new Vector2 (100, 100);
			selectIcon.color = new Color (253/ 255f, 106 / 255f, 106/255f, 255 / 255f);
			LeftPanelSwitch.sprite = leftPanelBackgrounds[6];
			proceedButton.GetComponentInChildren<Text> ().text = "Travel";
			scrapRate = 6;
			recruitRate = 5;
			weaponRate = 6;
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