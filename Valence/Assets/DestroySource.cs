using UnityEngine;
using System.Collections;

public class DestroySource : MonoBehaviour {
	public GameObject nextTip;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ObjToDestroy( GameObject myObj ){
		Destroy (myObj);
	}

	public void Sequencer(){
		nextTip.SetActive (true);
		this.gameObject.SetActive (false);
	}
}
