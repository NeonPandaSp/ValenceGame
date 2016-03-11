using UnityEngine;
using System.Collections;

public class pulse : MonoBehaviour {
	SpriteRenderer myRenderer;

	int increment;
	// Use this for initialization
	void Start () {
		myRenderer = this.gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (myRenderer.color.a <= 0.6)
			increment = 1;
		else if (myRenderer.color.a >= 0.95)
			increment = -1;

		myRenderer.color = new Color ( myRenderer.color.r, myRenderer.color.g, myRenderer.color.b, myRenderer.color.a + ((Time.deltaTime/2)*increment) );
	}
}
