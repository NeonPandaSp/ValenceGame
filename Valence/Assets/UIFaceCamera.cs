using UnityEngine;
using System.Collections;

public class UIFaceCamera : MonoBehaviour {
	public Camera myCamera;
	// Use this for initialization
	void Start () {
		myCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (transform.position + myCamera.transform.rotation * Vector3.back,
		                 myCamera.transform.rotation * Vector3.up);
	}
}
