using UnityEngine;
using System.Collections;

public class SelectAttackTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		this.transform.parent.gameObject.SetActive (false);
	}
}
