using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Unit : MonoBehaviour {

	public Vector2 currentPosition, lastPosition;
	public ExploreMode_GameController _GameController;
	public GameObject _tile;
	
	public bool canMove;
	
	public bool movePressed;
	public bool attackPressed;
	public bool grabPressed;
	public bool waitPressed;
	
	public bool turnComplete;
	
	public int actionPoints;
	
	public int health;
	
	public int movement;
	public int attackRange;
	
	public bool moving, hasAttacked;
	public Vector2 target;
	
	public float moveSpeed = 1;

	public List<ExploreMode_GameController.Node> currentPath = null;

	public bool isElite;
	public int EliteState;
	public List<Unit> FolkUnits;
	public List<Unit> FolkUnitsWithinView;
	public List<Vector2> knownPosition;
	// Use this for initialization
	void Start () {
		currentPosition = new Vector2( transform.position.x, transform.position.z );
		moving = false;
		movePressed = false;
		attackPressed = false;
		grabPressed = false;
		waitPressed = false;
		turnComplete = false;
		hasAttacked = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (actionPoints <= 0) {
			turnComplete = true;
		}
		if(currentPath != null) {
			
			int currNode = 0;
			
			while( currNode < currentPath.Count-1 ) {
				//Debug.Log ( "generating line" );
				Vector3 start = new Vector3( currentPath[currNode].x +0.5f, 1, currentPath[currNode].y+0.5f );
				Vector3 end   = new Vector3( currentPath[currNode+1].x+0.5f,1, currentPath[currNode+1].y+0.5f );
				
				currNode++;
			}
			
		}
		MoveNextTile ();
	}
	public void MoveNextTile() {
		float remainingMovement = moveSpeed;
		
		while(remainingMovement > 0) {
			if(currentPath==null)
				return;
			
			// Get cost from current tile to next tile
			remainingMovement -= _GameController.CostToEnterTile(currentPath[0].x, currentPath[0].y, currentPath[1].x, currentPath[1].y );
			
			// Move us to the next tile in the sequence
			currentPosition.x = currentPath[1].x;
			currentPosition.y = currentPath[1].y;
			
			transform.position = new Vector3(currentPosition.x, 0, currentPosition.y);
			
			// Remove the old "current" tile
			currentPath.RemoveAt(0);
			
			if(currentPath.Count == 1) {
				// We only have one tile left in the path, and that tile MUST be our ultimate
				// destination -- and we are standing on it!
				// So let's just clear our pathfinding info.
				currentPath = null;
				canMove = false;
			}
		}
	}
	
	
	public void Move( Vector2 targetPosition ){
		_GameController.GeneratePathTo ((int)targetPosition.x, (int)targetPosition.y);
	}

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
		return d;
	}
	
	void MoveObject(Vector3 currentPos,  Vector3 endPos)
	{
		if (moving) {
			endPos = new Vector3 (endPos.x, 0, endPos.y);
			transform.position = Vector3.Lerp (currentPos, endPos, Time.deltaTime);
			if (transform.position == endPos) {
				moving = false;
			}
		}
	}

	public void EliteObserve(){
		foreach (Unit fU in FolkUnits) {
			if( Vector2.Distance ( currentPosition, fU.currentPosition ) < 6 ){
				if( !FolkUnitsWithinView.Contains( fU ) ){
					FolkUnitsWithinView.Add (fU);
					knownPosition.Add (fU.currentPosition);
				} else {
					knownPosition.Add (fU.currentPosition);
				}
			} else {
				if( FolkUnitsWithinView.Contains( fU ) ){
					//FolkUnitsWithinView.Remove (fU);
				}
			}
		}
	}

	public void EliteDetermineState(){
		if (knownPosition.Count <= 0) {
			EliteState = 1; // Idle
		} else if (knownPosition.Count > 0 && FolkUnitsWithinView.Count > 0) {
			EliteState = 3; // Attack
		} else if (knownPosition.Count > 0) {
			EliteState = 2; // Search
		}

		switch (EliteState) 
		{
			case 1:
				// conduct default behaviour
				Debug.Log ( "Idle State");
				break;
			case 2:
				Debug.Log ( "Pursuit State");
				break;
			case 3:
				Debug.Log ( "Eliminate State");
				break;
			default:
				Debug.Log ( "No State Defined");
				break;

		}
	}

	public Vector2 EliteCalcOptMoveTile(){
		Vector2 targetPosition = currentPosition;
		if (EliteState == 2) {
			float distToTargetPosition = 99.9f;
			for( int i = (int) currentPosition.x-movement; i <= (int) currentPosition.x + movement; i++){
				for( int j = (int) currentPosition.y-movement; j <= (int) currentPosition.y + movement; j++){
					float distToCurrent =  getDistance ( knownPosition[knownPosition.Count-1] , new Vector2( i,j) );
					if(  distToCurrent <= movement ){
						if( distToCurrent <= distToTargetPosition ){
							if( _GameController.GeneratePathTo( i , j , 0) ){
								targetPosition = new Vector2( i , j );
								distToTargetPosition = distToCurrent;
							}
						}
					}
				}
			}
			if( targetPosition == knownPosition[knownPosition.Count-1] ){
				knownPosition.Remove(knownPosition[knownPosition.Count-1]) ;
			}
		} else if (EliteState == 3) {
			float distToTargetPosition = 99.9f;
			for( int i = (int) currentPosition.x-movement; i <= (int) currentPosition.x + movement; i++){
				for( int j = (int) currentPosition.y-movement; j <= (int) currentPosition.y + movement; j++){
					float distToCurrent =  getDistance ( FolkUnitsWithinView[0].currentPosition , new Vector2( i,j) );
					if(  distToCurrent <= movement ){
						if( distToCurrent <= distToTargetPosition ){
							if( _GameController.GeneratePathTo( i , j,0 ) ){
								targetPosition = new Vector2( i , j );
								distToTargetPosition = distToCurrent;
							}
						}
					}
				}
			}
		}
		return targetPosition;
	}

	void Attack(Unit targetUnit){
	}

	bool calcChanceToHit(float distance, float weaponChance){
		bool hit = false;
		return hit;
	}
}
