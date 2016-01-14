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

    //Return true if a gameobject with corresponding tag has been spawned, vise versa for false
    bool farmAvailable, hospitalAvailable, waterstationAvailable, powerstationAvailable;

    //Return true if error message should be shown
    bool showError;

    void Start() {

        showError = false;
        hospitalAvailable = false;
        farmAvailable = false;
        waterstationAvailable = false;
        powerstationAvailable = false;

        //jobUI = GameObject.Find("JobUI").GetComponent<JobUI>();

    }

    void OnMouseUp() {

        // When you click, change the variables value
        if (showMenu)
            showMenu = false;
        else
            showMenu = true;
    }

    void Update() {

        //Check to see if there are any gameobjects with the appropriate building tag, used to toggle the correlated gui buttons

		if (!GameObject.FindWithTag("Farm"))
		{
			farmAvailable = false;
		}
		else {
			farmAvailable = true;
		}
		
		if (!GameObject.FindWithTag("Hospital"))
		{
			hospitalAvailable = false;
			//print("No Tag Found <Hospital>");
		}
		else {
			hospitalAvailable = true;
		}

        if (!GameObject.FindWithTag("WaterStation"))
        {
            waterstationAvailable = false;
            //print("No Tag Found <Hospital>");
        }
        else
        {
            waterstationAvailable = true;
        }

        if (!GameObject.FindWithTag("PowerStation"))
        {
            powerstationAvailable = false;
            //print("No Tag Found <Hospital>");
        }
        else
        {
            powerstationAvailable = true;
        }
    }

    void OnGUI() {

        //Here it becomes a little complex, itterate through all buildings and see what's available. Then create a button to assign an agent to that building, when pressed find all waypoints with the correct building tag and move there.
        switch (showMenu) {
            case true:
            //Check if there is a farm
                switch (farmAvailable){
                    case true:
                        if (GUI.Button(new Rect(10, 10, 100, 20), "Assign Farmer") && (agentLogic.jobState != AgentLogic_07.jobSubState.Farmer))
                        {

                            //Obtain all farm waypoints that the agent should move between when working
                            agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("FarmWaypoint"));

                            //Set the agent to working
                            agentLogic.aState = AgentLogic_07.agentState.Working;

                            //Define the working state as farming
                            agentLogic.jobState = AgentLogic_07.jobSubState.Farmer;
                        }
                        break;

                    case false:
                        StartCoroutine(MissingBuildingError(3.0f, "Farm"));
                        break;

                    default:
                        print("Default reached in GUIToggle_07.cs Line 98");
                        break;
                }

                switch (waterstationAvailable)
                {
                    case true:
                        if (GUI.Button(new Rect(10, 30, 150, 20), "Assign Water Purifier") && (agentLogic.jobState != AgentLogic_07.jobSubState.WaterPurifier))
                        {

                            //Obtain all farm waypoints that the agent should move between when working
                            agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("WaterWaypoint"));

                            //Set the agent to working
                            agentLogic.aState = AgentLogic_07.agentState.Working;

                            //Define the working state as farming
                            agentLogic.jobState = AgentLogic_07.jobSubState.WaterPurifier;
                        }
                        break;

                    case false:
                        StartCoroutine(MissingBuildingError(3.0f, "Water Station"));
                        break;

                    default:
                        print("Default reached in GUIToggle_07.cs Line 98");
                        break;
                }

                switch (powerstationAvailable)
                {
                    case true:
                        if (GUI.Button(new Rect(10, 30, 150, 20), "Assign Power Engineer") && (agentLogic.jobState != AgentLogic_07.jobSubState.PowerWorker))
                        {

                            //Obtain all farm waypoints that the agent should move between when working
                            agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("PowerWaypoint"));

                            //Set the agent to working
                            agentLogic.aState = AgentLogic_07.agentState.Working;

                            //Define the working state as farming
                            agentLogic.jobState = AgentLogic_07.jobSubState.PowerWorker;
                        }
                        break;

                    case false:
                        StartCoroutine(MissingBuildingError(3.0f, "Power Station"));
                        break;

                    default:
                        print("Default reached in GUIToggle_07.cs Line 98");
                        break;
                }

                //Check if there is a hospital
                //if (GameObject.FindWithTag("Hospital")) {
                switch (hospitalAvailable)
                {
                    case true:
                        if (GUI.Button(new Rect(10, 50, 100, 20), "Assign Medic") && (agentLogic.jobState != AgentLogic_07.jobSubState.Medic)) {
                    
                        //Obtain all farm waypoints that the agent should move between when working
                        agentLogic.workWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("HospitalWaypoint"));

                        //Shuffle the order of the waypoints
                        for (int i = 0; i < agentLogic.workWaypoints.Count; i++){

                            //Set the current list value to a temp var
                            GameObject temp = agentLogic.workWaypoints[i];

                            //Obtain a random index value within the scope of the waypoint list size
                            int randomIndex = Random.Range(i, agentLogic.workWaypoints.Count);

                            //Set the current list index to the new shuffled index
                            agentLogic.workWaypoints[i] = agentLogic.workWaypoints[randomIndex];

                            //Replace the contents into the list
                            agentLogic.workWaypoints[randomIndex] = temp;
                        }

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
                        break;
                    case false:

                        //Display warning of missing building with tag hospital
                        StartCoroutine(MissingBuildingError(3.0f, "Hospital"));
                        break;
                    default:
                        print("Default reached in GUIToggle_07.cs Line 150");
                        break;
                }
                break;

            case false:
                
                //Reset warning messages when user closes the GUI
                showError = true;
                break;
        }
    }

    IEnumerator MissingBuildingError(float wait, string building) {

        //showError = true;
        if (showError)
        {
            GUI.Box(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 50, 250, 25), "No Building with tag " + building + " placed...");
            yield return new WaitForSeconds(wait);
            showError = false;
        }

    }

}