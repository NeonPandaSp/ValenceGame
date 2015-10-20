using UnityEngine;
using System.Collections.Generic;

public class ExploreMode_GameController : MonoBehaviour {
	
	static int mapSize = 50;
	public int[,] tiles;
	public Node[,] graph;
	
	public TileType[] tileTypes;

	public FolkUnit[] folk = new FolkUnit[4];
	public GameObject[] elite = new GameObject[4];

	public FolkUnit selectedUnit;
	public int selectedIndex;
	public SelectedIcon icon;

	public GameObject[,] tileVisuals;
	public GameObject moveTile;


	// Use this for initialization
	void Start () {
		tiles = new int[mapSize,mapSize];
		tileVisuals = new GameObject[mapSize, mapSize];

		GenerateNodeGraph ();

		for( int x = 0; x < mapSize; x++){
			for( int y = 0; y < mapSize; y++){
				int rand = Random.Range(0,10);
				if( rand == 1 ){
					tiles[x,y] = 2;
				} else {
					tiles[x,y] = 0;
				}
			}
		}
		for (int i = 0; i < 4; i++) {
			folk[i].transform.position =  new Vector3 (i + 1, 0, i+1);
			folk[i].currentPosition = new Vector2( i + 1, i + 1);
		}
		
		selectedUnit = folk [0];
		selectedIndex = 0;

		icon.selectUnit = selectedUnit;
		GenerateMovementRange ((int)selectedUnit.currentPosition.x,(int) selectedUnit.currentPosition.y);

		GenerateMap();
	}

	// Update is called once per frame
	void Update () {

	}

	public class Node{
		public List<Node> neighbours;
		public Vector2 nodePos;
		
		public Node(){
			neighbours = new List<Node>();
		}
	}

	public void GenerateMovementRange(int x, int y){
		for (int i = -5; i <= 5; i++) {
			for (int j=-5; j <= 5; j++) {
				if( selectedUnit.getDistance(new Vector2(x,y), new Vector2(x+i,y+j)) <= 5 ){
					GameObject ob = (GameObject) Instantiate (moveTile, new Vector3 (x+i, 0, y+j), Quaternion.identity);
					ob.transform.SetParent( selectedUnit.transform );
				}
			}
		}

	}

	public void GenerateMap(){
		for( int x = 0; x < mapSize; x++){
			for( int y = 0; y < mapSize; y++){
				/**
				TileType tt = tileTypes[ tiles[x,y] ];
				GameObject tileVisual = (GameObject) Instantiate ( tt.visualPrefab, new Vector3( x+0.5f, 0 , y+0.5f ), Quaternion.identity );
				tileVisual.transform.SetParent(this.gameObject.transform);
				tileVisuals[x,y] = tileVisual;
				**/
			}
		}
	}

	void GenerateNodeGraph(){
		graph = new Node[mapSize, mapSize];
		for (int x=0; x < mapSize; x++) {
			for (int y=0; y < mapSize; y++) {
				graph [x, y] = new Node ();
			}
		}
		for (int x=0; x < mapSize; x++) {
			for( int y=0; y < mapSize; y++){
				graph[x,y].nodePos = new Vector2(x,y);
				if( x > 0 )
					graph[x,y].neighbours.Add ( graph[x-1, y ] );
				if( x < mapSize - 1 )
					graph[x,y].neighbours.Add (graph[x+1, y ] );
				if( y > 0 )
					graph[x,y].neighbours.Add ( graph[x, y-1 ] );
				if( y < mapSize - 1 )
					graph[x,y].neighbours.Add (graph[x, y+1 ] );
			}
		}
	}
	public void MoveIcon(){
		icon.selectUnit = selectedUnit;
		selectedUnit.canMove = true;
	}
}
