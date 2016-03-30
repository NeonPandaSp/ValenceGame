using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class SquadSelection_DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public SquadSelectionScript _SquadSelectionScript;

	public String[] parentNameArray = new String[4] {"Member 1", "Member 2", "Member 3", "Member 4"};
	
	public void OnPointerEnter (PointerEventData eventData) {
	}

	public void OnPointerExit (PointerEventData eventData) {
	}

	public void OnDrop (PointerEventData eventData) {
		SquadSelection_Draggable d = eventData.pointerDrag.GetComponent <SquadSelection_Draggable> ();
		if (d != null) {
			d.parentToReturnTo = this.transform;

			for (int j = 0; j < _SquadSelectionScript.population.Count; j++) {									//i GOES TO 4
				for (int i = 0; i < parentNameArray.Length; i++) {
					foreach (serialAgent fs in _SquadSelectionScript.population) {
						if (d.parentToReturnTo.gameObject.name.ToString() == parentNameArray[i]) {		//j GOES TO settler count
							if (fs.agentName != d.name) {
								_SquadSelectionScript.AgentIDArray [j] = fs.agentId;
							}

							_SquadSelectionScript.AgentNameArray [j] = _SquadSelectionScript.sNames[j];
						}
					}

					Debug.Log (d.parentToReturnTo.gameObject.name.ToString() + " is Settler " + _SquadSelectionScript.AgentNameArray[j] + ", ID: " + _SquadSelectionScript.AgentIDArray [j]);
				}
			}
		}
	}
}
