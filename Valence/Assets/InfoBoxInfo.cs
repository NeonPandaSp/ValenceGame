using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoBoxInfo : MonoBehaviour {
	public Unit myUnit;
	public Text infoName;
	public Text infoHP;
	public Text infoAtk;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (myUnit != null) {
			if (myUnit.isElite) {
				infoName.text = "ELITE GRUNT Lv. " + (int)(myUnit.health / 5 + myUnit.attackRating / 3);
			} else {
				infoName.text = myUnit.unitName + " Lv. " + (int)(myUnit.health / 5 + myUnit.attackRating / 3);
			}
			
			if (myUnit.health >= 10)
				infoHP.text = "" + myUnit.health;
			else
				infoHP.text = "0" + myUnit.health;
			
			if (myUnit.attackRating >= 10)
				infoAtk.text = "" + myUnit.attackRating;
			else
				infoAtk.text = "0" + myUnit.attackRating;

			if (myUnit.health < 0) {
				infoHP.text = "00";
			}
		} else {
			this.gameObject.SetActive (false);
		}
	}
}
