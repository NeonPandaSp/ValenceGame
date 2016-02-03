using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class PlayerDataManager : MonoBehaviour {
	public static PlayerDataManager playerDataManager;

	bool dataExists;
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
			dataExists = true;
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dataExists) {
			dataExists = false;
			Application.LoadLevel (1);
		}
	}
	
	bool saveDataExists(){
		if (File.Exists (Application.persistentDataPath + "/playerInfo.dat"))
			return true;
		else
			return false;
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

		data.populationCount = 0;
		data.population = new List<GameObject> ();
		data.myBuildings = new List<GameObject> ();
		data.myParty = new List<GameObject> ();

		dataExists = true;
	}
}

[Serializable]
public class PlayerData{
	public int populationCount;
	public List<GameObject> population;
	public List<GameObject> myBuildings;

	public List<GameObject> myParty;

	
}