using UnityEngine;
using System.Collections;

public class FolkAnimCtrl : MonoBehaviour {
	public Animator myAnim;
	public Unit myUnit;
	public bool testWalk;
	
	public string currentAnimState;
	// Use this for initialization
	void Start () {
		myUnit = transform.GetComponent<Unit> ();
	}
	
	void Update () {
		ResetTriggers ();
		
		if (myUnit.isMoving && currentAnimState != "walk") {
			InitMoveAnim ();
		} else if (myUnit.isAttacking && currentAnimState != "attack") {
			InitAttackAnim();
			myUnit.isAttacking = false;
		} else if (!myUnit.isMoving && currentAnimState != "idle" && currentAnimState != "attack" ) {
			InitIdleAnim();
		}
	}
	void ResetTriggers(){
		myAnim.ResetTrigger ("idle");
		myAnim.ResetTrigger ("walking");
		myAnim.ResetTrigger ("attack");
	}
	void InitIdleAnim(){
		currentAnimState = "idle";
		myAnim.SetTrigger("idle");
	}
	void InitMoveAnim(){
		currentAnimState = "walk";
		myAnim.SetTrigger("walking");
	}
	public void InitAttackAnim(){
		Debug.Log ("ATK");
		currentAnimState = "attack";
		myAnim.SetTrigger ("attack");
	}
}
