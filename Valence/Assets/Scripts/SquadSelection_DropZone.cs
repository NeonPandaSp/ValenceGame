using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SquadSelection_DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	//public SquadSelection_Draggable.Slot memberNumber = SquadSelection_Draggable.Slot.MEMBER1;
	
	public void OnPointerEnter (PointerEventData eventData) {
	}

	public void OnPointerExit (PointerEventData eventData) {
	}

	public void OnDrop (PointerEventData eventData) {
		SquadSelection_Draggable d = eventData.pointerDrag.GetComponent <SquadSelection_Draggable> ();
		if (d != null) {
			d.parentToReturnTo = this.transform;
		}
	}
}
