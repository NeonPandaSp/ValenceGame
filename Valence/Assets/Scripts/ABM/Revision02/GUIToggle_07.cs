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