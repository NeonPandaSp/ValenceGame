using UnityEngine;
using System.Collections;

public class hoverComponent : MonoBehaviour {
	public GameObject myTooltip;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseEnter() {
		Debug.Log ("Enter");
		myTooltip.gameObject.SetActive (true);
	}
	void OnMouseOver() {
		Debug.Log ("OVER");
	}
	void OnMouseExit() {
		Debug.Log ("Exit");
		myTooltip.gameObject.SetActive (false);
	}
}
