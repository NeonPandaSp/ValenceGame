using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class MapSquadSceneControl : MonoBehaviour {
	public GameObject mapCan, squadCan, loadScreen;

	public Button proceedButton;
	public Text squadButton;

	public int mapIndex;

	public List<serialAgent> myParty;

	// Update is called once per frame
	void Update () {
		mapIndex = mapCan.GetComponent<MapSelectionScript> ().selectedMap;
		if (squadCan.GetComponent<SquadSelectionScript> ().squadNumber >= 1) {
			proceedButton.interactable = true;
		} else {
			proceedButton.interactable = false;
		}
	}

	public void toggleCanvas(){
		if (mapIndex == 2) {
			mapCan.SetActive (false);
			loadScreen.SetActive (true);
			Application.LoadLevelAsync (mapIndex);
		}
		if (mapCan.activeSelf) {
			if (mapIndex == 2 )
				loadScreen.SetActive (true);
			else
				squadCan.SetActive (true);

			mapCan.SetActive (false);
		} else {
			squadCan.SetActive (false);
			mapCan.SetActive (true);
		}
	}

	public void loadExploreMap(){
		PlayerData oldData = PlayerDataManager.playerDataManager.loadSaveData ();

		for( int i = 0; i < squadCan.GetComponent<SquadSelectionScript>().myParty.Length; i++){
			// Don't know why the else never triggers but were going with it, refer to this if things get freaky deaky. 
			if( squadCan.GetComponent<SquadSelectionScript>().myParty[i].agentId.Equals("-1") || squadCan.GetComponent<SquadSelectionScript>().myParty[i].agentId != " " ){
				foreach( serialAgent sA in squadCan.GetComponent<SquadSelectionScript>().population ){
					if( sA.agentId == squadCan.GetComponent<SquadSelectionScript>().myParty[i].agentId ){
						myParty.Add( sA );
						Debug.Log ( "Agent at myParty[ " + i + " ] set to GameSave Party @ " + myParty.Count );
					}
				}
			} else {
				Debug.Log ( "Agent at myParty[ " + i + " ] not set." );
			}

			//myParty.Add (squadCan.GetComponent<SquadSelectionScript>().myParty[i] );
		}
		oldData.currentParty = myParty;
		PlayerDataManager.playerDataManager.writePlayerData (oldData);
		Application.LoadLevel (mapIndex);
	}
}
