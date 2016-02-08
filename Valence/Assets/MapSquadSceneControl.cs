using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MapSquadSceneControl : MonoBehaviour {
	public GameObject mapCan, squadCan;
	public int mapIndex = 4;

	public List<serialAgent> myParty;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
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
		foreach (serialAgent pM in squadCan.GetComponent<SquadSelectionScript>().myParty) {
			myParty.Add( pM );
		}
		oldData.currentParty = myParty;
		PlayerDataManager.playerDataManager.writePlayerData (oldData);
		Application.LoadLevel (mapIndex);
	}
}
