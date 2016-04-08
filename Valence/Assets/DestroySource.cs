using UnityEngine;
using System.Collections;

public class DestroySource : MonoBehaviour {
	public GameObject nextTip;

	public float autoSequence;
	public float currentTime;
	// Use this for initialization
	void Start () {
		autoSequence = 30.0f;
		currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
//		if (currentTime >= autoSequence) {
//			if( nextTip != null )
//				Sequencer(true);
//		}
	}

	public void ObjToDestroy( GameObject myObj ){
		Destroy (myObj);
	}

	public void Sequencer(bool setInActive ){
		if (nextTip != null)
			nextTip.SetActive (true);
		if( setInActive )
			this.gameObject.SetActive (false);
	}
}
