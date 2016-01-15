using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Pathfinding;

public class AgentLogic_07 : MonoBehaviour {

    //Point agent will move to
    //public Transform target;

    //List of all work waypoints
    public List<GameObject> workWaypoints = new List<GameObject>();

    //List of all waypoints agent can wander to
    public List<Vector3> wanderWaypoints = new List<Vector3>();

    //List all waypoints found on the storage facility
    public List<GameObject> storageWaypoints = new List<GameObject>();

    //Dictates the max number of waypoints agent can wander to
    public int wanderListSize = 10;

    //Keep track of the current waypoint the agent moves to when working
    //Counter associated to workWaypoints & wanderWaypoints list index
    int workWaypointIndex, wanderWaypointIndex, storageWaypointIndex;

    //Check if a target has been assigned, if yes wait, otherwise assign a new target
    bool assignedTarget;

    //Check if the current agent has been assigned to the correct list
    bool populateList;


    AIFollow_07 aiFollow;
    GameController gameController;

	public enum agentState
	{
		Wandering,
		Hungry,
		Working,
		Default
	}

    public enum jobSubState
    {
        Default,
        Farmer,
        Medic,
        WaterPurifier,
        PowerWorker
    }

    public agentState aState;
    public jobSubState jobState;

    //Variable used to save the last active state
    public agentState currentState;

    void Start(){

        
        aiFollow = GetComponent<AIFollow_07>();

       
        wanderWaypoints = new List<Vector3>();

        //Populate the following waypoints when an agent is spawned
        while (wanderWaypoints.Count < wanderListSize) {
            wanderWaypoints.Add(new Vector3(Random.Range(0, 160), 0, Random.Range(0, 120)));
        }

        storageWaypoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("StorageWaypoint"));

        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        workWaypointIndex = 0;
        wanderWaypointIndex = 0;
        storageWaypointIndex = Random.Range(0, storageWaypoints.Count);
        
        assignedTarget = false;
        populateList = false;

        //When an agent spawns, he should start by wandering
        aState = agentState.Wandering;

	}

	void Update() {
		switch (aState) {

            case agentState.Wandering:

                aiFollow.target = wanderWaypoints[wanderWaypointIndex];
                break;
		    case agentState.Hungry:
                aiFollow.target = storageWaypoints[storageWaypointIndex].transform.position;
                break;
			
		    case agentState.Working:
               
                //Agent can be assigned various jobs each with their own behaviour
                switch (jobState) {
                    case jobSubState.Farmer:

                        //Set the agent to move towards the farm waypoints
                        aiFollow.target = workWaypoints[workWaypointIndex].transform.position;

                        //Add the agent to the list of farmers
                        
                        if (!populateList)
                        {
                            gameController.farmerList.Add(this.gameObject);
                            populateList = true;
                        }
                        break;
                    case jobSubState.Medic:

                        aiFollow.target = workWaypoints[workWaypointIndex].transform.position;

                        break;

                    case jobSubState.WaterPurifier:

                        aiFollow.target = workWaypoints[workWaypointIndex].transform.position;

                        break;

                    case jobSubState.PowerWorker:

                        aiFollow.target = workWaypoints[workWaypointIndex].transform.position;

                        break;

                    case jobSubState.Default:

                        print("Default reached in Working SubState in AgentLogic_07 Update");

                        break;

                }
                    

			    break;

            case agentState.Default:

                print("Default reached in AgentLogic_07 Update");

                break;

        }
	}

	bool PointInsideSphere(Vector3 point, Vector3 center, float radius) {
		print ("Dis" + Vector3.Distance(point, center));
		print ("inside: " + (Vector3.Distance(point, center) < radius));
		return Vector3.Distance(point, center) < radius;
	}

	public void TargetReached(){


        if (aState == agentState.Wandering){

            wanderWaypointIndex = Random.Range(0, wanderWaypoints.Count);
            aiFollow.target = wanderWaypoints[wanderWaypointIndex];

        }   else if (aState == agentState.Working){

            workWaypointIndex = Random.Range(0, workWaypoints.Count);
            aiFollow.target = workWaypoints[workWaypointIndex].transform.position;

        }   else if (aState == agentState.Hungry){

            //Reset hunger level or start replenishing
            //Go back to previous task
            aState = currentState;

            //Need to Update the wait length to take into account the % of hunger missing (Higher hunger missing = longer wait time)

        }



        /*
		 * if State1 
		 * 	do this
		 * if State2
		 * 	do this
		 * if State3
		 * 	do this
		 * if State4
		 * 	do this
		 * 
		 */
    }
}
