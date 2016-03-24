using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NonWorkingAgentList : MonoBehaviour {

    public GameController _myGameController;
    public List<GameObject> unAssignedAgents;
    public GameObject agentProfile;
    //public DragHandler dragHandler;

	// Use this for initialization
	void Start () {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        _myGameController = gameControllerObject.GetComponent<GameController>();

        unAssignedAgents = _myGameController.unAssignedPopulation;

        //GameObject test = Instantiate(agentProfile, agentProfile.transform.position, agentProfile.transform.rotation) as GameObject;
        //test.transform.SetParent(this.transform, false);

        foreach (GameObject agent in _myGameController.unAssignedPopulation) {
            GameObject newobject = Instantiate(agentProfile, agentProfile.transform.position, agentProfile.transform.rotation) as GameObject;
            newobject.transform.SetParent(this.transform, false);
            newobject.GetComponentInChildren<Text>().text = agent.GetComponent<AgentLogic_07>().firstLastName;
            //gameObject.transform;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
