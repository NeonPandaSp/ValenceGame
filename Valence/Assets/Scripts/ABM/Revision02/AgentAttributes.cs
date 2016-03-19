using UnityEngine;
using System.Collections;

public class AgentAttributes : MonoBehaviour {

	public AIFollow_07 aiFollow;
    public AgentLogic_07 agentLogic;

	public float agentStrength;
	public float agentAgility;
	public float agentPerception;

	// Use this for initialization
	void Start () {
		if( GetComponent<AgentLogic_07>().newAgent )
			initAttributes ();
		//Apply the attribute values to corresponding agent ability

		SetStrength ();
		SetPerception ();
		SetAgility ();
	}

	void initAttributes(){
		//Init all attributes with a random value (pass a min max range)
		agentAgility = randomStat();
		agentPerception = randomStat();
        agentStrength = randomStat ();
	}
	int randomStat(){
		int randVal = (int) Random.Range (0, 100);
		if (randVal < 50)
			return 1;
		else if (randVal < 75)
			return 2;
		else if (randVal < 87)
			return 3;
		else if (randVal < 93)
			return 4;
		else if (randVal < 96)
			return 5;
		else if (randVal < 98)
			return 6;
		else if (randVal < 99)
			return 7;
		else
			return 8;
	}
	//When called Initialize return a random value between range 1 ~ 10
	float AttributeInit(float min, float max){

		float tempValue = Random.Range (min, max);
		tempValue = Mathf.Round (tempValue * 1.0f) / 1.0f;
		return(tempValue);
	}

	//	
	public void SetAgility(){

		float tempAgility = agentAgility / 10;
		float tempSpeed = aiFollow.speed * tempAgility;

		aiFollow.speed = aiFollow.speed + tempSpeed;

		/*float tempSpeed = (agentAgility - aiFollow.speed);
		tempSpeed = ((tempSpeed/aiFollow.speed)*100);
		aiFollow.speed = tempSpeed;*/
	}

    public void SetPerception(){

        float tempPerception = agentPerception / 10;
        float tempValue = agentLogic.perception * agentPerception;

        agentLogic.perception = agentLogic.perception + tempValue;
    }

    public void SetStrength(){

        float tempStrength = agentStrength * 100/10;
        float tempSTR = aiFollow.speed * tempStrength;

        agentLogic.consumeRate = agentLogic.consumeRate + tempSTR;

        //aiFollow.speed = aiFollow.speed + tempSpeed;

        /*float tempSpeed = (agentAgility - aiFollow.speed);
		tempSpeed = ((tempSpeed/aiFollow.speed)*100);
		aiFollow.speed = tempSpeed;*/
    }
}
