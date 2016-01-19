using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]

public class WeaponType {

    public string typeName;
    
    //public int cost;

    public int rare;

    public string weaponName;
    public int damageModifier;
    public int range;
    public float accuracy;
    public int soundRange;

    // Use this for initialization
    void Start()
    {
        
    }

    public WeaponType(string n, int a)
    {
        typeName = n;
        //rare = a;

        damageModifier = getWeaponDamage();
        range = getWeaponRange();
        accuracy = getWeaponAccuracy();
        soundRange = getSoundRange();

        //weaponName = getWeaponName();

        if (damageModifier > 5) {

        }
    }

    public int getWeaponDamage(){
        if ((typeName == "Pistol") || (typeName == "pistol")) {
            return Random.Range(1, 5);
        }
        else if ((typeName == "Rifle") || (typeName == "rifle")) {
            return Random.Range(5, 10);
        }
        else if ((typeName == "Shotgun") || (typeName == "shotgun")) {
            return Random.Range(5, 10);
        }
        else if ((typeName == "Melee") || (typeName == "melee")) {
            return Random.Range(1, 4);
        }
        else{
            Debug.Log("Weapon Damage Error");
            return 0;
        }
    }

    //public string getWeaponName() {
        //if()
    //}

    public int getWeaponRange()
    {
        if ((typeName == "Pistol") || (typeName == "pistol"))
        {
            return Random.Range(1, 5);
        }
        else if ((typeName == "Rifle") || (typeName == "rifle"))
        {
            return Random.Range(5, 10);
        }
        else if ((typeName == "Shotgun") || (typeName == "shotgun"))
        {
            return Random.Range(1, 3);
        }
        else if ((typeName == "Melee") || (typeName == "melee"))
        {
            return 1;
        }
        else
        {
            Debug.Log("Weapon Range Error");
            return 0;
        }
    }

    public float getWeaponAccuracy()
    {
        if ((typeName == "Pistol") || (typeName == "pistol"))
        {
            return Random.Range(0.1f, 0.5f);
        }
        else if ((typeName == "Rifle") || (typeName == "rifle"))
        {
            return Random.Range(0.5f, 0.9f);
        }
        else if ((typeName == "Shotgun") || (typeName == "shotgun"))
        {
            return Random.Range(0.5f, 0.9f);
        }
        else if ((typeName == "Melee") || (typeName == "melee"))
        {
            return Random.Range(0.1f, 0.9f);
        }
        else
        {
            Debug.Log("Weapon Accuracy Error");
            return 0;
        }
    }

    public int getSoundRange()
    {
        if ((typeName == "Pistol") || (typeName == "pistol"))
        {
            return Random.Range(0, 7);
        }
        else if ((typeName == "Rifle") || (typeName == "rifle"))
        {
            return Random.Range(0, 12);
        }
        else if ((typeName == "Shotgun") || (typeName == "shotgun"))
        {
            return Random.Range(0, 12);
        }
        else if ((typeName == "Melee") || (typeName == "melee"))
        {
            return 0;
        }
        else
        {
            Debug.Log("Weapon Sound Range Error");
            return 0;
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
