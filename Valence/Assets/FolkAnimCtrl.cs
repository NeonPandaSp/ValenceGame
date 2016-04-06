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
		//myAnim = transform.GetComponentInChildren<Animator> ();
	}
	
	void Update () {
		if (myAnim != null) {
			ResetTriggers ();
			if (myUnit.isMoving && currentAnimState != "walk") {
				InitMoveAnim ();
			} else if (myUnit.isAttacking && currentAnimState != "attack") {
				InitAttackAnim ();
				myUnit.isAttacking = false;
			} else if (!myUnit.isMoving && currentAnimState != "idle" && currentAnimState != "attack" & currentAnimState != "hit" && currentAnimState != "dead" ) {
				InitIdleAnim ();
			}
		} else {
			Debug.Log ("Anim Not Set");
			lookForAnim();
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
	public void InitHitAnim(){
		currentAnimState = "hit";
		myAnim.SetTrigger ("hitTrigger");
	}
	public void InitDeathAnim(){
		currentAnimState = "dead";
		myAnim.SetBool ("isDead", true);
	}
	public void InitAttackAnim(){
		Debug.Log ("ATK");
		currentAnimState = "attack";
		myAnim.SetTrigger ("attack");
	}

	void lookForAnim(){
		Animator[] gameObjectArray = GetComponentsInChildren<Animator> ();
		foreach (Animator g in gameObjectArray) {
			if( g.gameObject.tag == "EXP_FOLK"){
				myAnim = g;
			}
		}
	}
}
