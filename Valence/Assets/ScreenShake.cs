using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {
	public GameObject[] players;
	
	Vector3 centerPos = new Vector3(0,0,0);
	Vector3 cameraPos = new Vector3(0,0,0);
	
	public float shake;
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;
	// Use this for initialization
	void Start () {
		centerPos = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		cameraPos = centerPos;
		if (shake > 0) {
			cameraPos += Random.insideUnitSphere * shakeAmount;
			shake -= Time.deltaTime * decreaseFactor;
			
		} else {
			shake = 0.0f;
		}
		
		transform.position = cameraPos;
	}
}

