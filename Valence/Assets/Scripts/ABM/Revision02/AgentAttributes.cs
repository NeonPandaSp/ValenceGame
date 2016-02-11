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
		agentAgility = AttributeInit (0.0f, 10.0f);
		agentPerception = AttributeInit (0.0f, 10.0f);
        agentStrength = AttributeInit(0.0f, 10.0f);
	}

	//When called Initialize return a random value between range 1 ~ 10
	float AttributeInit(float min, float max){
		float tempValue = Random.Range (min, max);
		tempValue = Mathf.Round (tempValue * 1.0f) / 1.0f;
		return(tempValue);
	}

	//	
	void SetAgility(){

		float tempAgility = agentAgility / 10;
		float tempSpeed = aiFollow.speed * tempAgility;

		aiFollow.speed = aiFollow.speed + tempSpeed;

		/*float tempSpeed = (agentAgility - aiFollow.speed);
		tempSpeed = ((tempSpeed/aiFollow.speed)*100);
		aiFollow.speed = tempSpeed;*/
	}

    void SetPerception(){

        float tempPerception = agentPerception / 10;
        float tempValue = agentLogic.perception * agentPerception;

        agentLogic.perception = agentLogic.perception + tempValue;

    }

    void SetStrength(){

        float tempAgility = agentAgility / 10;
        float tempSpeed = aiFollow.speed * tempAgility;

        aiFollow.speed = aiFollow.speed + tempSpeed;

        /*float tempSpeed = (agentAgility - aiFollow.speed);
		tempSpeed = ((tempSpeed/aiFollow.speed)*100);
		aiFollow.speed = tempSpeed;*/
    }
}
