using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class SquadSelectionScript : MonoBehaviour {
	PlayerData dataCopy;

	public List<serialAgent> population = new List<serialAgent>();

	//Settler Info
	public GameObject settlerList;
	public GameObject scrollableSettlerList;
	public Text numberOfSettlersInPopulation;
	public GameObject prefabSettler;
	public Image prefabSettlerPortrait;
	public Text prefabSettlerName;
	public Text prefabSettlerHealth;
	public Text prefabSettlerStats;

	//Squad Info
	public GameObject squadList;
	public GameObject[] MemberList = new GameObject[4];
	public Text numberOfSettlersInSquad;

	//Photos
	public Sprite[] malePortraitArray;
	public Sprite[] femalePortraitArray;

	public serialAgent [] myParty = new serialAgent [4];
	public Image [] myPartyPortraits = new Image [5];
	public Text [] myPartyNames = new Text [4];
	//Stats
	public Text [] myParty_STR_Stats = new Text [4];
	public Text [] myParty_PER_Stats = new Text [4];
	public Text [] myParty_AGL_Stats = new Text [4];
	//Squad Weapon
	public Image [] myPartyWeaponIcons = new Image [4];

	/*
	//Weapons Info
	public serialWeapon [] myWeapons = new serialWeapon [4];
	public Image [] myWeaponsIcons = new Image [4];
	public Text [] myWeaponsNames = new Text [4];
	//Stats
	public Text [] weapon_DMG_Stats = new Text[4];
	public Text[] weapon_RNG_Stats = new Text[4];
	public Text[] weapon_ACC_Stats = new Text[4];
	public Text[] weapon_SND_Stats = new Text[4];
	*/

	//Comparison variables
	public String[] AgentIDArray;
	public String[] AgentNameArray;

	bool [] numSet = {false, false, false, false};
	public int squadNumber = 0;
	string currId;

	public Button ventureBtn;

	float NumOfPopSettlers;
	int newSettlerListHeight;

	// Use this for initialization
	void Start () {
		loadPopulation ();
	}

	//Loading the settler list
	public void loadPopulation () {
		int index = 0;
		PlayerData loadedData = PlayerDataManager.playerDataManager.loadSaveData ();
		population = loadedData.population;

		foreach (serialAgent sA in population) {
			//Settler
			GameObject settler = (GameObject) Instantiate (prefabSettler);
			settler.gameObject.transform.SetParent (scrollableSettlerList.gameObject.transform);
			settler.transform.localScale = new Vector3 (1, 1, 1);

			settler.name = sA.agentName;
			GameObject tempSettler = settler.GetComponent <GameObject>();

			//Portrait
			Image settlerPortrait = settler.GetComponent<Image>();
			settlerPortrait.gameObject.transform.SetParent (settler.gameObject.transform);

			settlerPortrait.transform.localScale = new Vector3 (1, 1, 1);

			Image[] tempImgs = settler.GetComponentsInChildren<Image>();

			foreach (Image img in tempImgs) {
				if (img.gameObject.name == "Settler Portrait") {
					Image tempSettlerPortrait = img;
					if (sA.gender == "Male") {
						tempSettlerPortrait.sprite = malePortraitArray [sA.photo];
					} else {
						tempSettlerPortrait.sprite = femalePortraitArray [sA.photo];
					}
				}
			}

			Text[] childTexts = settler.GetComponentsInChildren<Text>();

			Text settlerName, settlerHealth, settlerStats;
			//Name
			foreach (Text cT in childTexts ){
				if (cT.gameObject.name == "Settler Name") {
					settlerName = cT;
					settlerName.gameObject.transform.SetParent (settler.gameObject.transform);
					
					settlerName.transform.localScale = new Vector3 (1, 1, 1);
					settlerName.text = sA.agentName;
					
					Image tempSettlerName = settlerName.GetComponent <Image>();
				} 
				if (cT.gameObject.name == "Settler Health") {
					settlerHealth = cT;
					settlerHealth.gameObject.transform.SetParent (settler.gameObject.transform);
					
					settlerHealth.transform.localScale = new Vector3 (1, 1, 1);
					settlerHealth.text = (sA.health / 10).ToString () + "/10";
					
					Text tempSettlerHealth = settlerPortrait.GetComponent <Text>();
				} 
				if (cT.gameObject.name == "Settler Stats") {
					settlerStats = cT;
					settlerStats.gameObject.transform.SetParent (settler.gameObject.transform);
					
					settlerStats.transform.localScale = new Vector3 (1, 1, 1);
					settlerStats.text = sA.strength + " " + sA.perception + " " + sA.agility;
					
					Text tempSettlerStats = settlerStats.GetComponent <Text>();
				}
			}
		}

		Destroy (prefabSettler);
	}

	void Update () {
		int partyIndex = 0;
		foreach (serialAgent partyMember in myParty) {
			if (partyMember.agentId != "" && partyMember.agentId != "-1") {
				numSet [partyIndex] = true;
			}
			if (partyMember.agentId == "-1") {
				numSet [partyIndex] = false;
			}
			partyIndex++;
		}
		squadNumber = 0;
		foreach (bool i in numSet) {
			if (i == true) {
				squadNumber++;
			}
		}

		numberOfSettlersInPopulation.text = "Settler List (" + scrollableSettlerList.transform.childCount + ")";		
		numberOfSettlersInSquad.text = ("Squad " + squadNumber) + "/4";

		RectTransform thisBeMyTransform = scrollableSettlerList.transform.GetChild(0).GetComponent<RectTransform> ();
		NumOfPopSettlers = scrollableSettlerList.transform.childCount * Math.Abs (thisBeMyTransform.sizeDelta.y) + (scrollableSettlerList.transform.childCount * scrollableSettlerList.GetComponent<GridLayoutGroup>().spacing.y);
		float subtractThisAmount = (float)(Math.Abs (scrollableSettlerList.GetComponent<RectTransform> ().rect.y) / 1.85);
		scrollableSettlerList.GetComponent<RectTransform> ().sizeDelta = new Vector2 (thisBeMyTransform.sizeDelta.x, NumOfPopSettlers - subtractThisAmount);
	}
}

[Serializable]
public class tempAgent {
	public string name;
	public int movement;
	public int attack;
	public int perception;	
}