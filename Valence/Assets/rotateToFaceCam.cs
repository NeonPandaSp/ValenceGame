using UnityEngine;
using System.Collections;

public class rotateToFaceCam : MonoBehaviour {
	public GameObject camObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (camObj.transform.position);
	}
}
