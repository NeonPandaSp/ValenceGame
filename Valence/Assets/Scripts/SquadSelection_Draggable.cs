using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System;

public class SquadSelection_Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public String[] parentNameArray = new String[4] {"Member 1", "Member 2", "Member 3", "Member 4"};
	public String[] weaponsParentNameArray = new String[4] {"Weapon 1", "Weapon 2", "Weapon 3", "Weapon 4"};

	public Transform newParent = null;
	public Transform oldParent = null;

	public int numberOfSettlersSelected;

	//Glow
	Color oldValue = new Color (255 / 255f, 255 / 255f, 255 / 255f);
	Color newValue = new Color (255 / 255f, 200 / 255f, 200 / 255f);

	public void OnBeginDrag (PointerEventData eventData) {

		newParent = this.transform.parent;
		//this.transform.SetParent (this.transform.parent);
		oldParent = this.transform.parent;
		Debug.Log ("OLD PARENT IS: " + oldParent);
		
		GetComponent<CanvasGroup>().blocksRaycasts = false;

		//YAY GLOW
		if (oldParent.gameObject.transform.name.ToString () == "Scrollable List") {
			for (int i = 0; i < this.transform.root.GetComponent<SquadSelectionScript>().MemberList.Length; i++) {
				Color glowColour = Color.Lerp (oldValue, newValue, Mathf.PingPong (Time.time, 8));
				this.transform.root.GetComponent<SquadSelectionScript>().MemberList[i].GetComponent<Image>().color = glowColour;
			}
		}
	}

	public void OnDrag (PointerEventData eventData) {
		this.transform.position = eventData.position;

		if (oldParent.gameObject.transform.name.ToString () == "Scrollable List") {
			for (int i = 0; i < this.transform.root.GetComponent<SquadSelectionScript>().MemberList.Length; i++) {
				Color glowColour = Color.Lerp (oldValue, newValue, Mathf.PingPong (Time.time, 1));
				this.transform.root.GetComponent<SquadSelectionScript> ().MemberList [i].GetComponent<Image> ().color = glowColour;
			}
		}
	}
	
	public void OnEndDrag (PointerEventData eventData)
	{
		for (int i = 0; i < this.transform.root.GetComponent<SquadSelectionScript>().MemberList.Length; i++) {
			this.transform.root.GetComponent<SquadSelectionScript> ().MemberList [i].GetComponent<Image> ().color = oldValue;
		}
		
		this.transform.SetParent (newParent);

		//=======================================\\
		//FROM: Scrollable List | TO: Weapon List\\
		//=======================================\\
		for (int i = 0; i < this.transform.root.GetComponent<SquadSelectionScript>().MemberList.Length; i++) {
			if (this.oldParent.name.ToString() == "Scrollable List" && this.newParent.name.ToString() == weaponsParentNameArray[i]) {
				this.transform.SetParent (oldParent);
				Debug.Log ("Snap that shit back");
			}		
		}

		//=========================================\\
		//FROM: Scrollable Weapons List | TO: Squad\\
		//=========================================\\
		for (int i = 0; i < parentNameArray.Length; i++) {
			if (this.oldParent.name.ToString() == "Scrollable Weapons List" && this.newParent.name.ToString() == parentNameArray[i]) {
				this.transform.SetParent (oldParent);
				Debug.Log ("Get back to your parent, SON");
			}
		}

		//=========================================\\
		//FROM: Scrollable Weapons List | TO: Squad\\
		//=========================================\\
		for (int i = 0; i < parentNameArray.Length; i++) {
			foreach (GameObject weaponOBJ in this.transform.root.GetComponent<SquadSelectionScript>().WeaponList) {
				if ((this.oldParent.name.ToString () == weaponOBJ.name && this.newParent.name.ToString () == parentNameArray [i])) {
					this.transform.SetParent (oldParent);
					Debug.Log ("Lol you can't switch from a weapon to a member");
				}
			}
		}

		//====================================\\
		//FROM: Member List | TO: Weapons List\\
		//====================================\\
		for (int i = 0; i < weaponsParentNameArray.Length; i++) {
			foreach (GameObject memberOBJ in this.transform.root.GetComponent<SquadSelectionScript>().MemberList) {
				if (this.oldParent.name.ToString() == memberOBJ.name && this.newParent.name.ToString() == weaponsParentNameArray[i]) {
					this.transform.SetParent (oldParent);
					Debug.Log ("Lol you can't switch from a member to a weapon");
				}
			}
		}

		//===============================================\\
		//FROM: Member List | TO: Scrollable Weapons List\\
		//===============================================\\
		for (int i = 0; i < parentNameArray.Length; i++) {
			if ((this.oldParent.gameObject.transform.name.ToString () == parentNameArray [i] &&
			     this.newParent.gameObject.transform.name.ToString () == "Scrollable Weapons List")) {
				
				this.transform.SetParent (oldParent);
				Debug.Log ("Wrong List");
			}
		}

		//================================================\\
		//FROM: Weapons List | TO: Scrollable Settler List\\
		//================================================\\
		for (int i = 0; i < weaponsParentNameArray.Length; i++) {
			int checkerVariableOG = 0;
			if (this.oldParent.gameObject.transform.name.ToString () == weaponsParentNameArray [i] &&
			    this.newParent.gameObject.transform.name.ToString () == "Scrollable List") {

				this.transform.SetParent (oldParent);
				Debug.Log ("Wrong List");
			}
		}

		//If there is no Member present in this slot, send weapon back
		for (int i = 0; i < parentNameArray.Length; i++) {
			if (this.newParent.name.ToString () == weaponsParentNameArray [i]) {
				if (this.transform.root.GetComponent<SquadSelectionScript>().MemberList[i].gameObject.transform.childCount == 0) {
					this.transform.SetParent (oldParent);
					Debug.Log ("No Member Present");
				}
			}
		}

		//If either Weapons List or Members List has a child object
		for (int i = 0; i < parentNameArray.Length; i++) {
			if (this.newParent.name.ToString () == parentNameArray [i] || this.newParent.name.ToString () == weaponsParentNameArray [i]) {
				if (this.newParent.gameObject.transform.childCount > 1) {
					this.transform.SetParent (oldParent);
					Debug.Log ("It already has another" + this.transform);
				}
			}
		}

		//If Settler switches slot position, reparent the associated weapon to Scrollable Weapons List
		for (int i = 0; i < parentNameArray.Length; i++) {
			foreach (GameObject CanYouSmellWhatTheRockIsCooking in this.transform.root.GetComponent<SquadSelectionScript>().MemberList) {
				if (this.oldParent.gameObject.transform.name.ToString () == parentNameArray[i] &&
				    this.newParent.gameObject.transform.name.ToString () != this.oldParent.gameObject.transform.name.ToString () &&
					this.newParent.gameObject.transform.name.ToString () == CanYouSmellWhatTheRockIsCooking.gameObject.name) {

					if (this.transform.root.GetComponent<SquadSelectionScript>().WeaponList[i].gameObject.transform.childCount > 0) {
						this.transform.root.GetComponent<SquadSelectionScript>().WeaponList[i].gameObject.transform.GetChild(0).gameObject.transform.SetParent
						(this.transform.root.GetComponent<SquadSelectionScript>().scrollableWeaponsList.gameObject.transform);
						Debug.Log ("Weapon " + this.transform.root.GetComponent<SquadSelectionScript>().WeaponList[i].gameObject.name + " moved to Weapons List");
					}
				}
			}
		}

		//Refreshes the card to it's old position if it doesn't find a different parent
		if (this.newParent.gameObject.transform.name.ToString () == this.oldParent.gameObject.transform.name.ToString ()) {
			this.transform.SetParent (null);
			this.transform.SetParent (oldParent);
		}

		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		Debug.Log ("NEW PARENT IS: " + this.transform.parent);
	}
}