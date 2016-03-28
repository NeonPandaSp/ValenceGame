using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OpeningCamera : MonoBehaviour {
	public int waypointIndex;
	public List<Transform> waypoints;

	public Transform startMarker;
	public Transform endMarker;

	public float speed = 1.0F;

	public float startTime;
	public float journeyLength;

	public GameObject scrapObj;
	public GameObject selectedPlayer;

	// Use this for initialization
	void Start () {
		waypointIndex = 0;
		startTime = Time.time;

		waypoints.Add ( Camera.main.transform );
		journeyLength = Vector3.Distance(waypoints[waypointIndex].position, waypoints[waypointIndex+1].position);
		speed = journeyLength;
		startMarker = waypoints [waypointIndex];
		endMarker = waypoints [waypointIndex + 1];
		transform.LookAt (waypoints [waypointIndex + 1].position );
	}
	
	// Update is called once per frame
	void Update () {
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp (startMarker.position, endMarker.position, fracJourney);
		if (Vector3.Distance (transform.position, waypoints [waypointIndex+1].position) < 1.0f) {
			if( waypoints.Count > waypointIndex+2 ){
				waypointIndex++;
				startTime = Time.time;
				journeyLength = Vector3.Distance(waypoints[waypointIndex].position, waypoints[waypointIndex+1].position);
				speed = journeyLength;
				startMarker = waypoints[waypointIndex];
				endMarker = waypoints[waypointIndex+1];
			} else {
				this.gameObject.SetActive(false);
			}
		}
	}
}
