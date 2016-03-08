using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyMouseOver : MonoBehaviour {
	public GameObject infoObject;
	public Unit myUnit;
	public Text infoName;
	public Text infoHP;
	public Text infoAtk;
	// Use this for initialization
	void Start () {
		myUnit = GetComponent<Unit> ();
		if (infoObject == null)
			infoObject = GameObject.FindWithTag ("UI_HOVER");

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

	void OnMouseOver(){

		if (myUnit.isElite) {
			infoName.text = "ELITE GRUNT Lv. " + (int)(myUnit.health / 5 + myUnit.attackRating / 3);
		} else {
			infoName.text = myUnit.unitName + " Lv. " + (int)(myUnit.health / 5 + myUnit.attackRating / 3);
		}

		if (myUnit.health >= 10)
			infoHP.text =  "" + myUnit.health;
		else
			infoHP.text = "0" + myUnit.health;

		if (myUnit.attackRating >= 10)
			infoAtk.text = "" + myUnit.attackRating;
		else
			infoAtk.text = "0" + myUnit.attackRating;
	}
	void OnMouseEnter(){
		infoObject.SetActive (true);
	}
	void OnMouseExit(){
		infoObject.SetActive (false);
	}
}
