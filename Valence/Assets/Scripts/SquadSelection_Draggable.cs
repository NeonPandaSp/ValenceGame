using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System;

public class SquadSelection_Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Transform parentToReturnTo = null;

//	public enum Slot {MEMBER1, MEMBER2, MEMBER3, MEMBER4};
//	public Slot memberNumber = Slot.MEMBER1;

	public int numberOfSettlersSelected;
	
	public void OnBeginDrag (PointerEventData eventData) {

		parentToReturnTo = this.transform.parent;
		this.transform.SetParent( this.transform.parent.parent );
		
		GetComponent<CanvasGroup>().blocksRaycasts = false;

		//Used for glow effects later on
		//Drapzone[] zones = GameObject.FindObjectsOfType<SquadSelection_DropZone> ();
		//zones.DO SOMETHING HERE
	}

	public void OnDrag (PointerEventData eventData) {

		this.transform.position = eventData.position;
	}

	public void OnEndDrag (PointerEventData eventData)
	{
		this.transform.SetParent (parentToReturnTo);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;

		//Debug.Log ("It's parent is: " + this.transform.parent);
		//Debug.Log ("Child 4 of it's parent is: " + this.transform.parent.GetChild(3));

		this.transform.parent.GetChild (0).GetComponent<Image>().sprite = this.transform.GetChild (0).GetComponent<Image> ().sprite;
		for (int i = 1; i < 5; i++) {
			this.transform.parent.GetChild (i).GetComponent<Text> ().text = this.transform.GetChild (i).GetComponent<Text> ().text;
		}
	}
}