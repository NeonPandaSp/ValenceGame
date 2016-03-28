using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PartyPanelScript : MonoBehaviour {
	public ExploreMode_GameController _gameController;

	public Text name, movement, strength;

	public Explore_HealthBar myBar;
	// Use this for initialization
	void Start () {
		_gameController = FindObjectOfType<ExploreMode_GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (_gameController.GameState == 1) {
			name.text = _gameController.selectedUnit.unitName;
			movement.text = _gameController.selectedUnit.movementRemaining + " / " + _gameController.selectedUnit.movement;
			strength.text = "" + _gameController.selectedUnit.attackRating;
			myBar.myUnit = _gameController.selectedUnit;
			myBar.myMax = 10;
		}
	}
}
