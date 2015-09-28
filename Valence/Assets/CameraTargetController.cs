using UnityEngine;
using System.Collections;

public class CameraTargetController : MonoBehaviour {
	public GameObject ground;

	public Vector3 lastPosition, lastRotation;
	// Use this for initialization
	void Start () {
		lastPosition = transform.position;
		lastRotation = new Vector3 ( transform.rotation.x, transform.rotation.y, transform.rotation.z);
	}
	
	// Update is called once per frame
	void Update () {
		float rotateDelta = 50;
		Vector3 centerScreen = new Vector2( Screen.width/2, Screen.height/2 );
		Ray ray = Camera.main.ScreenPointToRay ( centerScreen );
		RaycastHit hitInfo;
		
		if ( ground.GetComponent<Collider>().Raycast (ray, out hitInfo, Mathf.Infinity)) {
			int x = Mathf.FloorToInt( hitInfo.point.x );
			int z = Mathf.FloorToInt( hitInfo.point.z );
			Vector3 lookAtTarget;
			lookAtTarget = new Vector3( x, 0, z );
			transform.position = lookAtTarget;
			//Camera.main.transform.position = new Vector3 (lookAtTarget.x, Camera.main.transform.position.y, Camera.main.transform.position.z );
			//Camera.main.transform.LookAt (lookAtTarget);

			
		}
		if (Input.GetMouseButton (0) && Input.GetKey (KeyCode.LeftAlt)) {
			transform.Rotate(transform.up * rotateDelta * Time.deltaTime);
			Vector3 myRotation = new Vector3 ( transform.rotation.x, transform.rotation.y, transform.rotation.z );


			//Camera.main.transform.position += transform.position - lastPosition;
			//Camera.main.transform.eulerAngles += myRotation - lastRotation;
		}
		lastPosition = transform.position;
		lastRotation = new Vector3 ( transform.rotation.x, transform.rotation.y, transform.rotation.z);
	}
}
