using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {
	public Vector3 targetPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = targetPosition;
		Vector3 translatedPosition = targetPosition;
		translatedPosition = new Vector3( translatedPosition.x + 0.5f, 1, translatedPosition.z +0.5f );
		transform.position =  Camera.main.WorldToScreenPoint(translatedPosition);
	}
}
