using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponGenerator : MonoBehaviour {

    public List<WeaponType> weaponList;
    public List<string> damageName;
    public List<string> accuracyName;
    public List<string> soundName;
    //Weapon Type to be spawned
    public string myType;

    //Rarity of the weapon
    public int wRare;

    public WeaponType wType;
    // Use this for initialization
    void Start () {
        weaponList = new List<WeaponType>();

        TextAsset wndnameText = Resources.Load<TextAsset>("WeaponDamageNames");
        string[] wdnlines = wndnameText.text.Split("\n"[0]);

        TextAsset wannameText = Resources.Load<TextAsset>("WeaponAccuracyNames");
        string[] wanlines = wannameText.text.Split("\n"[0]);

        TextAsset wsnnameText = Resources.Load<TextAsset>("WeaponSoundNames");
        string[] wsnlines = wsnnameText.text.Split("\n"[0]);

        for (int i = 0; i < wdnlines.Length; i++) {
           damageName.Add(wdnlines[i]);     
        }

        for (int i = 0; i < wanlines.Length; i++)
        {
           accuracyName.Add(wanlines[i]);
        }

        for (int i = 0; i < wsnlines.Length; i++)
        {
           soundName.Add(wsnlines[i]);
        }
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
