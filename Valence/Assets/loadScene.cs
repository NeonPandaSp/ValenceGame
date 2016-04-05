using UnityEngine;
using System.Collections;



public class loadScene : MonoBehaviour {
	public GameObject loadSceneObject;
	public int sceneNumber;
	AsyncOperation async;
	public bool startCounting = false;
	public float timer = 0.0f;

	public AudioController _audioController;

	public bool build;
	public GameObject uiStuff;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (startCounting) {
			Debug.Log ( "Loading Progres: " + async.progress + "%" );
			timer += Time.deltaTime;
			if( build )
				uiStuff.SetActive(false);
			if ( timer > 5 ){
				ActivateScene();
			}
		}
	}

	public void StartLoading() {
		_audioController.targetSource = _audioController.backgroundMusic;
		_audioController.fadingOut=true;

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
		Debug.Log ("Scene can now load");
		async.allowSceneActivation = true;
	}

	public void initLoadScene(int sceneNum){
		sceneNumber = sceneNum;
		loadSceneObject.SetActive (true);
		startCounting = true;
		StartLoading ();
	}
}
