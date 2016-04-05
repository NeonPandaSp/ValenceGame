using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnHoverLessOpaque : MonoBehaviour {
	bool opaque = false;
	public Text myText;
	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (opaque) {
			myText.color = new Color (myText.color.r, myText.color.g, myText.color.b, 1.0f);
		} else {
			myText.color = new Color (myText.color.r, myText.color.g, myText.color.b, 1.0f);
		}
	}

	public void opacityChange(){
		opaque = !opaque;
	}
}
