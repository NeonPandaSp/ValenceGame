using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AgentSpawner : MonoBehaviour {

    //Reference agent for spawner, user must assign this in the Inspector
    public GameObject Agent;
    GameController _gameController;
    //Current number of agents alive;
    public int popSize;

    public List<GameObject> AgentPopulation;

    void Start() {
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();

        //SpawnAgent();
    }

    //On call, spawn a new agent from 05_Revision prefab folder
    void SpawnAgent() {
    
        //Spawn a new agent prefab at origin
        GameObject newAgent = (GameObject)Instantiate(Agent, new Vector3(0, 0.51f, 0), Quaternion.identity);

        //Add the agent to the population database
        _gameController.population.Add(newAgent);

        //Provide the agent with a new name
        newAgent.name = "Agent" + newAgent.GetInstanceID();

        //Increase the population UI text by 1
        popSize += 1;

    }

    void OnGUI() {

        if (popSize < _gameController.popLimit) {
            if (GUI.Button(new Rect(Screen.width - 100, 10, 100, 20), "Create Agent")) {
                SpawnAgent();
            }
        }
    }
}
