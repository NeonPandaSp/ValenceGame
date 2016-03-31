using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class SquadSelection_DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public SquadSelectionScript _SquadSelectionScript;

	public GameObject[] MemberListObjects = new GameObject[4];
	public String[] parentNameArray = new String[4] {"Member 1", "Member 2", "Member 3", "Member 4"};
	String scrollAbleListString = "Scrollable List";
	public string tempAgentIDToPass;
	int placeInIndex;

	//Image change
	public Sprite placeholderSquadIcon;
	
	public void OnPointerEnter (PointerEventData eventData) {
	}

	public void OnPointerExit (PointerEventData eventData) {
	}

	public void OnDrop (PointerEventData eventData) {
		SquadSelection_Draggable d = eventData.pointerDrag.GetComponent <SquadSelection_Draggable> ();
		if (d != null) {
			d.newParent = this.transform;

			if (d.newParent.name.ToString() != null) {
				for (int i = 0; i < MemberListObjects.Length; i++) {

					//========================================\\
					//FROM: Member List | TO: Scrollable  List\\
					//========================================\\
					if (d.newParent.name.ToString() == "Scrollable List") {
						foreach (string listList in parentNameArray) {
							//listList OUTPUTS Member 1, Member 2, Member 3, Member 4
							if (d.oldParent.name == listList) {
								//Finds the index for that particular parent name in the array of 4
								placeInIndex =  Array.IndexOf (parentNameArray, d.oldParent.name);
								this.transform.root.GetComponent<SquadSelectionScript>().myParty[placeInIndex].agentId = "-1";
								//Debug.Log ("DURING IF:  " + _SquadSelectionScript.population.Count);
							}
						}
					}

//					if (d.newParent.name == parentNameArray[i] && d.oldParent.name == parentNameArray[i]) {
//						Debug.Log ("YAAAY");
//						placeInIndex =  Array.IndexOf (parentNameArray, d.oldParent.name);
//					}
						
						
					//===================================\\
					//FROM: Member List | TO: Member List\\
					//===================================\\
					if (d.newParent.name.ToString() == parentNameArray[i]) {
						//Debug.Log ("ERASING DATA for " + _SquadSelectionScript.population.Count );
						foreach (serialAgent fs in _SquadSelectionScript.population) {
							if (fs.agentName == d.name) {
								//tempAgentIDToPass = fs.agentId;
								//Debug.Log ("The current parent is: " + d.newParent.name.ToString());
								placeInIndex =  Array.IndexOf (parentNameArray, d.newParent.name);
								this.transform.root.GetComponent<SquadSelectionScript>().myParty[placeInIndex].agentId = fs.agentId;
								//Debug.Log ("Parent: " + parentNameArray[i] + " has child " + fs.agentName);
							}
						}
					}

					//================================\\
					//FROM: Member List | TO: Anywhere\\
					//================================\\
					if (d.oldParent.name == parentNameArray[i]) {
						placeInIndex =  Array.IndexOf (parentNameArray, d.oldParent.name);
						this.transform.root.GetComponent<SquadSelectionScript>().myParty[placeInIndex].agentId = "-1";
					}
				}
			} else {
				//if parent not null end
				Debug.Log ("Detectivery");
			}
		}
	}
}