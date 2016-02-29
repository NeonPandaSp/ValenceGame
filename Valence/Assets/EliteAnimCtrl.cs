using UnityEngine;
using System.Collections;

public class EliteAnimCtrl : MonoBehaviour {
	public Animator myAnim;
	public Unit myUnit;
	public bool testWalk;

	public string currentAnimState;
	// Use this for initialization
	void Start () {
		myUnit = transform.GetComponent<Unit> ();
	}
	
	// Update is called once per frame
	void Update () {
		ResetTriggers ();

		if (myUnit.isMoving && currentAnimState != "walk") {
			InitMoveAnim();
		} else if (!myUnit.isMoving && currentAnimState != "idle" && currentAnimState != "alert" && currentAnimState != "attack" ) {
			InitIdleAnim();
		}
	}
	void ResetTriggers(){
		myAnim.ResetTrigger ("idle");
		myAnim.ResetTrigger ("walking");
		myAnim.ResetTrigger ("alert");
		myAnim.ResetTrigger ("attack");
		myAnim.SetBool ("attacking", false);
	}
	void InitIdleAnim(){
		currentAnimState = "idle";
		myAnim.SetTrigger("idle");
	}
	void InitMoveAnim(){
		currentAnimState = "walk";
		myAnim.SetTrigger("walking");
	}
	public void InitAlertAnim(){
		Debug.Log ("Called");
		currentAnimState = "alert";
		myAnim.SetTrigger ("alert");
	}
	public void InitAttackAnim(){
		Debug.Log ("ATK");
		currentAnimState = "attack";
		myAnim.SetTrigger ("attack");
		//myAnim.SetBool ("attacking", true);
	}
}
