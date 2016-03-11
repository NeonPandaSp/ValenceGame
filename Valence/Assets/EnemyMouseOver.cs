using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyMouseOver : MonoBehaviour {
	public GameObject infoObject;
	public InfoBoxInfo infoObjInfo;
	public Unit myUnit;
	public Text infoName;
	public Text infoHP;
	public Text infoAtk;
	// Use this for initialization
	void Start () {
		myUnit = GetComponent<Unit> ();
		if (infoObject == null)
			infoObject = GameObject.FindWithTag ("UI_HOVER");

		infoObjInfo = infoObject.GetComponent<InfoBoxInfo> ();
		foreach(Transform child in infoObject.gameObject.transform){
			if( child.gameObject.tag == "UI_HP")
				infoHP = child.gameObject.GetComponent<Text>();
			else if ( child.gameObject.tag == "UI_ATK")
				infoAtk = child.gameObject.GetComponent<Text>();
			else if( child.gameObject.tag == "UI_NAME")
				infoName = child.gameObject.GetComponent<Text>();
			else
				Debug.Log ("NO CHILD TAG");
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	void dataUpdate(){
		infoObjInfo.myUnit = myUnit;
	}

	void OnMouseOver(){
		if (!myUnit._GameController.selectedUnit.attackPressed) {
			dataUpdate();
		}
	}
	void OnMouseEnter(){
		if (!myUnit._GameController.selectedUnit.attackPressed) {
			infoObject.SetActive (true);
			infoObject.GetComponent<FollowMouse> ().targetPosition = this.transform.position;
		}

	}
	void OnMouseExit(){
		if (!myUnit._GameController.selectedUnit.attackPressed) {
			infoObject.SetActive (false);
		}
	}
	void OnMouseDown(){
		if (myUnit.isElite && !myUnit._GameController.selectedUnit.attackPressed) {
			myUnit._GameController.GenerateMovementRange((int) myUnit.currentPosition.x,(int) myUnit.currentPosition.y, myUnit);
			infoObject.SetActive (true);
			infoObject.GetComponent<FollowMouse> ().targetPosition = this.transform.position;
			dataUpdate();
		} else if (myUnit.isElite && myUnit._GameController.selectedUnit.attackPressed) {
			if( myUnit._GameController.selectedUnit.AttackTargets.Contains (myUnit) ){
				myUnit._GameController.selectedUnit.currentAttackTarget = myUnit._GameController.selectedUnit.AttackTargets.IndexOf(myUnit);
				infoObject.SetActive (true);
				infoObject.GetComponent<FollowMouse> ().targetPosition = this.transform.position;
				myUnit._GameController.attackIcon.selectUnit = myUnit._GameController.selectedUnit.AttackTargets [myUnit._GameController.selectedUnit.AttackTargets.IndexOf(myUnit)];
				dataUpdate ();
			}
		} else if( !myUnit.isElite && !myUnit._GameController.selectedUnit.movePressed && !myUnit._GameController.selectedUnit.isMoving ) {
			myUnit._GameController.selectSelectedUnit(myUnit);
			Debug.Log ( "clicked");
		}
	}
	public void enableUI(){
		infoObject.SetActive (true);
		infoObject.GetComponent<FollowMouse> ().targetPosition = this.transform.position;
		dataUpdate ();
	}
}
