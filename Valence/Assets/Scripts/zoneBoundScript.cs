﻿using UnityEngine;
using System.Collections;

public class zoneBoundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "prop") {
			other.gameObject.GetComponent<PropScript> ().collision = true;
		}
	}
}
