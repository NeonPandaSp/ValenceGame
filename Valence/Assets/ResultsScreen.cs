using UnityEngine;
using System.Collections;

public class ResultsScreen : MonoBehaviour {
	public RandomEventController eventController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Dismiss(){
		eventController.eventActive = false;
		this.gameObject.SetActive (false);

	}
}
