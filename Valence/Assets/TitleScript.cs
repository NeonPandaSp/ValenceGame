using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {
	public GameObject menuScreen, titleScreen;
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

	public void loadScene(int sceneNumber){
		Application.LoadLevel (sceneNumber);
	}
}
