using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System;

public class SquadSelection_Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public String[] parentNameArray = new String[4] {"Member 1", "Member 2", "Member 3", "Member 4"};

	public Transform tempParent = null;
	public Transform parentToReturnTo = null;
	public Transform oldParent = null;

	public int numberOfSettlersSelected;

	public void OnBeginDrag (PointerEventData eventData) {

		parentToReturnTo = this.transform.parent;
		this.transform.SetParent (this.transform.parent);
		oldParent = this.transform.parent;
		Debug.Log ("OLD PARENT IS: " + oldParent);
		
		GetComponent<CanvasGroup>().blocksRaycasts = false;

		//Used for glow effects later on
		//Drapzone[] zones = GameObject.FindObjectsOfType<SquadSelection_DropZone> ();
		//zones.DO SOMETHING HERE
	}

	public void OnDrag (PointerEventData eventData) {
		this.transform.position = eventData.position;
		tempParent = oldParent;
	}

	public void OnEndDrag (PointerEventData eventData)
	{
		this.transform.SetParent (parentToReturnTo);

		if (parentToReturnTo.gameObject.transform.name.ToString() == "Scrollable List") {
			//DO NOTHING
		} else {
			if (parentToReturnTo.gameObject.transform.childCount > 1) {
				this.transform.SetParent (oldParent);
			}
		}

		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		Debug.Log ("New parent is: " + this.transform.parent);
	}
}