using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Explore_Pause : MonoBehaviour {
	public GameObject pauseMenuObj;

	public ExploreMode_GameController _gameController;
	public WinStateScript _winScript;

	public Text extraInfo;
	
	List<int> escapeScore = new List<int>();

	bool isPause;

	bool escaping; 

	List<bool> escapeSuccess = new List<bool>();

	float timer;
	// Use this for initialization
	void Start () {
		_gameController = FindObjectOfType<ExploreMode_GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			pauseGame();
		}

		if (isPause) {
			int i = 0;
			foreach (Unit fU in _gameController.folk) {

				if (escaping) {
					timer += Time.deltaTime;
				}

				int newScore = 0;
				float distToExit = Vector2.Distance( fU.currentPosition , _winScript.rootPosition );
				newScore += (int) distToExit * 3;

				foreach( Unit eU in _gameController.elite){
					if ( eU.FolkUnitsWithinView.Contains(fU) ){
						newScore += 10;
					}
				}
				if( i >= escapeScore.Count ){
					escapeScore.Add( 100 - newScore );
				} else {
					escapeScore[i] = 100 - newScore;
				}
				i++;
			}
			extraInfo.text = "Retreat and return to Settlement? If you opt to retreat \n";
			for( int index = 0; index < escapeScore.Count; index++){
				if( timer > 3 * index + 1 ){
					if( escapeSuccess[index] )
						extraInfo.text += "" + _gameController.folk[index].unitName + " has a " + escapeScore[index] + "% chance of survival... <color=#00ff00ff>ESCAPED!</color> \n";
					else
						extraInfo.text += "" + _gameController.folk[index].unitName + " has a " + escapeScore[index] + "% chance of survival... <color=#ff0000ff> FAILED.</color> \n";

				} else {
					extraInfo.text += "" + _gameController.folk[index].unitName + " has a " + escapeScore[index] + "% chance of survival \n"; 
				}
			}

			if( timer > 3 * escapeScore.Count + 2 ){
				int indexio = 0;
				foreach( bool b in escapeSuccess ){
					if( !b ){
						_gameController.folk[indexio].health = 0;
					}
					indexio++;
				}
				_winScript.lose = true;
			}
		}
	}

	public void pauseGame(){
		isPause = !isPause;
		if (isPause) {
			//Time.timeScale = 0;
			pauseMenuObj.SetActive (true);
		} else {
			//Time.timeScale = 1;
			pauseMenuObj.SetActive (false);
		}
	}

	public void retreat(){
		escaping = true;
		timer = 0;
		Debug.Log ("ESCAPE PRESSED");
		for (int i = 0; i < escapeScore.Count; i ++) {
			int rand = Random.Range (0,100);
			if( rand < escapeScore[i] ){
				escapeSuccess.Add( true );
			} else {
				escapeSuccess.Add( false );
			}
		} 
	}


}
