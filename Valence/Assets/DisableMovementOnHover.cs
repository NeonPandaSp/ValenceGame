using UnityEngine;
using System.Collections;

public class DisableMovementOnHover : MonoBehaviour {
	public ExploreMode_GameController _gameController;
	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver(){
		_gameController._inputController.hovering = true;
		_gameController._inputController.myLine.gameObject.SetActive(false);
		_gameController._inputController.moveTargetIcon.SetActive(false);
	}
	void OnMousePressed(){
		_gameController._inputController.hovering = true;
		_gameController._inputController.myLine.gameObject.SetActive(false);
		_gameController._inputController.moveTargetIcon.SetActive(false);
	}
}
