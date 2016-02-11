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

	public List<Vector3> newVerts;
	// Use this for initialization
	void Start () {
		myUnit = GetComponent<Unit> ();
		//myMeshFilter.mesh = mesh;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		positionWithOffset = new Vector3 (transform.position.x + 0.5f, 1.5f, transform.position.z + 0.5f);
		newVerts.Add (positionWithOffset);
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
					positionWithOffset.y = 0;
					if( hit.transform.gameObject.tag == "FolkUnit" ){
						Debug.DrawLine (positionWithOffset, hit.point, new Color(1,0,0,1));
					} else {
						Debug.DrawLine (positionWithOffset, hit.point, new Color(1,1,0,1));
					}
					newVerts.Add (hit.point);
					//var tmp = lightmeshholder.transform.InverseTransformPoint(hit.point);
					//vertices[i] = Vector3(tmp.x,0.5,tmp.z);
				}else{ // no hit
					positionWithOffset.y = 0;
					Debug.DrawRay (positionWithOffset, dir*distance, new Color(1,1,0,1));
					newVerts.Add (dir*distance);
					//var tmp2 = lightmeshholder.transform.InverseTransformPoint(lightmeshholder.transform.position+dir);
					//vertices[i] = Vector3(tmp2.x,0.5,tmp2.z);
				}
			}
		}

		Vector3[] vertArray = new Vector3[newVerts.Count];
		int index = 0;
		foreach (Vector3 v in newVerts) {
			vertArray[index] = v;
			index++;
		}
		newVerts.Clear ();
		myMeshFilter.mesh.vertices = vertArray;
	}
}
