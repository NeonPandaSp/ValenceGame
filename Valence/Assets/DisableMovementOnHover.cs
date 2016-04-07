using UnityEngine;
using System.Collections;

public class DisableMovementOnHover : MonoBehaviour {
	public ExploreMode_GameController _gameController;
	// Use this for initialization
	void Start () {
		_gameController = FindObjectOfType<ExploreMode_GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver(){
		_gameController._inputController.hovering = true;
		_gameController._inputController.myLine.gameObject.SetActive(false);
		_gameController._inputController.moveTargetIcon.SetActive(false);
		_gameController._inputController.currentTile = _gameController.selectedUnit.currentPosition;
	}
	void OnMousePressed(){
		_gameController._inputController.hovering = true;
		_gameController._inputController.myLine.gameObject.SetActive(false);
		_gameController._inputController.moveTargetIcon.SetActive(false);
		_gameController._inputController.currentTile = _gameController.selectedUnit.currentPosition;
	}

	public void disableMovement(){
		Debug.Log ("hovering");
		_gameController._inputController.atkHovering = true;
		_gameController._inputController.myLine.gameObject.SetActive(false);
		_gameController._inputController.moveTargetIcon.SetActive(false);
		_gameController._inputController.currentTile = _gameController.selectedUnit.currentPosition;
	}

	public void enableMovement(){
		_gameController._inputController.atkHovering = false;
	}
}
