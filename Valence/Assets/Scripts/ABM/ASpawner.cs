using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ASpawner : MonoBehaviour {
	
	public GameObject Agent;
	
	public List<GameObject> agentList;

	public List<int> hungerValList;

	public int hungerSearch = 50;
	
	public int hungerValue = 100;
	
	private float agentRotation;
	
	public int spawnCounter;
	
	float startTime;
	
	public int currentSpawnCount;
	
	int targetIndex;
	
	Vector3[] path;
	
	GameObject foodSource;

	public State state;

	TestMovement _testMovement;

	bool feeding = false;

	public enum State
	{
		Wander,
		Hunger,
		Feed
		//States go here
	}
	
	void Awake() {
		startTime = Time.deltaTime;
		
		_testMovement = Agent.GetComponent<TestMovement>();


		state = State.Wander;
		//agentArr = new GameObject[spawnCounter];
		agentList = new List<GameObject>();

		hungerValList = new List<int>();

		StartCoroutine(InstantiateAgent());


		//Uncomment to enable hunger actions
		//InvokeRepeating("AgentHunger", 1, 1);
		
		//StartCoroutine(FSM());
	}
	
	void Start()
	{

		foodSource = GameObject.FindWithTag("Foodsource");


	}
	
	IEnumerator AgentHunger(int _agentPos)
	{
		/*
			if(!feeding){
				while(true && !feeding){
					if (hungerValList[_agentPos] > 0)
					{
						hungerValList[_agentPos]--;

						yield return new WaitForSeconds(1.0f);
						Debug.Log(hungerValList[_agentPos]);

					}

				
					if (hungerValList[_agentPos] <= hungerSearch)
					{
						//Vector3 destination = foodSource.transform.position;
						state = State.Hunger;
					}
				}

			}

			else{
				while(true && feeding){
					if(hungerValList[_agentPos] < 100){
						hungerValList[_agentPos]++;
						yield return new WaitForSeconds(1.0f);
					}
				}
			}*/
		yield return null;
	}

	void FixedUpdate(){
		//Debug.Log(state.ToString());
	}
	
	IEnumerator FSM(int _agentPos)
	{	

		while (true)
		{

		
			yield return StartCoroutine(state.ToString(), (_agentPos));
			;

		}
	}
	
	IEnumerator Wander(int _agentPos)
	{
		//agentList[_agentPos].GetComponent<TestMovement>().hungry = false;
		//Pass wander state to testmovement
		//_testMovement.hungry = false;
		yield return null;
		
		
	}
	
	IEnumerator Hunger(int _agentPos)
	{
		
		//Pass Hunger state to testmovement
		//agentList[_agentPos].GetComponent<TestMovement>().hungry = true;
		//_testMovement.hungry = true;
		yield return null;
	}

	IEnumerator Feed(int _agentPos){

		feeding = true;

		if(hungerValList[_agentPos] < 100){
			hungerValList[_agentPos] ++;
		} 	

		if (hungerValList[_agentPos] == 100){
			state = State.Wander;
		}


		yield return new WaitForSeconds(1.0f);
	}
	
	IEnumerator InstantiateAgent()
	{
		//Add agent spawn
		
		for (int i = 0; i <= spawnCounter - 1; i++)
		{
			
			GameObject newAgent = (GameObject)Instantiate(Agent, new Vector3(50, 0.51f, 50), Quaternion.identity);
			
			newAgent.name = "Agent" + newAgent.GetInstanceID();
			
			agentList.Add(newAgent);
			hungerValList.Add(hungerValue);
			StartCoroutine(FSM(i));
			StartCoroutine(AgentHunger(i));

			yield return new WaitForSeconds(5.0f);
		}
		
		/* while (spawnCounter < 10) {
            GameObject newAgent = (GameObject)Instantiate(Agent, new Vector3(0, 0.51f, 0), Quaternion.identity);

             newAgent.name = "Agent" + newAgent.GetInstanceID();

             spawnCounter++;

             yield return new WaitForSeconds(5.0f);
         }
     }*/
		yield return null;
	}
	
	IEnumerator DirectionChoice()
	{
		agentRotation = Random.Range(-360.0f, 360.0f);
		
		yield return 0;
	}
	
}
