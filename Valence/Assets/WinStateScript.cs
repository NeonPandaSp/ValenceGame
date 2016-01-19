using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinStateScript : MonoBehaviour {
	public ExploreMode_GameController _gameController;

	int folkInitialPartySize;

	public Vector2 rootPosition; 

	bool win, lose;

	public Image endScreen;
	public Canvas mainUI;

	public Text winText;
	public Text rewardsText;
	public Text lossesText;
	// Use this for initialization
	void Start () {
		endScreen.gameObject.SetActive (false);

		win = false;
		lose = false;

		folkInitialPartySize = _gameController.folk.Count;
	}
	
	// Update is called once per frame
	void Update () {
		if (!win && !lose) {
			if (_gameController.folk.Count <= 0) {
				lose = true;
			}
			foreach (Unit fU in _gameController.folk) {
				if (fU.hasScrap) {
					if (fU.getDistance (fU.currentPosition, rootPosition) <= 2) {
						win = true;
					}
				}

			}
		} else {
			winScreen();
		}
	}

	void winScreen(){
		endScreen.gameObject.SetActive (true);
		mainUI.gameObject.SetActive (false);
		if (win) {
			winText.text = "Mission Complete";
			rewardsText.text = "Rewards are generated here";
		} else {
			winText.text = "Mission Failed";
			rewardsText.text = "---";
		}
		lossesText.text = "" + ( folkInitialPartySize - _gameController.folk.Count) + " casualties.";
	}

	void loseScreen(){

	}
}
