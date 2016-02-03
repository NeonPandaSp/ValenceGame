using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MapSelectionScript : MonoBehaviour {
	int selectedMap = 0;
	
	public Image selectIcon;
	public Image stationGraphic;
	public Text stationName;

	public Button[] myButtons;
	public Sprite[] stationGraphics;
	public string[] stationNameTexts;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		switch (selectedMap)
		{
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

	public void selectMapIndex(int index){
		selectedMap = index;
	}
}
