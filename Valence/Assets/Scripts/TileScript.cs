using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {

	public GameObject childObject;
	public bool childActive = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
		/**
		if (GetComponent<BoxCollider> ().Raycast (ray, out hitInfo, Mathf.Infinity )) {

		}**/
	}

	void OnMouseDown(){

	}

	public void setChildActive(bool set){
		if ( !set ) {
			childObject.SetActive (false);
			childActive = false;
		} else if( set ) {
			childObject.SetActive (true);
			childActive = true;
		}
	}
}
