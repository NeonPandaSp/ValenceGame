﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreditsRoll : MonoBehaviour {
	public float speed;
	public TextAsset creditsText;
	// Use this for initialization
	void Start () {
		this.transform.position = new Vector3 (this.transform.position.x, -Screen.height/8, this.transform.position.z);
		GetComponent<Text> ().text += creditsText;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate( new Vector3( 0, Time.deltaTime*speed, 0) );
	}
}
