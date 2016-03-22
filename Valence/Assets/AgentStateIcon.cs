using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AgentStateIcon : MonoBehaviour {

    public AgentLogic_07 agentLogic;
    public Image stateIcon;

	// Use this for initialization
	void Start () {
        agentLogic = GetComponentInParent<AgentLogic_07>();
        stateIcon.sprite = Resources.Load<Sprite>("AgentIcons/default_icon");
    }
	
	// Update is called once per frame
	void Update () {

        switch (agentLogic.aState) {
            //If the agent is Idle or Wandering, then they are not working, therefore show a not working icon
            case AgentLogic_07.agentState.Idle:
            case AgentLogic_07.agentState.Wandering:
                stateIcon.sprite = Resources.Load<Sprite>("AgentIcons/idle_icon");
                break;

            case AgentLogic_07.agentState.Working:
                stateIcon.sprite = Resources.Load<Sprite>("AgentIcons/default_icon");
                break;
        }

        this.gameObject.transform.localScale = new Vector3(this.gameObject.transform.localScale.z, this.gameObject.transform.localScale.y, this.gameObject.transform.localScale.z);
    }
}
