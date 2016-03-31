using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System;

public class SquadSelection_Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public String[] parentNameArray = new String[4] {"Member 1", "Member 2", "Member 3", "Member 4"};

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

		if (newParent.gameObject.transform.name.ToString() == "Scrollable List") {
			//DO NOTHING
		} else {
			if (newParent.gameObject.transform.childCount > 1) {
				this.transform.SetParent (oldParent);
			}
		}

		//Refreshes the card to it's old position if it doesn't find a new parent
		if (newParent.gameObject.transform.name.ToString () == oldParent.gameObject.transform.name.ToString ()) {
			this.transform.SetParent (null);
			this.transform.SetParent (oldParent);
		}

		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		Debug.Log ("New parent is: " + this.transform.parent);
	}
}