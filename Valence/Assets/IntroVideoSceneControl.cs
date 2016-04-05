using UnityEngine;
using System.Collections;

public class IntroVideoSceneControl : MonoBehaviour {
	public int sceneNumber = 3;
	AsyncOperation async;
	public float timer = 0.0f;
	public float loadNextSceneTime;
	public AudioSource videoClipAudio;
	public bool pressed;
	public bool firstLoad;
	// Use this for initialization
	void Start () {
		firstLoad = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (firstLoad && videoClipAudio != null) {
			loadNextSceneTime = videoClipAudio.clip.length;
			StartLoading ();
			firstLoad = false;
		}

		timer += Time.deltaTime;
		if ( timer > loadNextSceneTime && !firstLoad ){
			ActivateScene();
			pressed = true;
		}
		if (Input.anyKey && !pressed && !firstLoad ) {
			ActivateScene();
			pressed = true;
		}
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
		Debug.Log ("ACTIVATING");
		async.allowSceneActivation = true;
	}
}
