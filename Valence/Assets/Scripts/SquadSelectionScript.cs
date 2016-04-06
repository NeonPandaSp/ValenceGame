using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class SquadSelectionScript : MonoBehaviour {
	public Button ventureBtn;

	PlayerData dataCopy;

	//=======================\\
	//===Declaration Squad===\\
	//=======================\\
	public List<serialAgent> population = new List<serialAgent>();

	//Settler Info
	public GameObject settlerList;
	public GameObject scrollableSettlerList;
	public Text numberOfSettlersInPopulation;
	public Text numberOfSettlersInSquad;

	public GameObject prefabSettler;
	public Image prefabSettlerPortrait;
	public Text prefabSettlerName;
	public Text prefabSettlerHealth;
	public Text prefabSettlerStrength;
	public Text prefabSettlerAgility;
	public Text prefabSettlerPerception;
	public Image prefabSettlerHealthIcon;
	public Image prefabSettlerStrengthIcon;
	public Image prefabSettlerAgilityIcon;
	public Image prefabSettlerPerceptionIcon;

	//Squad Info
	public GameObject squadList;
	public GameObject[] MemberList = new GameObject[4];

	//Photos
	public Sprite[] malePortraitArray;
	public Sprite[] femalePortraitArray;

	public serialAgent [] myParty = new serialAgent [4];

	float NumOfPopSettlers;
	int newSettlerListHeight;

	//=========================\\
	//===Declaration Weapons===\\
	//=========================\\
	public List<serialWeapon> weaponsPopulation = new List<serialWeapon>();

	public GameObject weaponList;
	public GameObject scrollableWeaponsList;
	public Text numberOfWeaponsInWeaponsList;
	public Text numberOfWeaponsInSelectedWeaponsList;

	bool [] numSet = {false, false, false, false};
	public int squadNumber = 0;
	string currId;

	bool [] weaponNumSet = {false, false, false, false};
	public int weaponNumber = 0;
	string currWeaponId;

	public GameObject prefabWeapon;
	public Image prefabWeaponIcon;
	public Text prefabWeaponName;
	public Text prefabWeaponType;
	public Text prefabWeaponStats;
	public Image prefabWeaponStrengthIcon;
	public Image prefabWeaponAccuracyIcon;
	public Image prefabWeaponRangeIcon;
	
	public GameObject SelectedWeaponsList;
	public GameObject[] WeaponList = new GameObject[4];
	
	public Image [] myPartyWeaponIcons = new Image [4];

	public Image GlowImage;

	float NumOfInvWeapons;
	int newWeaponsListHeight;

	//===========\\
	//===Start===\\
	//===========\\
	void Start () {
		loadPopulation ();
		loadWeaponsList ();

		GlowImage.GetComponent<Image>().canvasRenderer.SetAlpha (1.1f);
		GlowImage.GetComponent<Image>().CrossFadeAlpha (0.0f, 1, false);
		GlowImage.GetComponent<Image>().CrossFadeAlpha (0.9f, 3, false);
		GlowImage.GetComponent<Image>().CrossFadeAlpha (0.0f, 2, false);
	}

	//=====================\\
	//===Load Population===\\
	//=====================\\
	public void loadPopulation () {
		int index = 0;
		PlayerData loadedData = PlayerDataManager.playerDataManager.loadSaveData ();
		population = loadedData.population;

		foreach (serialAgent sA in population) {
			//Settler
			GameObject settler = (GameObject) Instantiate (prefabSettler);
			settler.gameObject.transform.SetParent (scrollableSettlerList.gameObject.transform);
			settler.transform.localScale = new Vector3 (1, 1, 1);

			settler.name = sA.agentName;
			GameObject tempSettler = settler.GetComponent <GameObject>();

			//Portrait
			Image settlerPortrait = settler.GetComponent<Image>();
			settlerPortrait.gameObject.transform.SetParent (settler.gameObject.transform);

			settlerPortrait.transform.localScale = new Vector3 (1, 1, 1);

			Image[] tempImgs = settler.GetComponentsInChildren<Image>();

			foreach (Image img in tempImgs) {
				if (img.gameObject.name == "Settler Portrait") {
					Image tempSettlerPortrait = img;
					if (sA.gender == "Male") {
						tempSettlerPortrait.sprite = malePortraitArray [sA.photo];
					} else {
						tempSettlerPortrait.sprite = femalePortraitArray [sA.photo];
					}
				}
			}

			Text[] childTexts = settler.GetComponentsInChildren<Text>();

			Text settlerName, settlerHealth, settlerStrength, settlerAgility, settlerPerception;
			//Name
			foreach (Text cT in childTexts) {
				if (cT.gameObject.name == "Settler Name") {
					settlerName = cT;
					settlerName.gameObject.transform.SetParent (settler.gameObject.transform);
					
					settlerName.transform.localScale = new Vector3 (1, 1, 1);
					settlerName.text = sA.agentName;
					
					Image tempSettlerName = settlerName.GetComponent <Image>();
				}

				if (cT.gameObject.name == "Settler Health") {
					settlerHealth = cT;
					settlerHealth.gameObject.transform.SetParent (settler.gameObject.transform);
					
					settlerHealth.transform.localScale = new Vector3 (1, 1, 1);
					settlerHealth.text = (sA.health / 10).ToString () + "/10";
					
					Text tempSettlerHealth = settlerPortrait.GetComponent <Text>();
				}

				if (cT.gameObject.name == "Settler Strength") {
					settlerStrength = cT;
					settlerStrength.gameObject.transform.SetParent (settler.gameObject.transform);
					
					settlerStrength.transform.localScale = new Vector3 (1, 1, 1);
					settlerStrength.text = sA.strength.ToString();
					
					Text tempSettlerStrength = settlerStrength.GetComponent <Text>();
				}

				if (cT.gameObject.name == "Settler Agility") {
					settlerAgility = cT;
					settlerAgility.gameObject.transform.SetParent (settler.gameObject.transform);
					
					settlerAgility.transform.localScale = new Vector3 (1, 1, 1);
					settlerAgility.text = sA.agility.ToString();
					
					Text tempSettlerAgility = settlerAgility.GetComponent <Text>();
				}

				if (cT.gameObject.name == "Settler Perception") {
					settlerPerception = cT;
					settlerPerception.gameObject.transform.SetParent (settler.gameObject.transform);
					
					settlerPerception.transform.localScale = new Vector3 (1, 1, 1);
					settlerPerception.text = sA.perception.ToString();
					
					Text tempSettlerPerception = settlerPerception.GetComponent <Text>();
				}
			}
		}

		Destroy (prefabSettler);
	}

	//==================\\
	//===Load Weapons===\\
	//==================\\
	public void loadWeaponsList () {
		int index = 0;
		PlayerData loadedData = PlayerDataManager.playerDataManager.loadSaveData ();
		weaponsPopulation = loadedData.settlementWeapons;
		
		foreach (serialWeapon sA in weaponsPopulation) {
			//Settler
			GameObject weapon = (GameObject) Instantiate (prefabWeapon);
			weapon.gameObject.transform.SetParent (scrollableWeaponsList.gameObject.transform);
			weapon.transform.localScale = new Vector3 (1, 1, 1);
			
			weapon.name = sA.weaponName;
			GameObject tempWeapon = weapon.GetComponent <GameObject>();
			
			//Portrait
			Image weaponIcon = weapon.GetComponent<Image>();
			weaponIcon.gameObject.transform.SetParent (weapon.gameObject.transform);
			
			weaponIcon.transform.localScale = new Vector3 (1, 1, 1);
			
			Image[] tempWeaponImgs = weapon.GetComponentsInChildren<Image>();
			
//			foreach (Image img in tempWeaponImgs) {
//				if (img.gameObject.name == "Weapon Icon") {
//					Image tempWeaponIcons = img;
////					if (sA.weaponType == "Handgun") {
////					}
//				}
//			}
			
			Text[] childWeaponTexts = weapon.GetComponentsInChildren<Text>();
			
			Text weaponName, weaponType, weaponStrength, weaponAccuracy, weaponRange;
			//Name
			foreach (Text cT in childWeaponTexts ){
				if (cT.gameObject.name == "Weapon Name") {
					weaponName = cT;
					weaponName.gameObject.transform.SetParent (weapon.gameObject.transform);
					
					weaponName.transform.localScale = new Vector3 (1, 1, 1);
					weaponName.text = sA.weaponName;
					
					Image tempSettlerName = weaponName.GetComponent <Image>();
				} 
				if (cT.gameObject.name == "Weapon Type") {
					weaponType = cT;
					weaponType.gameObject.transform.SetParent (weapon.gameObject.transform);
					
					weaponType.transform.localScale = new Vector3 (1, 1, 1);
					weaponType.text = sA.weaponType.ToString();
					
					Text tempSettlerHealth = weaponIcon.GetComponent <Text>();
				} 
				if (cT.gameObject.name == "Weapon Strength") {
					weaponStrength = cT;
					weaponStrength.gameObject.transform.SetParent (weapon.gameObject.transform);
					
					weaponStrength.transform.localScale = new Vector3 (1, 1, 1);
					weaponStrength.text = sA.damageModifier.ToString();
					
					Text tempSettlerStrength = weaponStrength.GetComponent <Text>();
				}

				if (cT.gameObject.name == "Weapon Accuracy") {
					weaponAccuracy = cT;
					weaponAccuracy.gameObject.transform.SetParent (weapon.gameObject.transform);
					
					weaponAccuracy.transform.localScale = new Vector3 (1, 1, 1);
					weaponAccuracy.text = (Mathf.Round (sA.accuracy * 100)).ToString() + "% ";
					
					Text tempSettlerAccuracy = weaponAccuracy.GetComponent <Text>();
				}

				if (cT.gameObject.name == "Weapon Range") {
					weaponRange = cT;
					weaponRange.gameObject.transform.SetParent (weapon.gameObject.transform);
					
					weaponRange.transform.localScale = new Vector3 (1, 1, 1);
					weaponRange.text = sA.range.ToString();
					
					Text tempSettlerRange = weaponRange.GetComponent <Text>();
				}
			}
		}
		
		Destroy (prefabWeapon);
	}

	//============\\
	//===Update===\\
	//============\\
	void Update () {
		//===========\\
		//===Squad===\\
		//===========\\
		int partyIndex = 0;
		foreach (serialAgent partyMember in myParty) {
			if (partyMember.agentId != "" && partyMember.agentId != "-1") {
				numSet [partyIndex] = true;
			}
			if (partyMember.agentId == "-1") {
				numSet [partyIndex] = false;
			}
			partyIndex++;
		}
		squadNumber = 0;
		foreach (bool i in numSet) {
			if (i == true) {
				squadNumber++;
			}
		}

		numberOfSettlersInPopulation.text = "Settler List (" + scrollableSettlerList.transform.childCount + ")";		
		numberOfSettlersInSquad.text = ("Squad " + squadNumber) + "/4   |";

		if (scrollableSettlerList.transform.childCount > 0) {
			RectTransform thisBeMyTransform = scrollableSettlerList.transform.GetChild (0).GetComponent<RectTransform> ();
			NumOfPopSettlers = scrollableSettlerList.transform.childCount * Math.Abs (thisBeMyTransform.sizeDelta.y) + (scrollableSettlerList.transform.childCount * scrollableSettlerList.GetComponent<GridLayoutGroup> ().spacing.y);
			float subtractThisAmount = (float)(Math.Abs (scrollableSettlerList.GetComponent<RectTransform> ().rect.y) / 2.5);
			scrollableSettlerList.GetComponent<RectTransform> ().sizeDelta = new Vector2 (Math.Abs (settlerList.gameObject.transform.GetComponent<RectTransform> ().rect.x), NumOfPopSettlers - subtractThisAmount);
		}

		//=============\\
		//===Weapons===\\
		//=============\\
//		int weaponsPartyIndex = 0;
//		for (int i = 0; i < 4; i++) {
//			foreach (serialWeapon weaponMember in myParty[i].myWeapon) {
//				if (weaponMember.weaponId != "" && weaponMember.weaponId != "-1") {
//					weaponNumSet [weaponsPartyIndex] = true;
//				}
//				if (weaponMember.weaponId == "-1") {
//					weaponNumSet [weaponsPartyIndex] = false;
//				}
//				weaponsPartyIndex++;
//			}
//		}
		weaponNumber = 0;
		foreach (bool i in weaponNumSet) {
			if (i == true) {
				weaponNumber++;
			}
		}

		numberOfWeaponsInWeaponsList.text = "Weapons List (" + scrollableWeaponsList.transform.childCount + ")";
		int weaponCOUNT = WeaponList[0].gameObject.GetComponent<RectTransform>().childCount +
					WeaponList[1].gameObject.GetComponent<RectTransform>().childCount +
					WeaponList[2].gameObject.GetComponent<RectTransform>().childCount +
					WeaponList[3].gameObject.GetComponent<RectTransform>().childCount;
		numberOfWeaponsInSelectedWeaponsList.text = ("|    Weapons " + weaponCOUNT) + "/4";
		Debug.Log ("Number of weapons is: " + weaponNumber);
		
		if (scrollableWeaponsList.transform.childCount > 0) {
			RectTransform thisBeMyTransform2 = scrollableWeaponsList.transform.GetChild (0).GetComponent<RectTransform> ();
			NumOfInvWeapons = scrollableWeaponsList.transform.childCount * Math.Abs (thisBeMyTransform2.sizeDelta.y) + (scrollableWeaponsList.transform.childCount * scrollableWeaponsList.GetComponent<GridLayoutGroup> ().spacing.y);
			float subtractThisAmount2 = (float)(Math.Abs (scrollableWeaponsList.GetComponent<RectTransform> ().rect.y) / 2);
			scrollableWeaponsList.GetComponent<RectTransform> ().sizeDelta = new Vector2 (Math.Abs (weaponList.gameObject.transform.GetComponent<RectTransform> ().rect.x), NumOfInvWeapons - subtractThisAmount2);
		}
	}
}

[Serializable]
public class tempAgent {
	public string name;
	public int movement;
	public int attack;
	public int perception;	
}