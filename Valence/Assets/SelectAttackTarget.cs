using UnityEngine;
using System.Collections;

public class SelectAttackTarget : MonoBehaviour {
	public ExploreMode_GameController _GameController;

	public Unit myParentScript;
	// Use this for initialization
	void Start () {
		myParentScript = this.transform.parent.gameObject.GetComponent<Unit> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		_GameController.selectedUnit.actionPoints--;
		myParentScript.generateSound (_GameController.selectedUnit.currentPosition, _GameController.selectedUnit.myWeapon.GetComponent<weaponScript> ().soundRange);
		Vector2 tempFacing = myParentScript.currentPosition - _GameController.selectedUnit.currentPosition;
		tempFacing.Normalize();
		_GameController.selectedUnit.facing = new Vector3( tempFacing.x, 0, tempFacing.y );
		if (_GameController.selectedUnit.calcChanceToHit(_GameController.selectedUnit.getDistance(_GameController.selectedUnit.currentPosition, myParentScript.currentPosition ) ) ) {
			_GameController.selectedUnit.Attack( myParentScript );
			_GameController.selectedUnit.hasAttacked = true;

			if( myParentScript.health <= 0 ){
				_GameController.elite.Remove (myParentScript);
				myParentScript.gameObject.SetActive (false);
			}


		}
		_GameController.disableAttackBox();
	}
}
