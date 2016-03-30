using UnityEngine;
using System.Collections;

public class littleCameraController : MonoBehaviour {
	public Unit myParent;

	public Vector3 parentFacing;
	// Use this for initialization
	void Start () {
		myParent = transform.parent.GetComponent<Unit> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (myParent._GameController.selectedUnit == myParent) {
			GetComponent<Camera>().enabled = true;
			transform.position = myParent.gameObject.transform.position + new Vector3 (myParent.facing.x * 0.75f + 0.5f, 1.25f, myParent.facing.z * 0.75f + 0.5f);
			parentFacing = myParent.facing;
			Vector3 lookAtPosition = new Vector3 (myParent.gameObject.transform.position.x + 0.5f, 1.25f, myParent.gameObject.transform.position.z + 0.5f);

			transform.LookAt (lookAtPosition);
		} else {
			GetComponent<Camera>().enabled = false;
		}
	}
}
