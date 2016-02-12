using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LineOfSight : MonoBehaviour {
	Unit myUnit;
	public MeshFilter myMeshFilter;

	public float distance;
	public float angle;
	public int ConeResolution;

	public Vector3 positionWithOffset;

	public List<Vector2> newVerts;
	// Use this for initialization
	void Start () {
		myUnit = GetComponent<Unit> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKeyDown (KeyCode.P)) {
			UpdateMesh ();
		}

	}

	void UpdateMesh(){
		positionWithOffset = new Vector3 (transform.position.x + 0.5f, 1.5f, transform.position.z + 0.5f);
		newVerts.Add (new Vector2( positionWithOffset.x, positionWithOffset.z ) );
		for (int i =0; i < ConeResolution;i++)
		{
			var x = Mathf.Sin(angle);
			var y = Mathf.Cos(angle);
			angle += 2*Mathf.PI/ConeResolution;
			if( angle >= 360 )
				angle = 0;
			Vector3 dir = new Vector3(x,0,y);
			
			float tempAngle = Vector3.Angle(dir, myUnit.facing);
			
			if( tempAngle < myUnit.fieldOfViewAngle* 0.5f  ){
				
				RaycastHit hit;
				if (Physics.Raycast (positionWithOffset, dir,out hit, distance)) 
				{
					if( hit.transform.gameObject.tag == "FolkUnit" ){
						Debug.DrawLine (positionWithOffset, hit.point, new Color(1,0,0,1));
					} else {
						Debug.DrawLine (positionWithOffset, hit.point, new Color(1,1,0,1));
					}
					Vector3 tmp = hit.point;
					newVerts.Add (new Vector2 ((int) tmp.x,(int) tmp.z ) );
					//var tmp = lightmeshholder.transform.InverseTransformPoint(hit.point);
					//vertices[i] = Vector3(tmp.x,0.5,tmp.z);
				}else{ // no hit
					positionWithOffset.y = 0;
					Debug.DrawRay (positionWithOffset, dir*distance, new Color(1,1,0,1));
					Vector3 tempVector = positionWithOffset + dir*distance;
					newVerts.Add (new Vector2( (int) tempVector.x, (int) tempVector.z) );
					//var tmp2 = lightmeshholder.transform.InverseTransformPoint(lightmeshholder.transform.position+dir);
					//vertices[i] = Vector3(tmp2.x,0.5,tmp2.z);
				}
			}
		}
		
		
		Vector2[] vertArray = new Vector2[newVerts.Count];
		int index = 0;
		foreach (Vector2 v in newVerts) {
			Debug.Log ( v.x + " " + v.y );
			vertArray[index] = v;
			index++;
		}
		Triangulator tr = new Triangulator(vertArray);
		int[] indices = tr.Triangulate();
		foreach (int i in indices)
			Debug.Log ("indices " + i);
		index = 0;
		Vector3[] vertArray3D = new Vector3[newVerts.Count];
		foreach (Vector2 v in vertArray) {
			vertArray3D[index] = new Vector3(v.x, v.y, 0.1f);
		}
		newVerts.Clear ();
		Mesh myMesh = new Mesh();
		myMesh.vertices = vertArray3D;
		myMesh.triangles = indices;
		myMesh.RecalculateNormals();
		myMesh.RecalculateBounds();
		
		// Set up game object with mesh;
		gameObject.AddComponent(typeof(MeshRenderer));
		MeshFilter filter = gameObject.AddComponent(typeof(MeshFilter)) as MeshFilter;
		filter.mesh = myMesh;
	}
}

public class Triangulator{
	private List<Vector2> m_points = new List<Vector2>();
	
	public Triangulator (Vector2[] points) {
		m_points = new List<Vector2>(points);
	}
	
	public int[] Triangulate() {
		List<int> indices = new List<int>();
		
		int n = m_points.Count;
		if (n < 3)
			return indices.ToArray();
		
		int[] V = new int[n];
		if (Area() > 0) {
			for (int v = 0; v < n; v++)
				V[v] = v;
		}
		else {
			for (int v = 0; v < n; v++)
				V[v] = (n - 1) - v;
		}
		
		int nv = n;
		int count = 2 * nv;
		for (int m = 0, v = nv - 1; nv > 2; ) {
			if ((count--) <= 0)
				return indices.ToArray();
			
			int u = v;
			if (nv <= u)
				u = 0;
			v = u + 1;
			if (nv <= v)
				v = 0;
			int w = v + 1;
			if (nv <= w)
				w = 0;
			
			if (Snip(u, v, w, nv, V)) {
				int a, b, c, s, t;
				a = V[u];
				b = V[v];
				c = V[w];
				indices.Add(a);
				indices.Add(b);
				indices.Add(c);
				m++;
				for (s = v, t = v + 1; t < nv; s++, t++)
					V[s] = V[t];
				nv--;
				count = 2 * nv;
			}
		}
		
		indices.Reverse();
		return indices.ToArray();
	}
	
	private float Area () {
		int n = m_points.Count;
		float A = 0.0f;
		for (int p = n - 1, q = 0; q < n; p = q++) {
			Vector2 pval = m_points[p];
			Vector2 qval = m_points[q];
			A += pval.x * qval.y - qval.x * pval.y;
		}
		return (A * 0.5f);
	}
	
	private bool Snip (int u, int v, int w, int n, int[] V) {
		int p;
		Vector2 A = m_points[V[u]];
		Vector2 B = m_points[V[v]];
		Vector2 C = m_points[V[w]];
		if (Mathf.Epsilon > (((B.x - A.x) * (C.y - A.y)) - ((B.y - A.y) * (C.x - A.x))))
			return false;
		for (p = 0; p < n; p++) {
			if ((p == u) || (p == v) || (p == w))
				continue;
			Vector2 P = m_points[V[p]];
			if (InsideTriangle(A, B, C, P))
				return false;
		}
		return true;
	}
	
	private bool InsideTriangle (Vector2 A, Vector2 B, Vector2 C, Vector2 P) {
		float ax, ay, bx, by, cx, cy, apx, apy, bpx, bpy, cpx, cpy;
		float cCROSSap, bCROSScp, aCROSSbp;
		
		ax = C.x - B.x; ay = C.y - B.y;
		bx = A.x - C.x; by = A.y - C.y;
		cx = B.x - A.x; cy = B.y - A.y;
		apx = P.x - A.x; apy = P.y - A.y;
		bpx = P.x - B.x; bpy = P.y - B.y;
		cpx = P.x - C.x; cpy = P.y - C.y;
		
		aCROSSbp = ax * bpy - ay * bpx;
		cCROSSap = cx * apy - cy * apx;
		bCROSScp = bx * cpy - by * cpx;
		
		return ((aCROSSbp >= 0.0f) && (bCROSScp >= 0.0f) && (cCROSSap >= 0.0f));
	}
}
