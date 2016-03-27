using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NonWorkingAgentList : MonoBehaviour {

    public GameController _myGameController;
    public List<GameObject> unAssignedAgents;
    public List<GameObject> workWaypoints;
    List<int> indexMemory = new List<int>();
    public GameObject agentProfile;
    bool stateChange = true;

	// Use this for initialization
	void Start () {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        _myGameController = gameControllerObject.GetComponent<GameController>();

        foreach (Transform child in this.gameObject.transform.root.FindChild("Workwaypoints")) {
            workWaypoints.Add(child.gameObject);
        }
        //GameObject test = Instantiate(agentProfile, agentProfile.transform.position, agentProfile.transform.rotation) as GameObject;
        //test.transform.SetParent(this.transform, false);

        foreach (GameObject agent in _myGameController.unAssignedPopulation) {
            GameObject newobject = Instantiate(agentProfile, agentProfile.transform.position, agentProfile.transform.rotation) as GameObject;
            newobject.transform.SetParent(this.transform, false);
            newobject.GetComponentInChildren<Text>().text = agent.GetComponent<AgentLogic_07>().firstLastName;
            unAssignedAgents.Add(newobject);
            //gameObject.transform;
        }
    }
	
	// Update is called once per frame
	void Update () {
        foreach (GameObject agent in unAssignedAgents) {
            Debug.Log("Root is: " + agent.transform.parent.tag);

            if (agent.transform.parent.tag == "Assigned") {
                ChangeAgentWorkState(unAssignedAgents.IndexOf(agent));
                
                Debug.Log("Current index " + unAssignedAgents.IndexOf(agent));
            }
        }
    }

    void ChangeAgentWorkState(int index) {
        GameObject agent = _myGameController.population[index];

        if (!indexMemory.Contains(index)) {

            switch (this.gameObject.transform.root.GetComponent<BuildingScript>().bType.typeName) {
                case "Farm":
                string tempChildLocation1 = "/" + this.gameObject.transform.root.name + "/Workwaypoints";
                agent.GetComponent<AgentLogic_07>().workWaypoints = workWaypoints;

                agent.GetComponent<AgentLogic_07>().aState = AgentLogic_07.agentState.Working;
                agent.GetComponent<AgentLogic_07>().jobState = AgentLogic_07.jobSubState.Farmer;
                stateChange = false;
                Debug.Log("FARMER NOW!");
                break;

                case "PowerStation":
                string tempChildLocation2 = "/" + this.gameObject.transform.root.name + "/Workwaypoints";
                agent.GetComponent<AgentLogic_07>().workWaypoints = workWaypoints;

                agent.GetComponent<AgentLogic_07>().aState = AgentLogic_07.agentState.Working;
                agent.GetComponent<AgentLogic_07>().jobState = AgentLogic_07.jobSubState.PowerWorker;
                stateChange = false;
                Debug.Log("PowerWorker NOW!");
                break;

                case "WaterStation":
                string tempChildLocation3 = "/" + this.gameObject.transform.root.name + "/Workwaypoints";
                agent.GetComponent<AgentLogic_07>().workWaypoints = workWaypoints;

                agent.GetComponent<AgentLogic_07>().aState = AgentLogic_07.agentState.Working;
                agent.GetComponent<AgentLogic_07>().jobState = AgentLogic_07.jobSubState.Hydrologist;
                stateChange = false;
                Debug.Log("WaterWorker NOW!");
                break;
            }
            Debug.Log("Agent Name: " + agent.GetComponent<AgentLogic_07>().firstLastName);
        } else {
            indexMemory.Add(index);
        }
    }
}
