using UnityEngine;
using System.Collections;

public class IntroVideoSceneControl : MonoBehaviour {
	public int sceneNumber = 3;
	AsyncOperation async;
	public float timer = 0.0f;
	public float loadNextSceneTime;
	public AudioSource videoClipAudio;
	// Use this for initialization
	void Start () {
		loadNextSceneTime = videoClipAudio.clip.length;
		StartLoading ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if ( timer > loadNextSceneTime ){
			ActivateScene();
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
		async.allowSceneActivation = true;
	}
}
