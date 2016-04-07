using UnityEngine;
using System.Collections;



public class loadScene : MonoBehaviour {
	public GameObject loadSceneObject;
	public int sceneNumber;
	AsyncOperation async;
	public bool startCounting = false;
	public float timer = 0.0f;
	public float timeTillLoad = 5.0f;
	public AudioController _audioController;

	public bool build;

	public bool preventDoublePress = false;

	public GameObject uiStuff;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (startCounting) {
			//Debug.Log ( "Loading Progres: " + async.progress + "%" );
			if( async != null ){
				Debug.Log ( "Loading Progres: " + async.progress + "%" );
				if( async.isDone ){
					Destroy ( this.gameObject );
				}
			}

			timer += Time.deltaTime;
			if (build)
				uiStuff.SetActive (false);
			if (timer > timeTillLoad) {
				ActivateScene ();
			}
		} else {

		}
	}

	public void StartLoading() {
		if (_audioController.backgroundMusic != null)
			Debug.Log ("Bg Audio Found");
		else 
			Debug.Log ("No BG Audio Found");

		_audioController.targetSource = _audioController.backgroundMusic;
		_audioController.fadingOut=true;

		Debug.Log ("Loading Starting, Coroutine Called");
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
		if (!preventDoublePress) {
			Debug.Log ("Loading Initialized @ " + Time.time);
			Debug.Log ("Trying to load scene " + sceneNum);
			sceneNumber = sceneNum;
			loadSceneObject.SetActive (true);
			startCounting = true;
			StartLoading ();
			preventDoublePress = true;
		}
	}
	public void changeUIObject(GameObject newObj){
		loadSceneObject = newObj;
	}
}
