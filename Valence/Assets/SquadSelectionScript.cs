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

	public GameObject popSelection;

	public serialAgent[] myParty = new serialAgent[4];

	public Image[] myPartyImageIcons = new Image[4];

	public Text[] myPartyNames = new Text[4];

	public Text[] myParty_STR_Stats = new Text[4];
	public Text[] myParty_PER_Stats = new Text[4];
	public Text[] myParty_AGL_Stats = new Text[4];

	public Image[] myPartyWeapon = new Image[4];

	public int selectedPartyIndex;
	public bool noneSelected;

	public int rowIndex = 0;
	public int numSet = 0;

	// Use this for initialization
	void Start () {
		rowIndex = 0;
		loadPopulation ();
		enablePopulationPanel(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadPopulation(){
		int index = 0;
		PlayerData loadedData = PlayerDataManager.playerDataManager.loadSaveData ();
		population = loadedData.population;
		for(int i = index; i < index + buttons.Count; i++) {
			if( i <= population.Count-1)
				buttons[i].GetComponentInChildren<Text>().text = population[i].agentName;
			else{
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
		for(int i = index; i < index + buttons.Count; i++) {
			if( i < population.Count )
				buttons[butDex].GetComponentInChildren<Text>().text = population[i].agentName;
			butDex++;
		}
	}
	public void shiftRight(){
		rowIndex++;
		if (rowIndex * buttons.Count > population.Count)
			rowIndex = population.Count/buttons.Count;
		int index = rowIndex * buttons.Count;
		int butDex = 0;
		for(int i = index; i < index + buttons.Count; i++) {
			if( i < population.Count )
				buttons[butDex].GetComponentInChildren<Text>().text = population[i].agentName;
			else
				buttons[butDex].GetComponentInChildren<Text>().text = "NA";
			butDex++;
		}
	}

	public void setSelectedPartyIndex(int index){
		Debug.Log ("SetSelectedPartyIndex Called");
		selectedPartyIndex = index;
		noneSelected = false;
		enablePopulationPanel (true);
	}

	public void enablePopulationPanel(bool on){
		if (on && !popSelection.gameObject.activeSelf) {
			popSelection.gameObject.SetActive (true);
			loadPopulation();
		} else {
			popSelection.gameObject.SetActive (false);
		}
	}

	public void setPartyMember(int index){
		Debug.Log ("setPartyMember called");
		bool inParty = false;
		foreach (serialAgent sA in myParty) {
			if( sA.agentId ==  population [(rowIndex * buttons.Count) + index].agentId  ){
				inParty = true;
			}
		}

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
			enablePopulationPanel(false);
			if( numSet < 4 )
				numSet++;
		}
	}
}

[Serializable]
public class tempAgent{
	public string name;
	public int movement;
	public int attack;
	public int perception;
	
}