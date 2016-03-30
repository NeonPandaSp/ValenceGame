using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class SquadSelection_DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public SquadSelectionScript _SquadSelectionScript;

	public GameObject[] MemberListObjects = new GameObject[4];
	//public String[] parentNameArray = new String[4] {"Member 1", "Member 2", "Member 3", "Member 4"};
	int blah = 0;
	public string tempAgentIDToPass;
	
	public void OnPointerEnter (PointerEventData eventData) {
	}

	public void OnPointerExit (PointerEventData eventData) {
	}

	public void OnDrop (PointerEventData eventData) {
		SquadSelection_Draggable d = eventData.pointerDrag.GetComponent <SquadSelection_Draggable> ();
		if (d != null) {
			d.parentToReturnTo = this.transform;

			if (d.parentToReturnTo != null) {
				for (int i = 0; i < MemberListObjects.Length; i++) {
					if (d.parentToReturnTo.gameObject.name.ToString() == "Scrollable List") {
						foreach (GameObject listList in MemberListObjects) {
							Debug.Log (listList.name);
							if (listList.transform.childCount == 0) {
							    tempAgentIDToPass = "";
								Debug.Log ("ARRAY INDEX IS: ");
								Array.IndexOf (MemberListObjects, MemberListObjects[i].gameObject.name.ToString());
								_SquadSelectionScript.myParty[i] = null;
								Debug.Log (listList.name + "has no agent");
							}
						}
					}
					if (d.parentToReturnTo.gameObject.name.ToString() == MemberListObjects[i].name.ToString()) {
						foreach (serialAgent fs in _SquadSelectionScript.population) {
							if (fs.agentName == d.name) {
								tempAgentIDToPass = fs.agentId;
								//Debug.Log (d.parentToReturnTo.gameObject.name.ToString() + " is Settler " + fs.agentName + ", ID: " + tempAgentIDToPass);
							}
						}
					blah++;
					}
				}
			} //if parent not null end
		}
	}
}
