using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System;

public class SquadSelection_Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Transform parentToReturnTo = null;

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
	}
}