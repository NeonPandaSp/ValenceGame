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

	public GameObject UI_Container;
	//Glow
	Color oldValue = new Color (255 / 255f, 255 / 255f, 255 / 255f);
	Color newValue = new Color (248 / 255f, 255 / 255f, 135 / 255f);

	public void OnBeginDrag (PointerEventData eventData) {

		newParent = this.transform.parent;
		//this.transform.SetParent (this.transform.parent);
		oldParent = this.transform.parent;
		Debug.Log ("OLD PARENT IS: " + oldParent);
		
		GetComponent<CanvasGroup>().blocksRaycasts = false;

		UI_Container = GameObject.FindGameObjectWithTag ("UI Container");

		//YAY GLOW
		if (oldParent.gameObject.transform.name.ToString () == "Scrollable List") {
			for (int i = 0; i < UI_Container.GetComponentInChildren<SquadSelectionScript>().MemberList.Length; i++) {
				Color glowColour = Color.Lerp (oldValue, newValue, Mathf.PingPong (Time.time, 8));
				UI_Container.GetComponentInChildren<SquadSelectionScript>().MemberList[i].GetComponent<Image>().color = glowColour;
			}
		}

		//YAY WEAPONS GLOW
		if (oldParent.gameObject.transform.name.ToString () == "Scrollable Weapons List") {
			for (int i = 0; i < UI_Container.GetComponentInChildren<SquadSelectionScript>().WeaponList.Length; i++) {
				Color glowColour2 = Color.Lerp (oldValue, newValue, Mathf.PingPong (Time.time, 8));
				UI_Container.GetComponentInChildren<SquadSelectionScript>().WeaponList[i].GetComponent<Image>().color = glowColour2;
			}
		}
	}

	public void OnDrag (PointerEventData eventData) {
		this.transform.position = eventData.position;

		if (oldParent.gameObject.transform.name.ToString () == "Scrollable List") {
			for (int i = 0; i < UI_Container.GetComponentInChildren<SquadSelectionScript>().MemberList.Length; i++) {
				Color glowColour = Color.Lerp (oldValue, newValue, Mathf.PingPong (Time.time, 1));
				UI_Container.GetComponentInChildren<SquadSelectionScript> ().MemberList [i].GetComponent<Image> ().color = glowColour;
			}
		}

		//YAY WEAPONS GLOW
		if (oldParent.gameObject.transform.name.ToString () == "Scrollable Weapons List") {
			for (int i = 0; i < UI_Container.GetComponentInChildren<SquadSelectionScript>().WeaponList.Length; i++) {
				Color glowColour2 = Color.Lerp (oldValue, newValue, Mathf.PingPong (Time.time, 8));
				UI_Container.GetComponentInChildren<SquadSelectionScript>().WeaponList[i].GetComponent<Image>().color = glowColour2;
			}
		}
	}
	
	public void OnEndDrag (PointerEventData eventData)
	{
		for (int i = 0; i < UI_Container.GetComponentInChildren<SquadSelectionScript>().MemberList.Length; i++) {
			UI_Container.GetComponentInChildren<SquadSelectionScript> ().MemberList [i].GetComponent<Image> ().color = oldValue;
		}

		for (int i = 0; i < UI_Container.GetComponentInChildren<SquadSelectionScript>().WeaponList.Length; i++) {
			UI_Container.GetComponentInChildren<SquadSelectionScript> ().WeaponList [i].GetComponent<Image> ().color = oldValue;
		}
		
		this.transform.SetParent (newParent);

		//=======================================\\
		//FROM: Scrollable List | TO: Weapon List\\
		//=======================================\\
		for (int i = 0; i < UI_Container.GetComponentInChildren<SquadSelectionScript>().MemberList.Length; i++) {
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
			foreach (GameObject weaponOBJ in UI_Container.GetComponentInChildren<SquadSelectionScript>().WeaponList) {
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
			foreach (GameObject memberOBJ in UI_Container.GetComponentInChildren<SquadSelectionScript>().MemberList) {
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
				if (UI_Container.GetComponentInChildren<SquadSelectionScript>().MemberList[i].gameObject.transform.childCount == 0) {
					this.transform.SetParent (oldParent);
					Debug.Log ("No Member Present");
					UI_Container.GetComponentInChildren<SquadSelectionScript>().GlowImage.GetComponent<Image>().canvasRenderer.SetAlpha (1.1f);
					UI_Container.GetComponentInChildren<SquadSelectionScript>().GlowImage.GetComponent<Image>().CrossFadeAlpha (0.0f, 1, false);
					UI_Container.GetComponentInChildren<SquadSelectionScript>().GlowImage.GetComponent<Image>().CrossFadeAlpha (0.9f, 3, false);
					UI_Container.GetComponentInChildren<SquadSelectionScript>().GlowImage.GetComponent<Image>().CrossFadeAlpha (0.0f, 2, false);
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
			foreach (GameObject CanYouSmellWhatTheRockIsCooking in UI_Container.GetComponentInChildren<SquadSelectionScript>().MemberList) {
				if (this.oldParent.gameObject.transform.name.ToString () == parentNameArray[i] &&
				    this.newParent.gameObject.transform.name.ToString () != this.oldParent.gameObject.transform.name.ToString () &&
					this.newParent.gameObject.transform.name.ToString () == CanYouSmellWhatTheRockIsCooking.gameObject.name) {

					if (UI_Container.GetComponentInChildren<SquadSelectionScript>().WeaponList[i].gameObject.transform.childCount > 0) {
						UI_Container.GetComponentInChildren<SquadSelectionScript>().WeaponList[i].gameObject.transform.GetChild(0).gameObject.transform.SetParent
							(UI_Container.GetComponentInChildren<SquadSelectionScript>().scrollableWeaponsList.gameObject.transform);
						Debug.Log ("Weapon " + UI_Container.GetComponentInChildren<SquadSelectionScript>().WeaponList[i].gameObject.name + " moved to Weapons List");
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