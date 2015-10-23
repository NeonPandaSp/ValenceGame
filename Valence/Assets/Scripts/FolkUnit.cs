using UnityEngine;
using System.Collections;

public class FolkUnit : MonoBehaviour {
	public Vector2 currentPosition, lastPosition;
	public ExploreMode_GameController _GameController;
	public GameObject _tile;

	public bool canMove;

	public int health;

	public int movement;
	public int range;

	public bool moving;
	public Vector2 target;


	// Use this for initialization
	void Start () {
		currentPosition = new Vector2( transform.position.x, transform.position.z );
	}
	
	// Update is called once per frame
	void Update () {
		currentPosition = new Vector2 (transform.position.x, transform.position.z);
		if (moving) {
			MoveObject( transform.position, target );
		}
	}

	public void Move( Vector2 targetPosition ){
		lastPosition = transform.position;
		//moveStart (targetPosition);
		moving = true;
		target = targetPosition;
		//transform.position = Vector3.Lerp (lastPosition, new Vector3 (targetPosition.x, 0, targetPosition.y), 3.0f);
		//transform.position = new Vector3 (targetPosition.x, 0, targetPosition.y);
		currentPosition = targetPosition;
		canMove = false;
	}
	/**
	IEnumerator moveStart(Vector2 targetPosition){
		while( true ){
			yield return StartCoroutine( MoveObject(transform, new Vector3( lastPosition.x, 0, lastPosition.y), new Vector3( targetPosition.x, 0, targetPosition.y) , 3.0f));
		}
	}**/

	public bool withinMoveRange( Vector2 targetPosition ){
		if (movement >= getDistance (currentPosition, targetPosition)) {
			return true;
		} else {
			return false;
		}
	}

	public int getDistance( Vector2 p1, Vector2 p2 ){
		int horD = (int) Mathf.FloorToInt( Vector2.Distance ( new Vector2( p2.x,0), new Vector2( p1.x,0) ) );
		int verD = (int) Mathf.FloorToInt( Vector2.Distance ( new Vector2( 0,p2.y), new Vector2( 0,p1.y) ) );
		int d = horD + verD;

		// int d = Mathf.FloorToInt( Vector2.Distance (p1, p2) );
		Debug.Log (d);
		return d;
	}

	void MoveObject(Vector3 currentPos,  Vector3 endPos)
	{
		endPos = new Vector3 (endPos.x, 0, endPos.y);
		transform.position = Vector3.Lerp(currentPos, endPos, Time.deltaTime);
		if (transform.position == endPos) {
			moving = false;
		}

	}
}
