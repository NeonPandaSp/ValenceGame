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

		if (myUnit.myWeaponName == "Weapon_Shotgun") {
			Shotgun.SetActive(true);
		} else if (myUnit.myWeaponName == "Weapon_Handgun") {
			Pistol.SetActive (true);
			Shotgun.SetActive (false);
		} else if (myUnit.myWeaponName == "Weapon_Rifle") {
			Rifle.SetActive (true);
			Shotgun.SetActive (false);
		}
	}

    public void FireWeapon() {
        //Rifle.GetComponent<WeaponLogic>().FireWeapon();
        //Pistol.GetComponent<WeaponLogic>().FireWeapon();
        Shotgun.GetComponent<WeaponLogic>().FireWeapon();

    }
}
