using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine.UI;

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

	//Check if this agent is newly created or is a copy of an older agent
	public bool newAgent = true;

    //Check if a target has been assigned, if yes wait, otherwise assign a new target
    bool assignedTarget;

    //Check if the current agent has been assigned to the correct list
    bool populateList;

    //Check if the agent has food, if yes then consume the food, else start starving
    bool hasFood;

    //Check if the agent is hungry, if true the go to a known foodsource
    bool isHungry;

    //Check if the agent has died
    bool isDead;
	
    //Agent stores 5% of food found in storage facility
    public float foodStored;

    //0-100 int which holds the agent's current hunger level. 0% = full, 100% = starving 
    public int hungerValue;

    //0-100 int which holds the agent's current happiness level. 0% = depressed, 100% = happy 
    public int moraleLevel;

    //0-100 int which holds the agent's current health. 0%= dead, 100% = perfectly healthy
    public int health;

    //0-100 float which holds the likelyhood the agent will act (passed to the Choose() to bias the outcome)
    public float perception;

	//Settler Name
	public AgentLogic_07 agentLogic;
	public string firstLastName;
	public string settlerNameAndRole;

	int randomFirstName;
	int randomLastName;
	string[] maleFirstNameArray;
    string[] femaleFirstNameArray;
	string[] lastNameArray;

    //String array containing the gender of the agent
    string[] genderArray;
    //Index position of genderArray
    int randomGender;
    //String containing the randomly assigned gender
    public string gender;

    //	public GUIController_SettlerInfo _GUIController_SettlerInfo;
    //	public Text hiTHERE;

    int amount = 0;

    //wait time checks if WanderOrIdle function is currently pending
    float wait = 3;

	public int modelIndex; //Used to track models - TYLER

    AIFollow_07 aiFollow;
    GameController gameController;
    //Agent animator component
    Animator agentAnim;

    public enum agentState
	{
        Wandering,
        Idle,
		Hungry,
		Working,
        Dead,
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
    //Todo, change this to be a list which saves the last ie. 5 states... 
    public agentState currentState;

    void Start(){
        //_GUIController_SettlerInfo = GameObject.Find ("Folk_Female_Agent").GetComponent<GUIController_SettlerInfo> ();
        if (newAgent) {

            //Gender
            genderArray = new string[2] {
                "Male",
                "Female"
            };

			//Name
			maleFirstNameArray = new string[21] {
                "Daron",
                "Bernardo",
                "Grady",
                "Willie",
                "Mark",
                "Malcolm",
                "Trevor",
                "Len",
                "Tod",
                "Randy",
                "Gail",
                "Kurt",
                "Alexis",
                "Winford",
                "Luigi",
                "Jake",
                "Reggie",
                "Loyd",
                "Darron",
                "Tyler",
                "Zachary"
            };

            femaleFirstNameArray = new string[20] {
                "Joye",
                "Argelia",
                "Candelaria",
                "Sheryll",
                "Carma",
                "Sheri",
                "Anita",
                "Magdalena",
                "Laryssa",
                "Zachary-a",
                "Darcie",
                "Sari",
                "Shayna",
                "Thea",
                "Maryanna",
                "Sanora",
                "Deedra",
                "Wanda",
                "Creola",
                "Weri"
            };

            lastNameArray = new string[14] {
				"Hawthorne",
				"Hazlewood",
				"Beckett",
				"Polo",
				"Mordecai",
				"McKnight",
				"Kerrigan",
				"Kellerman",
				"Stone",
				"Drake",
				"Richards",
				"Fontana",
				"Bob",
				"Steele"
			};
		
			randomFirstName = UnityEngine.Random.Range (0, 14);
			randomLastName = UnityEngine.Random.Range (0, 14);
            randomGender = Random.Range(0, (genderArray.Length));

            //Assigned gender to the agent
            //gender = genderArray[randomGender];

            //Name - variable firstLastName outputs first and last name. variable settlerNameAndRole outputs name, what settler is currently doing, and their assigned role
            if (gender == "Male"){
                firstLastName = (maleFirstNameArray[randomFirstName] + " " + lastNameArray[randomLastName]);
            }
            else {
                firstLastName = (femaleFirstNameArray[randomFirstName] + " " + lastNameArray[randomLastName]);
            }
            

            //Init the agent's hunger value to 0 when spawned (they shouldnt be hungry at start)
            hungerValue = 0;
			//Init the agent's health to 100 when spawned (they should be perfectly healthy)
			health = 100;
			//Init the agent's happyness to 100 when spawned (they should be perfectly happy)
			moraleLevel = 100;
            //Init the agent's perception to 10% when spawned (this is the standard starting value for all agents)
            perception = 10;
        }
		aiFollow = GetComponent<AIFollow_07> ();
		wanderWaypoints = new List<Vector3> ();

		//Populate the following waypoints when an agent is spawned
		while (wanderWaypoints.Count < wanderListSize) {
			wanderWaypoints.Add (new Vector3 (Random.Range (-25, 50), 0, Random.Range (-16, 25)));
		}

		//Get all storage waypoints when the agent is spawned, agent should know a known food source at spawn
		storageWaypoints = new List<GameObject> (GameObject.FindGameObjectsWithTag ("StorageWaypoint"));

        agentAnim = GetComponent<Animator>();

		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();

		//init all waypoint index's to 0 and set the storage waypoint indext to a random value within the scope of the storage list
		workWaypointIndex = 0;
		wanderWaypointIndex = 0;
		storageWaypointIndex = Random.Range (0, storageWaypoints.Count);
        
		//Agent should  have no current assigned target
		assignedTarget = false;

		//Agent should not have populated any worker lists
		populateList = false;

        //When the agent spawns, there is a 50% chance to spawn idle or wander
        WanderOrIdle(50.0f);

        if (aState == null){
            //When an agent spawns, he should start by wandering if there is no starting state
            aState = agentState.Wandering;
		}

        //Once everything has been set, begin consuming resources
        BeginFeeding();
    }

	void LateUpdate() {
             
        if (aState == agentState.Working) {
			settlerNameAndRole = firstLastName + " the " + jobState + " (" + aState + ")";
		}
		else {
			//Resetting random name and attributes
			settlerNameAndRole = firstLastName + " (" + aState + ")";
		}

        //Check if the agent has run out of health
        if (health <= 0 && isDead == false)
        {
            //Stop the agent from moving
            aiFollow.Stop();
            aState = agentState.Dead;
            //Play a death animation
            agentAnim.SetTrigger("Dead");

            //Ensure the agent only triggers this logic once
            isDead = true;
            //Destroy(this.gameObject);
        }

        switch (aState)
        {
            case agentState.Idle:
                //Save the current state
                currentState = aState;

                agentAnim.SetBool("Walking", false);
                agentAnim.SetBool("Idle", true);

                aiFollow.Reset();

                //yield return new WaitForSeconds(3.0f);

                if (wait > 0)
                {
                    wait -= Time.deltaTime;
                    print("wait" + wait);

                }
                else { 
                    WanderOrIdle(50.0f);
                    wait = Random.Range(3, 10);
                }
                break;
            case agentState.Wandering:
                //Save the current state
                currentState = aState;

                agentAnim.SetBool("Walking", true);
                agentAnim.SetBool("Idle", false);
                //Set the current target to move towards
                aiFollow.target = wanderWaypoints[wanderWaypointIndex];

                //remove this agent from all worker lists
                //Todo do this with a function call
                gameController.farmerList.Remove(this.gameObject);

                break;
            case agentState.Hungry:

                aiFollow.target = storageWaypoints[storageWaypointIndex].transform.position;

                //remove this agent from all worker lists
                //Todo do this with a function call
                gameController.farmerList.Remove(this.gameObject);
                populateList = false;
                break;

            case agentState.Dead:
                aiFollow.Reset();
                break;

            case agentState.Working:
                currentState = aState;
                //Agent can be assigned various jobs each with their own behaviour
                switch (jobState)
                {
                    case jobSubState.Farmer:

                        //Set the agent to move towards the farm waypoints
                        aiFollow.target = workWaypoints[workWaypointIndex].transform.position;

                        //Add the agent to the list of farmers 
                        //Todo: Should update this to a function which when called takes a passed value of the substate and adds this agent to the correct list
                        if (!gameController.farmerList.Contains(this.gameObject))
                        {
                            gameController.farmerList.Add(this.gameObject);
                            //populateList = true;
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

                        if (!populateList)
                        {
                            gameController.powerWorkerList.Add(this.gameObject);
                            populateList = true;
                        }
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

    IEnumerator WaitForSeconds(float wait) {
        yield return new WaitForSeconds(wait);
    } 

    //Choose between idle or wander with a given chance
    agentState WanderOrIdle(float chance) {


        if (Choose(chance))
        {
            print("IDELASSKDHAKSJDH");
            return aState = agentState.Idle;
        }
        else
        {
            return aState = agentState.Wandering;
        }


        //WaitForSeconds(wait);
    }

    //When called, the agent will begin consuming resources needed to live (food, water)
    public void BeginFeeding() {

        Debug.Log("Agent has begun consuming resources...");
        //Repeat the function ConsumeResource, for 1 second, every 1 second
        InvokeRepeating("ConsumeResource", 1.0f, 3.0f);
    }
            
    //When the agent's hunger % reaches a critial amount, then switch the current state of the agent to hunger state (search for food)
    void ConsumeResource() {

        //Todo: need to update this function to take into account the current food the agent has collected...
        //ie. once they collect 100 food ONLY start increasing the hungerValue once he has finished feeding on that 100 food
        if (hungerValue >= 100)
        {
            health--;
        }

        switch (hasFood) {
            case true:

                //Check that there still is food stored
                if (foodStored > 0) {
                    //if yes then decrease the amount of food stored on the agent and increase their health
                    foodStored--;

                    if (health > 100){
                        //Increase the missing health of the agent when eating food
                        health++;
                    }
                    else {
                        //Do nothing
                    }

                    
                }
                else {
                    //if there is no more food stored on the agent, then start starving the agent
                    foodStored = 0;
                    hasFood = false;
                }

            break;
            case false:
                //check if the agent's hunger% has reached 25%, otherwise keep increasing the hungerValue
                //Todo update this if statement to check boolean, boolean set based on probability

                if (hungerValue >= 100){
                    hungerValue = 100;
                } else {
                    //Increase the current hunger value of the agent by 1
                    hungerValue++;
                }
                //Bool set if true then change state to hungry
                if (isHungry) { 
                    //if yes then set the agent's state to hungry, but first save the previous state..
                    //so the agent may return to it after feeding

                    aState = agentState.Hungry;
                }
                else {                    
                    //Todo: need to incorporate a probability factor that is affected by the current hunger value %, higher % = higher probablility to change Astate to hungry
                    
                    //Throw a series of dice at each milestone 25,50,75% hunger, if any dice roll true, then move to the food source
                    switch (hungerValue) {
                        case 25:

                            if (!isDead)
                            {
                                //Play hunger animation
                                //Pause the ai pathfinding to play an animation, pass anim state name 
                                StartCoroutine(PlayAnimPauseAI("Hungry"));


                                //if the agent reaches 25% hunger throw a dice with 10% probability of success
                                isHungry = Choose(perception);
                            }
                        break;

                        case 50:
                            if (!isDead)
                            {
                                //Play hunger animation
                                //Pause the ai pathfinding to play an animation, pass anim state name 
                                StartCoroutine(PlayAnimPauseAI("Hungry"));
                                for (amount = 0; amount < 3; amount++)
                                    if (!isHungry)
                                    {
                                        //if the agent reaches 50% hunger throw a dice with 35% probability of success
                                        isHungry = Choose(perception);
                                    }
                            }
                        break;

                        case 75:
                            if (!isDead)
                            {
                                //Play hunger animation
                                //Pause the ai pathfinding to play an animation, pass anim state name 
                                StartCoroutine(PlayAnimPauseAI("Hungry"));
                                for (amount = 0; amount < 6; amount++)
                                    if (!isHungry)
                                    {
                                        //if the agent reaches 75% hunger throw a dice with 65% probability of success
                                        isHungry = Choose(perception);
                                    }
                            }
                        break;

                        case 100:
                            if (!isDead)
                            {
                                StartCoroutine(CheckFoodSource());
                            }
                           // isHungry = Choose(101);
                        break;
                    }
                    
                //Choose(hungerValue);
                }
            break;
            default:
                Debug.Log("Default reached in AgentLogic_07 - ConsumeResource function");
            break;
        }
    }

    IEnumerator PlayAnimPauseAI(string animation) {
        agentAnim.SetTrigger(animation);
        aiFollow.Stop();
        //AnimationState animState;
        //animState = GetComponent<AnimationState>();
        //Wait for animation to finish playing
        yield return new WaitForEndOfFrame();
        yield return new WaitForSeconds(agentAnim.GetCurrentAnimatorClipInfo(0).Length);
        aiFollow.Resume();
    }

    IEnumerator CheckFoodSource() {
        yield return new WaitForSeconds(10.0f);
        //Play hunger animation
        //Pause the ai pathfinding to play an animation, pass anim state name 
        StartCoroutine(PlayAnimPauseAI("Hungry"));
        if (!isDead)
            isHungry = true;
        else
            isHungry = false;
    }

    bool Choose(float probability) {

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

        if (Random.Range(1.0f, 100.0f) < probability) {
            // will be true 10% of the time
            Debug.Log("True");
            return true;
        }
        else {
            Debug.Log("False");
            return false;
        }
    }

	bool PointInsideSphere(Vector3 point, Vector3 center, float radius) {
		print ("Dis" + Vector3.Distance(point, center));
		print ("inside: " + (Vector3.Distance(point, center) < radius));
		return Vector3.Distance(point, center) < radius;
	}

    IEnumerator DelayNewWorkTarget(Transform waypoint) {
        //Wait for how ever long it takes to play the work animation

        Vector3 targetPostition = new Vector3(workWaypoints[workWaypointIndex].transform.parent.gameObject.transform.position.x,
                                       this.transform.position.y,
                                       workWaypoints[workWaypointIndex].transform.parent.gameObject.transform.position.z);
        this.transform.LookAt(targetPostition);

        //transform.LookAt(workWaypoints[workWaypointIndex].transform.parent.gameObject.transform);
        agentAnim.SetBool("Working", true);
        aiFollow.Stop();

        //Wait for animation to finish playing
        yield return new WaitForSeconds(agentAnim.GetCurrentAnimatorStateInfo(0).length);
        
        //Wait for exact animation time before exit
        //yield return new WaitForSeconds(5.33f);

        agentAnim.SetBool("Working", false);
        workWaypointIndex = Random.Range(0, workWaypoints.Count);
        aiFollow.Resume();
        //aiFollow.target = waypoint.position;
    }

    public void TargetReached(){
        if (aState == agentState.Wandering){

            //50% chance when target is reached, to stop and idle or find a new target
            if (Choose(50.0f)){
                aState = agentState.Idle;
            }
            else{
                wanderWaypointIndex = Random.Range(0, wanderWaypoints.Count);
                aiFollow.target = wanderWaypoints[wanderWaypointIndex];
            }   

        }   else if (aState == agentState.Working){

            //workWaypointIndex = Random.Range(0, workWaypoints.Count);
            StartCoroutine(DelayNewWorkTarget(workWaypoints[workWaypointIndex].transform));
            aiFollow.target = workWaypoints[workWaypointIndex].transform.position;

        }   else if (aState == agentState.Hungry){

            //Reset hunger level or start replenishing
            //Todo slowly start decreasing hunger value
            
            isHungry = false;

            //Give the agent 10% of the current food stored
            //Todo need to figureout a beter method for this algorithm
            foodStored = 10;
            gameController.food -= foodStored;

            if (foodStored > 0) {
                hungerValue = 0;
            }
            else {
                //The agent is now starving!
                Debug.Log("Agent is starving!");
            }

            //Tell the agent that they current have food and should not starve
            hasFood = true;

            //Todo need to check if there is actually food available for the agent to feed on
            //ADD HERE
             
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
