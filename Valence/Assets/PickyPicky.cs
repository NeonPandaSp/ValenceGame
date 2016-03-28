using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickyPicky : MonoBehaviour {
	public Image scrapObj;
	public Text scrapText;

	public Sprite pickUp, drop;

	public ExploreMode_GameController _gameController;
	// Use this for initialization
	void Start () {
		_gameController = FindObjectOfType<ExploreMode_GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (_gameController.selectedUnit.hasScrap) {
			scrapObj.sprite = drop;
			scrapText.text = "Drop Scrap";
		} else {
			scrapObj.sprite = pickUp;
			scrapText.text = "Grab Scrap";
		}
	}
}
