using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {
	public GameObject menuScreen, titleScreen;
	public int sceneNumber = 2;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			menuScreen.SetActive (true);
			titleScreen.SetActive (false);
		}
	}

	public void loadScene(bool newGame){
		if (!newGame)
			Application.LoadLevel (sceneNumber);
		else {
			if( PlayerDataManager.playerDataManager.saveDataExists() )
				PlayerDataManager.playerDataManager.deleteSaveData();
			PlayerDataManager.playerDataManager.createNewData();
			Application.LoadLevel (sceneNumber);
		}
	}

	public void quit(){
		Application.Quit ();
	}
}
