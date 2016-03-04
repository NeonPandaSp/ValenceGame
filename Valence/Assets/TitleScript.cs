using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {
	public GameObject menuScreen, titleScreen, loadScreen;
	public int sceneNumber = 2;
	bool hasBeenPressed = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey && !hasBeenPressed) {
			menuScreen.SetActive (true);
			titleScreen.SetActive (false);
			hasBeenPressed = false;
		}
	}

	public void loadScene(bool newGame){
		if (!newGame) {
			
			menuScreen.SetActive(false);
			loadScreen.SetActive(true);
			Application.LoadLevelAsync (sceneNumber);

		} else {
			if( PlayerDataManager.playerDataManager.saveDataExists() )
				PlayerDataManager.playerDataManager.deleteSaveData();

			PlayerDataManager.playerDataManager.createNewData();
			menuScreen.SetActive(false);
			loadScreen.SetActive(true);
			Application.LoadLevel (sceneNumber);
		}
	}

	public void quit(){
		Application.Quit ();
	}
}
