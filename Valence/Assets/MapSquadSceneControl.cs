﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class MapSquadSceneControl : MonoBehaviour {
	public GameObject mapCan, squadCan;

	public Button proceedButton;

	public int mapIndex;

	public List<serialAgent> myParty;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (squadCan.GetComponent<SquadSelectionScript> ().numSet > 1) {
			proceedButton.interactable = true;
		} else {
			proceedButton.interactable = false;
		}
	}

	public void toggleCanvas(){
		if (mapCan.activeSelf) {
			squadCan.SetActive(true);
			mapCan.SetActive(false);
		} else {
			squadCan.SetActive(false);
			mapCan.SetActive(true);
		}
	}

	public void loadExploreMap(){
		PlayerData oldData = PlayerDataManager.playerDataManager.loadSaveData ();
		int mapIndex = mapCan.GetComponent<MapSelectionScript> ().selectedMap;
		//foreach (serialAgent pM in squadCan.GetComponent<SquadSelectionScript>().myParty) {
		for( int i = 0; i < squadCan.GetComponent<SquadSelectionScript>().numSet; i++){
			myParty.Add( squadCan.GetComponent<SquadSelectionScript>().myParty[i] );
		}
		oldData.currentParty = myParty;
		PlayerDataManager.playerDataManager.writePlayerData (oldData);
		Application.LoadLevel (mapIndex);
	}
}
