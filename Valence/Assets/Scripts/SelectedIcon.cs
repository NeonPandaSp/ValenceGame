using UnityEngine;
using System.Collections;

public class SelectedIcon : MonoBehaviour {
	public Unit selectUnit;

	public Vector3 rV = new Vector3(0,1,0);

	Color currentColor;
	Color red, white;

	public bool isSelector;

	ExploreMode_GameController _gameController;
	// Use this for initialization
	void Start () {
		_gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ExploreMode_GameController> ();
		red = Color.red;
		white = Color.white;
		currentColor = white;
	}
	
	// Update is called once per frame
	void Update () {
		if( isSelector )
			selectUnit = _gameController.selectedUnit;
		if (selectUnit != null) {
			if( selectUnit.isElite && currentColor != red ){
				GetComponentInChildren<SpriteRenderer>().color = Color.red;
				currentColor = red;
			} else if( !selectUnit.isElite && currentColor != white ) {
				GetComponentInChildren<SpriteRenderer>().color = Color.white;
				currentColor = white;
			}
			transform.position = new Vector3 (selectUnit.transform.position.x + 0.5f, 0, selectUnit.transform.position.z + 0.5f);
		}
		transform.Rotate ((50 * Time.deltaTime)*rV.x, (50 * Time.deltaTime)*rV.y,(50 * Time.deltaTime)*rV.z);
	}
}
