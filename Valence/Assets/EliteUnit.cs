using UnityEngine;
using System.Collections;

public class EliteUnit : MonoBehaviour {

	public ExploreMode_GameController _GameController;
	public int maxMovement;
	public int state; // states: 0 == default, 1 == wander, 2 == hostile
	public bool canMove;

	// Use this for initialization
	void Start () {
		maxMovement = 5;
		state = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void checkState(){
		foreach (FolkUnit fU in _GameController.folk) {
			float dist = Vector3.Distance( transform.position, fU.transform.position );
			if( dist <= 10 ){
				state = 2;
			} else{
				state = 1;
			}
		}
	}
	public void move(){
		switch (state)
		{
		case 1:
			int moveAmount = (int) Random.Range(1, maxMovement);
			int moveX = (int) Random.Range (1,moveAmount);
			int moveY = (int) moveAmount - moveX;
			int hDirection = (int) Random.Range (0,1) - 1;
			int vDirection = (int) Random.Range (0,1) - 1;

			moveX = moveX * hDirection;
			moveY = moveY * vDirection;

			transform.position = new Vector3( transform.position.x + moveX, 0, transform.position.z + moveY );

			canMove = false;
			break;
		case 2:
			Debug.Log ("NO ACTION");
			canMove = false;
			break;
		default:
			break;
		}
	}
	public void action(){
		Debug.Log ("No Action");
	}
}
