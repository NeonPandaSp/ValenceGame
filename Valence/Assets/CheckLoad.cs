using UnityEngine;
using System.Collections;

public class CheckLoad : MonoBehaviour {
	GameController _gameController;
	// Use this for initialization
	void Start () {
		_gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
		if (!_gameController.firstLoad)
			Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
