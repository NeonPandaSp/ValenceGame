using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class SquadSelection_DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	//public SquadSelection_Draggable.Slot memberNumber = SquadSelection_Draggable.Slot.MEMBER1;
	public String[] AgentIDArray = new String[4];
	public String[] parentNameArray = new String[4] {"Member 1", "Member 2", "Member 3", "Member 4"};

	public SquadSelectionScript _SquadSelectionScript;
	
	public void OnPointerEnter (PointerEventData eventData) {
	}

	public void OnPointerExit (PointerEventData eventData) {
	}

	public void OnDrop (PointerEventData eventData) {
		SquadSelection_Draggable d = eventData.pointerDrag.GetComponent <SquadSelection_Draggable> ();
		if (d != null) {
			d.parentToReturnTo = this.transform;

			for (int i = 0; i < parentNameArray.Length; i++) {
				if (d.parentToReturnTo.gameObject.name.ToString() == parentNameArray[i]) {
					Debug.Log ("IT WORKS");
					AgentIDArray [i] = _SquadSelectionScript.settlerID[i];
					//Debug.Log ("The gameobject " + d.parentToReturnTo.gameObject.name.ToString() + "'s Agent ID is: " + AgentIDArray [i]);
				}
			}
		}
	}
}
