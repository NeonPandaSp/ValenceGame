using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class SquadSelection_DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public SquadSelectionScript _SquadSelectionScript;

	public GameObject[] MemberListObjects = new GameObject[4];
	public String[] parentNameArray = new String[4] {"Member 1", "Member 2", "Member 3", "Member 4"};
	String scrollAbleListString = "Scrollable List";

	public GameObject[] SelectedWeaponsListObjects = new GameObject[4];
	public String[] weaponsParentNameArray = new String[4] {"Weapon 1", "Weapon 2", "Weapon 3", "Weapon 4"};
	String scrollAbleWeaponsListString = "Scrollable Weapons List";

	int squadPlaceInIndex;
	int weaponPlaceInIndex;

	//Image change
	public Sprite placeholderSquadIcon;
	public Sprite placeholderSelectedWeaponIcon;

	public GameObject UI_Container;

	public void Start(){
		UI_Container = GameObject.FindGameObjectWithTag ("UI Container");
	}
	
	public void OnPointerEnter (PointerEventData eventData) {
	}

	public void OnPointerExit (PointerEventData eventData) {
	}

	public void OnDrop (PointerEventData eventData) {
		SquadSelection_Draggable d = eventData.pointerDrag.GetComponent <SquadSelection_Draggable> ();

		if (d != null) {
			d.newParent = this.transform;

			if (d.newParent.name.ToString() != null) {
				//===========\\
				//===Squad===\\
				//===========\\
				for (int i = 0; i < MemberListObjects.Length; i++) {
					//========================================\\
					//FROM: Member List | TO: Scrollable  List\\
					//========================================\\
					if (d.newParent.name.ToString() == scrollAbleListString) {
						foreach (string listList in parentNameArray) {
							//listList OUTPUTS Member 1, Member 2, Member 3, Member 4
							if (d.oldParent.name == listList) {
								//Finds the index for that particular parent name in the array of 4
								squadPlaceInIndex =  Array.IndexOf (parentNameArray, d.oldParent.name);
								UI_Container.GetComponentInChildren<SquadSelectionScript>().myParty[squadPlaceInIndex].agentId = "-1";
								//Debug.Log ("DURING IF:  " + _SquadSelectionScript.population.Count);
							}
						}
					}
						
					//================================\\
					//FROM: Anywhere | TO: Member List\\
					//================================\\
					if (d.newParent.name.ToString() == parentNameArray[i]) {
						//Debug.Log ("ERASING DATA for " + _SquadSelectionScript.population.Count );
						foreach (serialAgent fs in _SquadSelectionScript.population) {
							if (fs.agentName == d.name) {
								//Debug.Log ("The current parent is: " + d.newParent.name.ToString());
								squadPlaceInIndex =  Array.IndexOf (parentNameArray, d.newParent.name);
								UI_Container.GetComponentInChildren<SquadSelectionScript>().myParty[squadPlaceInIndex].agentId = fs.agentId;
								//Debug.Log ("Parent: " + parentNameArray[i] + " has child " + fs.agentName);
							}
						}
					}

					//================================\\
					//FROM: Member List | TO: Anywhere\\
					//================================\\
					if (d.oldParent.name == parentNameArray[i]) {
						squadPlaceInIndex =  Array.IndexOf (parentNameArray, d.oldParent.name);
						UI_Container.GetComponentInChildren<SquadSelectionScript>().myParty[squadPlaceInIndex].agentId = "-1";
					}
				}
				
				//=============\\
				//===Weapons===\\
				//=============\\
				for (int i = 0; i < scrollAbleWeaponsListString.Length; i++) {
					//===============================================\\
					//FROM: Weapon List | TO: Scrollable Weapons List\\
					//===============================================\\
					if (d.newParent.name.ToString() == scrollAbleWeaponsListString) {
						Debug.Log ("NAME IS: " + d.name);
						foreach (string weaponListList in weaponsParentNameArray) {
							if (d.oldParent.name == weaponListList) {
								weaponPlaceInIndex =  Array.IndexOf (weaponsParentNameArray, d.oldParent.name);
								UI_Container.GetComponentInChildren<SquadSelectionScript>().myParty[weaponPlaceInIndex].myWeapon.weaponId = "-1";
							}
						}
					}
				}

				for (int i = 0; i < weaponsParentNameArray.Length; i++) {					
					//================================\\
					//FROM: Anywhere | TO: Weapon List\\
					//================================\\
					if (d.newParent.name.ToString() == weaponsParentNameArray[i]) {
						foreach (serialWeapon wp in _SquadSelectionScript.weaponsPopulation) {
							Debug.Log ("NAME is: " + wp.weaponName + " ID is: " + wp.weaponId);
							if (wp.weaponName == d.name) {
								weaponPlaceInIndex =  Array.IndexOf (weaponsParentNameArray, d.newParent.name);
								UI_Container.GetComponentInChildren<SquadSelectionScript>().myParty[weaponPlaceInIndex].myWeapon.weaponId = wp.weaponId;
								Debug.Log ("THE ID IS SET TO " + UI_Container.GetComponentInChildren<SquadSelectionScript>().myParty[weaponPlaceInIndex].myWeapon.weaponId);
							}
						}
					}
					
					//================================\\
					//FROM: Weapon List | TO: Anywhere\\
					//================================\\
					if (d.oldParent.name == weaponsParentNameArray[i]) {
						weaponPlaceInIndex =  Array.IndexOf (weaponsParentNameArray, d.oldParent.name);
						UI_Container.GetComponentInChildren<SquadSelectionScript>().myParty[weaponPlaceInIndex].myWeapon.weaponId = "-1";
					}
				}
			} else {
				//if parent not null end
				Debug.Log ("Detectivery");
			}
		}
	}
}