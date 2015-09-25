using UnityEngine;
using System.Collections;

//[ ExecuteInEditMode ]
[ RequireComponent(typeof(MeshFilter))]
[ RequireComponent(typeof(MeshRenderer))]
[ RequireComponent(typeof(MeshCollider))]
public class TileMap : MonoBehaviour {
	// Use this for initialization

	public int worldSizeX = 100;
	public int worldSizeZ = 100;
	public float tileSize = 1.0f;

	void Start () {
		BuildMesh ();
	}
	void BuildMesh(){

		int numTiles 	= worldSizeX * worldSizeZ;
		int numTris 	= numTiles * 2;

		int vSizeX 		= worldSizeX + 1;
		int vSizeZ 		= worldSizeZ + 1;
		int numVerts 	= vSizeX * vSizeZ;

		Vector3[] vertices 	= new Vector3[numVerts];
		Vector3[] normals 	= new Vector3[numVerts];
		Vector2[] uv 		= new Vector2[numVerts];

		int[] triangles = new int[ numTris * 3 ];

		int x, z; 
		for (z = 0; z < vSizeZ; z++) {
			for(x = 0; x < vSizeX; x++){
				vertices[ z * vSizeX + x ] 	= new Vector3( x*tileSize, 0, z*tileSize);
				normals[ z * vSizeX + x ] 	= Vector3.down;
				uv[ z * vSizeX + x ] 		= new Vector2((float) x/worldSizeX,(float) z/worldSizeZ);
			}
		}
		
		for (z = 0; z < worldSizeZ; z++) {
			for(x = 0; x < worldSizeX; x++){
				int squareIndex = z * worldSizeX + x;
				int triOffset = squareIndex * 6;
				triangles[triOffset + 0] = z * vSizeX + x + 0;
				triangles[triOffset + 2] = z * vSizeX + x + vSizeX + 1;
				triangles[triOffset + 1] = z * vSizeX + x + vSizeX + 0;

				triangles[triOffset + 3] = z * vSizeX + x + 0;
				triangles[triOffset + 5] = z * vSizeX + x + 1;
				triangles[triOffset + 4] = z * vSizeX + x + vSizeX + 1;


			}
		}
		

		Mesh mesh = new Mesh ();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.normals = normals; 
		mesh.uv = uv;


		MeshFilter myFilter = GetComponent<MeshFilter> ();
		MeshRenderer myRenderer = GetComponent<MeshRenderer> ();
		MeshCollider myCollider = GetComponent<MeshCollider> ();

		myFilter.mesh = mesh;
		myCollider.sharedMesh = mesh;

	}
}
