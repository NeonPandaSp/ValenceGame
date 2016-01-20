using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScaleAndFadeText : MonoBehaviour {
	public Text myText;
	public float scaleFactor;
	public float period;
	public float xOffset;
	int myTextSize;
	float timeSinceWake;
	float alphaValue;
	// Use this for initialization
	void Start () {
		timeSinceWake = 0;
		myTextSize = myText.fontSize;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timeSinceWake += Time.deltaTime;
		myText.fontSize = (int) ( (myTextSize*scaleFactor) * Mathf.Sin ((1) * timeSinceWake + xOffset) );
		alphaValue = ( 1 * ( Mathf.Sin (0.6f*timeSinceWake + 1.6f) ));
		myText.color = new Color (myText.color.r, myText.color.g, myText.color.b, alphaValue );
		if (alphaValue <= 0)
			Destroy (this.gameObject);
	}
}
