using UnityEngine;
using System.Collections;

public class EXAMPLE_ANIMTRIGGER : MonoBehaviour {

    //List of all weapons that can have a muzzle flash
    public GameObject Shotgun, Pistol, Rifle;

	public Unit myUnit;

	// Use this for initialization
	void Start () {

		myUnit = transform.parent.GetComponent<Unit> ();
		if (myUnit == null)
			myUnit = transform.parent.transform.parent.GetComponent<Unit> ();
		//Debug.Log ("My Weap Name: " + myUnit.myWeapon.name);
		if (myUnit.myWeapon.name == "Weapon_Shotgun") {
			Shotgun.SetActive(true);
		} else if (myUnit.myWeapon.name== "Weapon_Handgun") {
			Pistol.SetActive (true);
			Shotgun.SetActive (false);
		} else if (myUnit.myWeapon.name == "Weapon_Rifle") {
			Rifle.SetActive (true);
			Shotgun.SetActive (false);
		}
	}

    public void FireWeapon() {
		if (myUnit.myWeapon.name == "Weapon_Shotgun") {
			Shotgun.GetComponent<WeaponLogic>().FireWeapon();
		} else if (myUnit.myWeapon.name == "Weapon_Handgun") {
			Pistol.GetComponent<WeaponLogic>().FireWeapon();
		} else if (myUnit.myWeapon.name == "Weapon_Rifle") {
			Rifle.GetComponent<WeaponLogic>().FireWeapon();
		}
        //Rifle.GetComponent<WeaponLogic>().FireWeapon();
        //Pistol.GetComponent<WeaponLogic>().FireWeapon();
       

    }
}
