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
	public List<serialWeapon> myWeaponListToSave;

	public loadScene _loadScene;
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
			//loadScreen.SetActive (true);
			//Application.LoadLevelAsync (mapIndex);
			_loadScene.initLoadScene(mapIndex);
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

	public void loadExploreMap() {
		PlayerData oldData = PlayerDataManager.playerDataManager.loadSaveData ();

		for (int i = 0; i < squadCan.GetComponent<SquadSelectionScript>().myParty.Length; i++) {
			// Don't know why the else never triggers but were going with it, refer to this if things get freaky deaky. 
			if (squadCan.GetComponent<SquadSelectionScript>().myParty[i].agentId.Equals("-1") || squadCan.GetComponent<SquadSelectionScript>().myParty[i].agentId != " " ) {
				foreach (serialAgent sA in squadCan.GetComponent<SquadSelectionScript>().population) {
					if (sA.agentId == squadCan.GetComponent<SquadSelectionScript>().myParty[i].agentId) {
						myParty.Add (sA);
						foreach (serialWeapon sW in squadCan.GetComponent<SquadSelectionScript>().weaponsPopulation ){
							Debug.Log ("SerialWeapon Population ID: " + sW.weaponId );
							if (sW.weaponId == squadCan.GetComponent<SquadSelectionScript>().myParty[i].myWeapon.weaponId) {
								myParty[myParty.Count-1].myWeapon = sW;
								myWeaponListToSave.Add (sW);
								//partyWeaponDex++;
								//weaponSet = true;
								//Debug.Log ("Weapon at myParty [" + i + "] set to Weapon:" + myParty[i].myWeapon.weaponName);
							}
						}

						Debug.Log ("Agent at myParty[ " + i + " ] set to GameSave Party @ " + myParty.Count);
					}
				}
			} else {
				Debug.Log ("Agent at myParty[ " + i + " ] not set.");
			}

			//myParty.Add (squadCan.GetComponent<SquadSelectionScript>().myParty[i] );
		}
//		int partyWeaponDex = 0;
//		for (int i = 0; i < squadCan.GetComponent<SquadSelectionScript>().myParty.Length; i++){
//			if (squadCan.GetComponent<SquadSelectionScript>().myParty[i].myWeapon.weaponId.Equals ("-1") || squadCan.GetComponent<SquadSelectionScript>().myParty[i].myWeapon.weaponId != " ") {
//				Debug.Log ( "SerialWeapon Party ID: " + squadCan.GetComponent<SquadSelectionScript>().myParty[i].myWeapon.weaponId );
//				bool weaponSet = false; // check if the weapon is ever set
//				foreach (serialWeapon sW in squadCan.GetComponent<SquadSelectionScript>().weaponsPopulation ){
//					Debug.Log ("SerialWeapon Population ID: " + sW.weaponId );
//					if (sW.weaponId == squadCan.GetComponent<SquadSelectionScript>().myParty[i].myWeapon.weaponId) {
//						myParty[partyWeaponDex].myWeapon = sW;
//						myWeaponListToSave.Add (sW);
//						partyWeaponDex++;
//						weaponSet = true;
//						Debug.Log ("Weapon at myParty [" + i + "] set to Weapon:" + myParty[i].myWeapon.weaponName);
//					} else {
//
//					}
//				}
//				if( !weaponSet ){
//					Debug.Log ("Weapon at myParty [" + i + "] not set. ~ Weird Error Edition");
//					if (squadCan.GetComponent<SquadSelectionScript>().myParty[i].agentId.Equals("-1") || squadCan.GetComponent<SquadSelectionScript>().myParty[i].agentId != " " ) {
//						Debug.Log ("Squad Member Set, but not weapon, default weapon set");
//						partyWeaponDex++;
//					} else {
//						Debug.Log ("Squad Member Not Set and Weapon not set");
//					}
//				}
//			} else {
//				Debug.Log ("Weapon at myParty [" + i + "] not set.");
//				if (squadCan.GetComponent<SquadSelectionScript>().myParty[i].agentId.Equals("-1") || squadCan.GetComponent<SquadSelectionScript>().myParty[i].agentId != " " ) {
//					Debug.Log ("Squad Member Set, but not weapon, default weapon set");
//					partyWeaponDex++;
//				} else {
//					Debug.Log ("Squad Member Not Set and Weapon not set");
//				}
//			}
//		}

		oldData.currentParty = myParty;
		oldData.currentWeapons = myWeaponListToSave;
		PlayerDataManager.playerDataManager.writePlayerData (oldData);
		//Application.LoadLevel (mapIndex);
		_loadScene.initLoadScene(mapIndex);
	}
}
