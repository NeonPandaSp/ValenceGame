using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class SquadSelectionScript : MonoBehaviour {
	PlayerData dataCopy;

	public List<serialAgent> population = new List<serialAgent>();

	public List<Button> buttons;

	public GameObject settlerList;
	//public GameObject weaponsList;

	public serialAgent[] myParty = new serialAgent[4];

	public Image[] myPartyImageIcons = new Image[4];

	public Text[] myPartyNames = new Text[4];

	//Stats of Squad members
	public Text[] myParty_STR_Stats = new Text[4];
	public Text[] myParty_PER_Stats = new Text[4];
	public Text[] myParty_AGL_Stats = new Text[4];

	public Image[] myPartyWeapon = new Image[4];

	/*
	//Stats of the Settlers in the Population
	public Text[] settler_STR_Stats = new Text[4];
	public Text[] settler_PER_Stats = new Text[4];
	public Text[] settler_AGL_Stats = new Text[4];

	//Stats of Weapons in Inventory
	public Text[] weapon_DMG_Stats = new Text[4];
	public Text[] weapon_RNG_Stats = new Text[4];
	public Text[] weapon_ACC_Stats = new Text[4];
	*/

	public int selectedPartyIndex;
	public bool noneSelected;

	public int rowIndex = 0;
	public int numSet = 0;

	// Use this for initialization
	void Start () {
		rowIndex = 0;
		loadPopulation ();
		enableSettlerListPanel (false);
	}
	
	// Update is called once per frame
	void Update () {	
	}

	public void loadPopulation(){
		int index = 0;
		PlayerData loadedData = PlayerDataManager.playerDataManager.loadSaveData ();
		population = loadedData.population;
		for (int i = index; i < index + buttons.Count; i++) {
			if (i <= population.Count - 1)
				buttons[i].GetComponentInChildren<Text>().text = population[i].agentName;
			else {
				buttons[i].GetComponentInChildren<Text>().text = "NA";
				buttons[i].interactable = false;
			}
		}
	}

	public void shiftLeft(){
		rowIndex--;
		if (rowIndex < 0)
			rowIndex = 0;
		int index = rowIndex * buttons.Count;
		int butDex = 0;
		for (int i = index; i < index + buttons.Count; i++) {
			if (i < population.Count)
				buttons[butDex].GetComponentInChildren <Text> ().text = population[i].agentName;
			butDex++;
		}
	}
	public void shiftRight(){
		rowIndex++;
		if (rowIndex * buttons.Count > population.Count)
			rowIndex = population.Count/buttons.Count;
		int index = rowIndex * buttons.Count;
		int butDex = 0;
		for (int i = index; i < index + buttons.Count; i++) {
			if (i < population.Count)
				buttons[butDex].GetComponentInChildren <Text> ().text = population[i].agentName;
			else
				buttons[butDex].GetComponentInChildren <Text> ().text = "NA";
			butDex++;
		}
	}

	public void setSelectedPartyIndex (int index) {
		Debug.Log ("SetSelectedPartyIndex Called");
		selectedPartyIndex = index;
		noneSelected = false;
		enableSettlerListPanel (true);
	}

	public void enableSettlerListPanel (bool on) {
		if (on && !settlerList.gameObject.activeSelf) {
			settlerList.gameObject.SetActive (true);
			loadPopulation ();
		} else {
			settlerList.gameObject.SetActive (false);
		}
	}

	public void setPartyMember (int index) {
		Debug.Log ("setPartyMember called");
		bool inParty = false;
		foreach (serialAgent sA in myParty) {
			if (sA.agentId ==  population [(rowIndex * buttons.Count) + index].agentId) {
				inParty = true;
			}
		}

		enableSettlerListPanel (false);

		if (!noneSelected && !inParty) {
			Debug.Log ("setPartyMember called");
			//Set Party UI Assets to selected Agent from population
			myParty [selectedPartyIndex] = population [(rowIndex * buttons.Count) + index];
			myPartyNames [selectedPartyIndex].text = population [(rowIndex * buttons.Count) + index].agentName;
			myParty_AGL_Stats[selectedPartyIndex].text = "" + population[(rowIndex*buttons.Count)+index].agility;
			myParty_PER_Stats[selectedPartyIndex].text = "" + population[(rowIndex*buttons.Count)+index].perception;
			myParty_STR_Stats[selectedPartyIndex].text = "" + population[(rowIndex*buttons.Count)+index].strength;
			//Reset Selection Variables
			selectedPartyIndex = -1;
			noneSelected = true;
			enableSettlerListPanel (false);
			if( numSet < 4 )
				numSet++;
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