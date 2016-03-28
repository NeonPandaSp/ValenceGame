using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NonWorkingAgentList : MonoBehaviour {

    public GameController _myGameController;
    public List<GameObject> unAssignedAgents;
    public List<GameObject> workWaypoints;

    public Transform AssignedList;
    public Transform unAssignedList;

    List<int> workerIndexMemory = new List<int>();
    List<int> wanderIndexMemory = new List<int>();
    List<int> agentAddIndexMemory = new List<int>();

    public GameObject agentProfile;
    bool stateChange = true;

    bool UnlockComplete = true;
    bool assigned = false;
    // Use this for initialization
    void Start () {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        _myGameController = gameControllerObject.GetComponent<GameController>();

        foreach (Transform child in this.gameObject.transform.root.FindChild("Workwaypoints")) {
            workWaypoints.Add(child.gameObject);
        }
        //GameObject test = Instantiate(agentProfile, agentProfile.transform.position, agentProfile.transform.rotation) as GameObject;
        //test.transform.SetParent(this.transform, false);

        /*foreach (GameObject agent in _myGameController.unAssignedPopulation) {
            GameObject newobject = Instantiate(agentProfile, agentProfile.transform.position, agentProfile.transform.rotation) as GameObject;
            newobject.transform.SetParent(this.transform, false);
            newobject.GetComponentInChildren<Text>().text = agent.GetComponent<AgentLogic_07>().firstLastName;
            newobject.name = agent.name;
            unAssignedAgents.Add(newobject);
            
            //gameObject.transform;
        }*/
    }
	
	// Update is called once per frame
	void Update () {

        //unAssignedAgents.Count = _myGameController.unAssignedPopulation.Count;

        if (unAssignedAgents.Count < _myGameController.unAssignedPopulation.Count)
        {
            foreach (GameObject agent in _myGameController.unAssignedPopulation)
            {
                //if (UnlockComplete == true)
                //{
                UpdateAgents(agent);
                UnlockComplete = false;
                //}
            }
        }   
        else {
            /*foreach (GameObject agent in unAssignedAgents) {
                if (!assigned && _myGameController.population[unAssignedAgents.IndexOf(agent)].GetComponent<AgentLogic_07>().aState == AgentLogic_07.agentState.Working) {
                    Debug.Log("SHDKJASHDKSJAHDKJASHAD: " + _myGameController.population[unAssignedAgents.IndexOf(agent)].name);
                    //agent.transform.parent.tag = "Assigned";
                    agent.transform.SetParent(AssignedList);
                    assigned = true;
                }
                if (assigned && _myGameController.population[unAssignedAgents.IndexOf(agent)].GetComponent<AgentLogic_07>().aState == AgentLogic_07.agentState.Wandering){
                
                    Debug.Log("SHDKJASHDKSJAHDKJASHAD: " + _myGameController.population[unAssignedAgents.IndexOf(agent)].name);
                    //agent.transform.parent.tag = "Assigned";
                    agent.transform.SetParent(unAssignedList);
                    assigned = false;
                }
            }*/

            foreach (GameObject agent in unAssignedAgents) {

            }
        }

            /*foreach (GameObject agent in unAssignedAgents)
            {

              if (!_myGameController.unAssignedPopulation.Contains(agent)) {
                    Destroy(agent);
                    //unAssignedAgents.Remove(agent);
                    //Debug.Log(agent);
                }
                //gameObject.transform;
            }*/

        foreach (GameObject agent in unAssignedAgents) {
            //Debug.Log("Root is: " + agent.transform.parent.tag);

            if (agent.transform.parent.tag == "Assigned") {
                ChangeAgentWorkState(unAssignedAgents.IndexOf(agent));
                //_myGameController.unAssignedPopulation.Remove(_myGameController.unAssignedPopulation[unAssignedAgents.IndexOf(agent)]);
                //unAssignedAgents.Remove(agent);
                //Debug.Log("Current index " + unAssignedAgents.IndexOf(agent));
            }
            else if (agent.transform.parent.tag == "Unassigned")
            {
                workerIndexMemory.Remove(unAssignedAgents.IndexOf(agent));
                ChangeAgentWanderState(unAssignedAgents.IndexOf(agent));
                
                //Debug.Log("Current index " + unAssignedAgents.IndexOf(agent));
            }
        }
    }

    void UpdateAgents(GameObject agent) {
        //foreach (GameObject agent in _myGameController.unAssignedPopulation)
        //{
            GameObject newobject = Instantiate(agentProfile, agentProfile.transform.position, agentProfile.transform.rotation) as GameObject;
            newobject.transform.SetParent(this.transform, false);
            
            
            newobject.GetComponentInChildren<Text>().text = agent.GetComponent<AgentLogic_07>().firstLastName;
            newobject.name = agent.name;

            unAssignedAgents.Add(newobject);
            UnlockComplete = true;
            //gameObject.transform;
        //}

    }

    void ChangeAgentWorkState(int index) {
        GameObject agent = _myGameController.population[index];

        if (!workerIndexMemory.Contains(index)) {
            
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
            workerIndexMemory.Add(index);
        }
    }

    void ChangeAgentWanderState(int index)
    {
        GameObject agent = _myGameController.population[index];

        if (!wanderIndexMemory.Contains(index)){
   
            agent.GetComponent<AgentLogic_07>().aState = AgentLogic_07.agentState.Wandering;
            workerIndexMemory.Remove(index);

            Debug.Log("Wander NOW!");
         
            Debug.Log("Agent Name: " + agent.GetComponent<AgentLogic_07>().firstLastName);
        }
        else
        {
            wanderIndexMemory.Add(index);
        }
    }
}
