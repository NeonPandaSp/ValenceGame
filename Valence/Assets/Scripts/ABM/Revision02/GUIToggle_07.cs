using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GUIToggle_07 : MonoBehaviour {

    /* Set this script on a building */
    protected bool showMenu = false;
    // Set showing the menu to false

    //Assign agent fsm to this GUI
    public AgentLogic_07 agentLogic;

    JobUI jobUI;
    
    void Start() {

        //jobUI = GameObject.Find("JobUI").GetComponent<JobUI>();

    }

    void OnMouseUp() {

        // When you click, change the variables value
        if (showMenu)
            showMenu = false;
        else
            showMenu = true;
    }

    void OnGUI() {

        if (showMenu) {

            //Check if there is a farm
            if (GameObject.FindWithTag("Farm")) {

                if (GUI.Button(new Rect(10, 10, 100, 20), "Assign Farmer") && (agentLogic.jobState != AgentLogic_07.jobSubState.Farmer)) {
                    
                    //Obtain all farm waypoints that the agent should move between when working
                    agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("FarmWaypoint"));

                    //Set the agent to working
                    agentLogic.aState = AgentLogic_07.agentState.Working;

                    //Define the working state as farming
                    agentLogic.jobState = AgentLogic_07.jobSubState.Farmer;

                    //Ensure that there is no -Count
                    /*if (jobUI.farmerCount >= 0) {

                        //Increment the number of farmers by 1
                        jobUI.farmerCount += 1;
                    }*/
                }
            }

            //Check if there is a hospital
            /*if (GameObject.FindWithTag("Hospital")) {

                if (GUI.Button(new Rect(10, 30, 100, 20), "Assign Medic") && (agentLogic.jobState != AgentLogic_07.jobSubState.Medic)) {
                    
                    //Obtain all farm waypoints that the agent should move between when working
                    agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("HospitalWaypoint"));

                    //Set the agent to working
                    agentLogic.aState = AgentLogic_07.agentState.Working;

                    //Define the working state as farming
                    agentLogic.jobState = AgentLogic_07.jobSubState.Medic;

                    //Ensure that there is no -Count
                    if (jobUI.medicCount >= 0) {

                        //Increment the number of medics by 1
                        jobUI.medicCount += 1;
                    }

                    
                }

            }*/
        }
    }

}