using UnityEngine;
using System.Collections;

public class MapSquadSceneControl : MonoBehaviour {
	public GameObject mapCan, squadCan;
	public int mapIndex = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleCanvas(){
		if (mapCan.activeSelf) {
			squadCan.SetActive(true);
			mapCan.SetActive(false);
		} else {
			squadCan.SetActive(false);
			mapCan.SetActive(true);
		}
	}

	public void loadExploreMap(){
		Application.LoadLevel (mapIndex);
	}
}
