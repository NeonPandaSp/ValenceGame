using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {

	public AudioController _audioController;

	public GameObject menuScreen, titleScreen, loadScreen;
	public int sceneNumber = 2;
	bool hasBeenPressed = false;
	AsyncOperation async;
	public bool startCounting = false;
	public float timer = 0.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (startCounting) {
			timer += Time.deltaTime;
			if ( timer > 5 ){
				ActivateScene();
			}
		}
		if (Input.anyKey && !hasBeenPressed) {
			menuScreen.SetActive (true);
			titleScreen.SetActive (false);
			hasBeenPressed = false;

			/**
			 * JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE
			 * PRESS ANY BUTTON SOUND?!
			 * JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE
			 **/
		}
	}

	public void loadScene(bool newGame){
		/**
		 * JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE
		 * ADD MAIN MENU BUTTON SOUND HERE
		 * JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE JAKE
		 **/

		_audioController.targetSource = _audioController.backgroundMusic;
		_audioController.fadingOut = true;
		if (!newGame) {
			
			menuScreen.SetActive(false);
			loadScreen.SetActive(true);
			Application.LoadLevelAsync (sceneNumber);
			StartLoading ();
			startCounting = true;

		} else {
			if( PlayerDataManager.playerDataManager.saveDataExists() )
				PlayerDataManager.playerDataManager.deleteSaveData();

			PlayerDataManager.playerDataManager.createNewData();
			menuScreen.SetActive(false);
			loadScreen.SetActive(true);
			//Application.LoadLevelAsync (sceneNumber);
			StartLoading();
			startCounting = true;
		}
	}

	public void quit(){
		Application.Quit ();
	}

	public void StartLoading() {
		StartCoroutine("load");
	}
	
	IEnumerator load() {
		Debug.LogWarning("ASYNC LOAD STARTED - " +
		                 "DO NOT EXIT PLAY MODE UNTIL SCENE LOADS... UNITY WILL CRASH");
		async = Application.LoadLevelAsync(sceneNumber);
		async.allowSceneActivation = false;
		yield return async;
	}
	
	public void ActivateScene() {
		async.allowSceneActivation = true;
	}
}
