using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AgentSpawner : MonoBehaviour {

    //Reference agent for spawner, user must assign this in the Inspector
    public List<GameObject> MaleAgent;
    public List<GameObject> FemaleAgent;
    GameController _gameController;
    //Current number of agents alive;
    public int popSize;

    public List<GameObject> AgentPopulation;

    void Start() {
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();


        for (int i = 0; i < 4; i++){
            SpawnAgent();
        }
    }

    //On call, spawn a new agent from 05_Revision prefab folder
    void SpawnAgent() {

        //Choose to spawn a male or female agent with a 50% chance
        //if true then spawn a male else female
        if (Choose(50.0f)){
            //Spawn a new agent prefab at origin
            GameObject newAgent = (GameObject)Instantiate(MaleAgent[Random.Range(0, MaleAgent.Count)], new Vector3(Random.Range(-3.0f, 3.0f), 0.51f, 0), Quaternion.identity);

            //Add the agent to the population database
            _gameController.population.Add(newAgent);

            AgentPopulation.Add(newAgent);

            //Provide the agent with a new name
            newAgent.name = "Agent" + newAgent.GetInstanceID();

            newAgent.GetComponent<AgentLogic_07>().gender = "Male";

            //Increase the population UI text by 1
            popSize += 1;
        }
        else {
            //Spawn a new agent prefab at origin
            GameObject newAgent = (GameObject)Instantiate(FemaleAgent[Random.Range(0,FemaleAgent.Count)], new Vector3(Random.Range(-3.0f, 3.0f), 0.51f, 0), Quaternion.identity);

            //Add the agent to the population database
            _gameController.population.Add(newAgent);

            AgentPopulation.Add(newAgent);

            //Provide the agent with a new name
            newAgent.name = "Agent" + newAgent.GetInstanceID();

            newAgent.GetComponent<AgentLogic_07>().gender = "Female";

            //Increase the population UI text by 1
            popSize += 1;
        }

        

    }

    bool Choose(float probability){

        //Calc the bayes theorm on probability of hunger after 100 tries at 20%
        /*float probability = 0.20f;
        float tempVal = 0;
        float tempVal2 = 0;
        Debug.Log("Probability: " + probability);
        for (int i = 1; i <= 100; i++) {
            tempVal = ((i * probability) * Mathf.Pow((1 - probability), i - 1));
            tempVal2 += tempVal;
            Debug.Log("Probability: " + tempVal2);
        }*/

        if (Random.Range(1.0f, 100.0f) < probability)
        {
            // will be true 10% of the time
            Debug.Log("True");
            return true;
        }
        else
        {
            Debug.Log("False");
            return false;
        }
    }

    void OnGUI() {

        if (popSize < _gameController.popLimit) {
            if (GUI.Button(new Rect(Screen.width - 100, 10, 100, 20), "Create Agent")) {
                SpawnAgent();
            }
        }
    }
}
