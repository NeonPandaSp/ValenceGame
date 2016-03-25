using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class SquadSelectionScript : MonoBehaviour {
	PlayerData dataCopy;

	public List<serialAgent> population = new List<serialAgent>();

	public Image backgroundSelectSettler;
	public Image backgroundSelectWeapons;

	public List<Button> squadButtons;
	public List<Button> weaponButtons;
	public List<Button> settlerWeaponsButtons;

	//Squad Info
	public serialAgent [] myParty = new serialAgent [4];
	public Image [] myPartyPortraits = new Image [5];
	public Text [] myPartyNames = new Text [4];
	//Stats
	public Text [] myParty_STR_Stats = new Text [4];
	public Text [] myParty_PER_Stats = new Text [4];
	public Text [] myParty_AGL_Stats = new Text [4];

	public Image [] myPartyWeaponIcons = new Image [4];

	//Photos
	public Sprite[] malePortraitArray;
	public Sprite[] femalePortraitArray;

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

	public int selectedPartyIndex;
	public bool noneSelected;

	public int rowIndex = 0;
	public int numSet = 0;

	public GameObject settlerList;
	public GameObject prefabSettler;
	public Image prefabSettlerPortrait;
	public Text prefabSettlerName;
	public Text prefabSettlerHealth;
	public Text prefabSettlerStats;


	// Use this for initialization
	void Start () {
		rowIndex = 0;
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
			settler.gameObject.transform.SetParent (settlerList.gameObject.transform);
			settler.transform.localScale = new Vector3 (1, 1, 1);

			settler.name = sA.agentName;
			GameObject tempSettler = settler.GetComponent <GameObject>();

			//Portrait
			Image settlerPortrait = (Image) Instantiate (prefabSettlerPortrait);
			settlerPortrait.gameObject.transform.SetParent (settler.gameObject.transform);

			settlerPortrait.transform.localScale = new Vector3 (1, 1, 1);

			if (sA.gender == "Male") {
				settlerPortrait.sprite = malePortraitArray [sA.photo];
			} else {
				settlerPortrait.sprite = femalePortraitArray [sA.photo];
			}

			Image tempSettlerPortrait = settlerPortrait.GetComponent <Image>();

			//Name
			Text settlerName = (Text) Instantiate (prefabSettlerName);
			settlerName.gameObject.transform.SetParent (settler.gameObject.transform);

			settlerName.transform.localScale = new Vector3 (1, 1, 1);
			settlerName.text = sA.agentName;
			
			Image tempSettlerName = settlerName.GetComponent <Image>();

			//Health
			Text settlerHealth = (Text) Instantiate (prefabSettlerHealth);
			settlerHealth.gameObject.transform.SetParent (settler.gameObject.transform);

			settlerHealth.transform.localScale = new Vector3 (1, 1, 1);
			settlerHealth.text = sA.health.ToString () + "/10";
			
			Text tempSettlerHealth = settlerPortrait.GetComponent <Text>();

			//Stats
			Text settlerStats = (Text) Instantiate (prefabSettlerStats);
			settlerStats.gameObject.transform.SetParent (settler.gameObject.transform);

			settlerStats.transform.localScale = new Vector3 (1, 1, 1);
			settlerStats.text = sA.agentName;
			
			Text tempSettlerStats = settlerStats.GetComponent <Text>();
		}

		Destroy (prefabSettler);

		//Creating static settler buttons the old way
//		for (int i = index; i < index + settlerWeaponsButtons.Count; i++) {
//			if (i <= population.Count - 1)
//				settlerWeaponsButtons[i].GetComponentInChildren <Text>().text = population[i].agentName;
//			else {
//				settlerWeaponsButtons[i].GetComponentInChildren <Text>().text = "NA";
//				settlerWeaponsButtons[i].interactable = false;
//			}
//		}
	}

	//Setting a squad member
	public void setPartyMember (int index) {
		bool inParty = false;
		foreach (serialAgent sA in myParty) {
			if (sA.agentId ==  population [(rowIndex * settlerWeaponsButtons.Count) + index].agentId) {
				inParty = true;
			}
		}

		if (!noneSelected && !inParty) {
			//Set Party UI Assets to selected Agent from population
			myParty [selectedPartyIndex] = population [(rowIndex * settlerWeaponsButtons.Count) + index];

			//myPartyImageIcons [selectedPartyIndex].sprite = malePortraitArray;
			if (population [(rowIndex * settlerWeaponsButtons.Count) + index].gender == "Male") {

				myPartyPortraits[selectedPartyIndex].sprite = malePortraitArray [population [(rowIndex * settlerWeaponsButtons.Count) + index].photo];
			} else {
				myPartyPortraits[selectedPartyIndex].sprite = femalePortraitArray [population [(rowIndex * settlerWeaponsButtons.Count) + index].photo];
			}

//			for (int i = 0; i < population.Count; i++) {
//				Debug.Log ("Settler " + population[(rowIndex * settlerWeaponsButtons.Count) + index].agentId +"'s photo is: " + population [(rowIndex * settlerWeaponsButtons.Count) + index].photo);
//			}

			myPartyNames [selectedPartyIndex].text = population [(rowIndex * settlerWeaponsButtons.Count) + index].agentName;
			myParty_AGL_Stats [selectedPartyIndex].text = "" + population [(rowIndex*settlerWeaponsButtons.Count) + index].agility;
			myParty_PER_Stats [selectedPartyIndex].text = "" + population [(rowIndex*settlerWeaponsButtons.Count) + index].perception;
			myParty_STR_Stats [selectedPartyIndex].text = "" + population [(rowIndex*settlerWeaponsButtons.Count) + index].strength;

			//Reset Selection Variables
			selectedPartyIndex = - 1;
			noneSelected = true;
			if (numSet < 4) {
				numSet++;
			}
		}

		for (int i = 0; i < weaponButtons.Count - 1; i++) {
			weaponButtons [i].interactable = true;
		}
	}

	//Setting a weapon
	public void setWeapon (int index) {
		for (int i = 0; i < squadButtons.Count - 1; i++) {
			squadButtons [i].interactable = true;
		}
	}

	//Previous Button
	public void shiftLeft(){
		rowIndex--;
		if (rowIndex < 0)
			rowIndex = 0;
		int index = rowIndex * settlerWeaponsButtons.Count;
		int butDex = 0;
		for (int i = index; i < index + settlerWeaponsButtons.Count; i++) {
			if (i < population.Count)
				settlerWeaponsButtons[butDex].GetComponentInChildren <Text> ().text = population[i].agentName;
			butDex++;
		}
	}

	//Next Button
	public void shiftRight(){
		rowIndex++;
		if (rowIndex * settlerWeaponsButtons.Count > population.Count)
			rowIndex = population.Count/settlerWeaponsButtons.Count;
		int index = rowIndex * settlerWeaponsButtons.Count;
		int butDex = 0;
		for (int i = index; i < index + settlerWeaponsButtons.Count; i++) {
			if (i < population.Count)
				settlerWeaponsButtons[butDex].GetComponentInChildren <Text> ().text = population[i].agentName;
			else
				settlerWeaponsButtons[butDex].GetComponentInChildren <Text> ().text = "NA";
			butDex++;
		}
	}
}

[Serializable]
public class tempAgent {
	public string name;
	public int movement;
	public int attack;
	public int perception;	
}