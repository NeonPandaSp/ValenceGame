using UnityEngine;
using System.Collections;

public class generateZone : MonoBehaviour {
	public float zoneWidth;
	public float zoneHeight;
	public float zoneX, zoneZ; //Zone Location

	public GameObject boundObject;
	// Use this for initialization
	void Start () {
		boundObject = (GameObject) Resources.Load ("BoundObject");
		Generate (getPropNum());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	int getPropNum(){
		float zoneArea = zoneWidth * zoneHeight;
		if (zoneArea < 4) {
			return 0;
		} else {
			return ( (int) (zoneArea / 4)); 
		}
		
	}

	void Generate(int numProps){
		GameObject zoneBounds = (GameObject)Instantiate (boundObject, new Vector3 (zoneX, 3, zoneZ), Quaternion.identity);
		zoneBounds.gameObject.GetComponent<BoxCollider> ().size = new Vector3 (zoneWidth, 6, zoneHeight);
		if (numProps > 0) {
			for (int i = 0; i <= numProps; i++) {
				Vector3 propPosition = new Vector3 (Random.Range (zoneX - (zoneWidth / 2),zoneX + (zoneWidth / 2)), 0.5f ,  Random.Range (zoneZ - (zoneHeight / 2),zoneZ + (zoneHeight / 2)));
				//propRotation = Quaternion.identity;
				//propRotation.y = Random.Range (0,1200);
				int randVal = (int) Random.Range (0,8);
				GameObject tempObject = (GameObject ) Instantiate(Resources.Load("prop_"+randVal), propPosition, Quaternion.identity);
				tempObject.transform.eulerAngles = new Vector3 (Random.Range (0,45), Random.Range(0, 360), Random.Range (0,45));
				tempObject.GetComponent<PropScript>().setZoneCoords( zoneWidth, zoneHeight, zoneX, zoneZ );

			}
		}
	}
}
