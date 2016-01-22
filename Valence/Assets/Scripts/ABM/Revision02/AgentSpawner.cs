using UnityEngine;
using System.Collections;

public class AgentSpawner : MonoBehaviour {

    //Reference agent for spawner, user must assign this in the Inspector
    public GameObject Agent;
    GameController _gameController;
    //Current number of agents alive;
    public int popSize;

    void Start() {
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
        SpawnAgent();
    }

    //On call, spawn a new agent from 05_Revision prefab folder
    void SpawnAgent() {

        GameObject newAgent = (GameObject)Instantiate(Agent, new Vector3(0, 0.51f, 0), Quaternion.identity);

        newAgent.name = "Agent" + newAgent.GetInstanceID();

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
