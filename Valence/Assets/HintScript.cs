using UnityEngine;
using System.Collections;

public class HintScript : MonoBehaviour {
	public float currentTime;
	public float timeToDelete = 24;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (currentTime > timeToDelete) {
			this.gameObject.SetActive (false);
		} else {
			currentTime += Time.deltaTime;
		}
	}
}
