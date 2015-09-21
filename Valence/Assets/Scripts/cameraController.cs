﻿using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

	/**
	 * 
	 * Modified code based on reference: http://forum.unity3d.com/threads/rts-camera-controller.93526/#post-607340
	 * 
	 *
	 **/ 


	Vector3 translation, targetPosition;
	int scrollArea = 25;
	float scrollSpeed = 15;
	int zoomSpeed = 50;
	int playBound = 50;
	int zoomMin = 15;
	int zoomMax = 50;

	int panSpeed = 50;
	int panAngleMin = 50;
	int panAngleMax = 60;

	float currentTime = -1;
	float initialTime;

	Vector2 lastMousePosition;
	// Use this for initialization
	void Start () {
		translation = new Vector3 (0,20,-10);
		GetComponent<Camera>().transform.position = translation;
		GetComponent<Camera> ().transform.eulerAngles = new Vector3 (30, 45, 0);

	}


	// Update is called once per frame
	void LateUpdate () {
		//Reset translation vector
		translation = Vector3.zero;
		targetPosition = Vector3.zero;

		float zoomDelta = Input.GetAxis("Mouse ScrollWheel")*zoomSpeed*Time.deltaTime;
		if (zoomDelta!=0)
		{
			translation -= Vector3.up * zoomSpeed * zoomDelta;
			targetPosition = transform.position + translation;
			if( targetPosition.y > zoomMin && targetPosition.y < zoomMax ){
				translation += Vector3.forward * ( Mathf.Tan(GetComponent<Camera>().transform.rotation.x)) * ( zoomSpeed * zoomDelta );
			}


		}
		/**
		float pan = GetComponent<Camera>().transform.eulerAngles.x - zoomDelta * panSpeed;
		pan = Mathf.Clamp(pan, panAngleMin, panAngleMax);
		if (zoomDelta != 0 || GetComponent<Camera>().transform.position.y < (zoomMax / 2))
		{
			GetComponent<Camera>().transform.eulerAngles = new Vector3(pan, GetComponent<Camera>().transform.eulerAngles.y, 0);
		}
		**/
		//Check for keyboard input

		if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis ("Vertical") != 0 ||
		    Input.mousePosition.x < scrollArea || Input.mousePosition.x >= Screen.width - scrollArea || 
		    Input.mousePosition.y < scrollArea || Input.mousePosition.y > Screen.height - scrollArea
		    ) {
			if( scrollSpeed < 15 ){

				if( currentTime == -1 ){
					initialTime = Time.time;
				}

				float duration = 0.5f;
				currentTime = Time.time - initialTime;
				currentTime /= duration;
				scrollSpeed = ( scrollSpeed * currentTime * currentTime + duration ) + 5;
				//scrollSpeed = -scrollSpeed * Mathf.Cos ( currentTime / duration * ( Mathf.PI/2)) + currentTime + duration;
				if( currentTime == duration ){
					currentTime = -1;
				}
				//scrollSpeed = scrollSpeed * scrollSpeed;
				/**
				 *  time /= duration
					delta * time * time * startValue
					return c*t*t + b;

					-c * Math.cos(t/d * (Math.PI/2)) + c + b;

					t /= d;
					return c*t*t*t + b;
				**/
			} else {
				scrollSpeed = 15;
			}
		} else {
			currentTime = -1;
			if( scrollSpeed > 5 ){
				scrollSpeed = (int) Mathf.Sqrt( scrollSpeed );
			} else {
				scrollSpeed = 5;
			} 
		}

		float horTranslation = Input.GetAxis ("Horizontal") * scrollSpeed * Time.deltaTime;
		float vertTranslation = Input.GetAxis ("Vertical") * scrollSpeed * Time.deltaTime;
		translation += new Vector3 (horTranslation, 0, vertTranslation);
		//Check for Mouse Input

			//Mouse Edge Screen Detection
		if (Input.mousePosition.x < scrollArea)
		{
			translation += Vector3.right * -scrollSpeed * Time.deltaTime;
		}
		
		if (Input.mousePosition.x >= Screen.width - scrollArea)
		{
			translation += Vector3.right * scrollSpeed * Time.deltaTime;
		}
		
		if (Input.mousePosition.y < scrollArea)
		{
			translation += Vector3.forward * -scrollSpeed * Time.deltaTime;
		}
		
		if (Input.mousePosition.y > Screen.height - scrollArea)
		{
			translation += Vector3.forward * scrollSpeed * Time.deltaTime;
		}


		// Check Play Area Bounds
		targetPosition = transform.position + translation;

		if (targetPosition.x < -playBound || playBound < targetPosition.x)
		{
			translation.x = 0;
		}
		if (targetPosition.y < zoomMin || zoomMax < targetPosition.y)
		{
			translation.y = 0;
		}
		if (targetPosition.z < -playBound || playBound < targetPosition.z)
		{
			translation.z = 0;
		}
		if (Input.GetMouseButton (0) && Input.GetKey ( KeyCode.LeftAlt ) ) {
			float rotateDelta = ((Input.mousePosition.x - lastMousePosition.x))*1.5f*Time.deltaTime;
			float rotatePan = GetComponent<Camera>().transform.eulerAngles.y - rotateDelta * 2;
			GetComponent<Camera>().transform.eulerAngles = new Vector3(GetComponent<Camera>().transform.eulerAngles.x, rotatePan, 0);
			//rotatePan = Mathf.Clamp(rotatePan, -180, 180);
			/**
			if( Input.mousePosition.x < Screen.width/2 ){
				GetComponent<Camera>().transform.eulerAngles = new Vector3(GetComponent<Camera>().transform.eulerAngles.x, -rotatePan, 0);
			} else {
				GetComponent<Camera>().transform.eulerAngles = new Vector3(GetComponent<Camera>().transform.eulerAngles.x, rotatePan, 0);
			}**/
		}
		// Translate Camera
		translation = Quaternion.AngleAxis(GetComponent<Camera>().transform.eulerAngles.y, Vector3.up) * translation;


		GetComponent<Camera>().transform.position += translation;

		lastMousePosition = Input.mousePosition;
	}

	float mapValue( float value, float minA, float maxA, float minB, float maxB ){
		return (value - minA) / (minB - minA) * (maxB - maxA) + maxA;
	}
}
