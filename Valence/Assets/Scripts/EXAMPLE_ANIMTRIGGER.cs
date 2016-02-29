using UnityEngine;
using System.Collections;

public class EXAMPLE_ANIMTRIGGER : MonoBehaviour {

    //List of all weapons that can have a muzzle flash
    public GameObject Shotgun, Pistol, Rifle;

	// Use this for initialization
	void Start () {
	
	}

    public void FireWeapon() {
        //Rifle.GetComponent<WeaponLogic>().FireWeapon();
        //Pistol.GetComponent<WeaponLogic>().FireWeapon();
        Shotgun.GetComponent<WeaponLogic>().FireWeapon();

    }
}
