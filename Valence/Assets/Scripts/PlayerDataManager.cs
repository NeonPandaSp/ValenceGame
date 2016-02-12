using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class PlayerDataManager : MonoBehaviour {
	public static PlayerDataManager playerDataManager;

	bool dataExists;
	public bool isLive;

	public string currentVersion;

	void Awake(){
		if (playerDataManager == null) {
			DontDestroyOnLoad (gameObject);
			playerDataManager = this;
		} else {
			Destroy (gameObject);
		}
		Debug.Log ("SceneLoaded");
		Debug.Log (Application.persistentDataPath);
		if (!saveDataExists ()) {
			Debug.Log ("Data does not exist");
			dataExists = false;
		} else {
			Debug.Log ("Found Data");
			PlayerData loadedData = loadSaveData();
			Debug.Log ("Version: " + loadedData.versionId);
			if( !isLive || loadedData.versionId == currentVersion ){
				Debug.Log ("Matches current version");
				dataExists = true;
			} else{
				Debug.Log ("Does not match current version");
				dataExists = false;
			}
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dataExists && isLive) {
			dataExists = false;
			Application.LoadLevelAsync (1);
		}
	}
	
	public bool saveDataExists(){
		if (File.Exists (Application.persistentDataPath + "/playerInfo.dat"))
			return true;
		else
			return false;
	}

	public void writePlayerData(PlayerData newSaveData){
		BinaryFormatter bf = new BinaryFormatter ();
		if (File.Exists (Application.persistentDataPath + "/playerInfo.dat")) {
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			newSaveData.versionId = currentVersion;
			bf.Serialize (file, newSaveData);
		} else {
			Debug.Log ("NO SAVE FILE EXISTS: did you delete the save data during play?");
		}
	}

	public PlayerData loadSaveData(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
		PlayerData data = (PlayerData)bf.Deserialize (file);
		file.Close ();

		return data;
	}
	
	public void createNewData(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfo.dat");
		PlayerData data = new PlayerData ();

		data.firstLoad = true;
		data.versionId = currentVersion;
		data.populationCount = 1;
		data.population = new List<serialAgent> ();
		data.buildingDatabase = new List<serialBuilding> ();
		bf.Serialize (file, data);

		dataExists = true;
	}

	public void deleteSaveData(){
		File.Delete (Application.persistentDataPath + "/playerInfo.dat");
		Debug.Log ("Save Deleted");
	}
}

[Serializable]
public class PlayerData{
	public string versionId;

	public int populationCount;
	public List<serialAgent> population;
	public List<serialBuilding> buildingDatabase;
	public bool firstLoad = false;
	public string fLname;
	public int scrap;
	public float food, power, water, popLimit, morale;

	public List<serialAgent> currentParty;
}