using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class PlayerDataManager : MonoBehaviour {
	bool dataExists;
	void Awake(){
		DontDestroyOnLoad (this);
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
		if (File.Exists (Application.persistentDataPath + "/playedInfo.dat"))
			return true;
		else
			return false;
	}
	
	void loadSaveData(){
		
	}
	
	public void createNewData(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playedInfo.dat");
		PlayerData data = new PlayerData ();
		dataExists = true;
	}
}

[Serializable]
class PlayerData{
	public int populationCount;
	
}