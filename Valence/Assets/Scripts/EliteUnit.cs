using UnityEngine;
using System.Collections.Generic;

public class EliteUnit : MonoBehaviour {

	public ExploreMode_GameController _GameController;
	public Vector2 currentPosition, lastPosition;

	public int maxMovement;
	public int state; // states: 0 == default, 1 == wander, 2 == hostile
	public bool canMove;

	public List<ExploreMode_GameController.Node> currentPath = null;
	// Use this for initialization
	void Start () {
		//maxMovement = 5;
		state = 1;
	}
	
	// Update is called once per frame
	void Update () {
		currentPosition = new Vector2 (transform.position.x, transform.position.z);
	}

	public void checkState(){
		/**
		foreach (FolkUnit fU in _GameController.folk) {
			float dist = Vector3.Distance( transform.position, fU.transform.position );
			if( dist <= 10 ){
				state = 2;
			} else{
				state = 1;
			}
		}**/
	}
	public void move(){
		switch (state)
		{
		case 1:
//			int moveAmount = (int) Random.Range(1, maxMovement);
//			int moveX = (int) Random.Range (1,moveAmount);
//			int moveY = (int) moveAmount - moveX;
//			int hDirection = (int) Random.Range (0,1) - 1;
//			int vDirection = (int) Random.Range (0,1) - 1;
//
//			moveX = moveX * hDirection;
//			moveY = moveY * vDirection;
//
//			transform.position = new Vector3( transform.position.x + moveX, 0, transform.position.z + moveY );
//
			float minDist = 99.9f;
			Vector2 minDistTarget = new Vector2( transform.position.x, transform.position.z);
			for( int i = (int) currentPosition.x-maxMovement; i <= (int) currentPosition.x+maxMovement; i++){
				for( int j = (int) currentPosition.y-maxMovement; j <= (int) currentPosition.y+maxMovement; j++){
					//Debug.Log ( i + " " + j );
					if( i < 50 && i > 0 && j < 50 && j > 0 ){
						//if( _GameController.GeneratePathTo( i, j, this ) || true ){
							foreach (FolkUnit fU in _GameController.folk) {
								float dist = Vector3.Distance( new Vector3(i,0,j), fU.transform.position );
								if( dist < minDist ){
									minDist = dist;
									minDistTarget = new Vector2(i,j);
								}
							}
						//}

					}
				}
			}
			if( minDist < 99 && canMove ){
				transform.position = new Vector3( minDistTarget.x, 0, minDistTarget.y );
			}
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
