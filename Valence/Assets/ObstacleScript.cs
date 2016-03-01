using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {
	public ExploreMode_GameController _GameController;
	public int myTileType;
	public int myWidth;
	public int myHeight;
	public Vector2 myOrigin;
	public BoxCollider myBox;
	// Use this for initialization
	void Start () {
		_GameController = FindObjectOfType<ExploreMode_GameController>();
		myBox = GetComponentInChildren<BoxCollider> ();
		myWidth = (int) myBox.size.x;
		myHeight = (int) myBox.size.z;
		updateTileMap ();
	}

	void updateTileMap(){
		myOrigin = new Vector2 (Mathf.CeilToInt( transform.position.x-(myWidth/2) ) , Mathf.CeilToInt(transform.position.z-(myHeight/2)));
		for (int i =(int) myOrigin.x; i < (int) myOrigin.x+myWidth; i++) {
			for( int j =(int) myOrigin.y; j < (int) myOrigin.y+myHeight; j++ ){
				if( i >= 0 && i < _GameController.mapSize && j >= 0 && j < _GameController.mapSize )
					_GameController.tiles [i,j] = myTileType;
			}
		}
	}
}
