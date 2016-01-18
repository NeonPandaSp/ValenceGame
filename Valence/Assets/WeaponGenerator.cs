using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponGenerator : MonoBehaviour {

    public List<WeaponType> weaponList;

    //Weapon Type to be spawned
    public string myType;

    //Rarity of the weapon
    public int wRare;

    public WeaponType wType;
    // Use this for initialization
    void Start () {
        weaponList = new List<WeaponType>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 700, 10, 150, 20), "Generate Weapon"))
        {
            wType = new WeaponType(myType, wRare);
            weaponList.Add(wType);
        }
    }

}
