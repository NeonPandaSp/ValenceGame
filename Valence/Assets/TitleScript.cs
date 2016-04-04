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
		// play accept sound
		_audioController.playAudioClipOnce (0, Vector3.zero, 500);

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

			sceneNumber = 10;
			menuScreen.SetActive(false);
			loadScreen.SetActive(true);
			//Application.LoadLevelAsync (sceneNumber);
			StartLoading();
			startCounting = true;
		}
	}

	public void settings() { //Tyler this is the settings button! - j
		_audioController.playAudioClipOnce (0, Vector3.zero, 500);
	}


	public void quit(){
		_audioController.playAudioClipOnce (0, Vector3.zero, 500);
		Application.Quit ();
	}

	public void StartLoading() {
		StartCoroutine("load");
	}

	public void hovering(int sndNum ){
			if( sndNum == 0 )
				_audioController.playAudioClipOnce (1, Vector3.zero, 500);
			else if ( sndNum == 1)
				_audioController.playAudioClipOnce (2, Vector3.zero, 500);
			else if ( sndNum == 3 )
				_audioController.playAudioClipOnce (3, Vector3.zero, 500);
			
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
