using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class SquadSelectionScript : MonoBehaviour {
	PlayerData dataCopy;

	public List<tempAgent> population;

	public List<Button> buttons;

	public int rowIndex = 0;

	// Use this for initialization
	void Start () {
		rowIndex = 0;
		int index = 0;
		for(int i = index; i < index + buttons.Count; i++) {
			buttons[i].GetComponentInChildren<Text>().text = population[i].name;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void shiftLeft(){
		rowIndex--;
		if (rowIndex < 0)
			rowIndex = 0;
		int index = rowIndex * buttons.Count;
		int butDex = 0;
		for(int i = index; i < index + buttons.Count; i++) {
			if( i < population.Count )
				buttons[butDex].GetComponentInChildren<Text>().text = population[i].name;
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
				buttons[butDex].GetComponentInChildren<Text>().text = population[i].name;
			else
				buttons[butDex].GetComponentInChildren<Text>().text = "NA";
			butDex++;
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