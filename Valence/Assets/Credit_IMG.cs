using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Credit_IMG : MonoBehaviour {
	public GameObject creditIMG;
	public bool fadeIn, fadeWait, fadeWaitStart, fadeOut;
	public Image myImg;

	public float timerLimit;
	public float currentTime;
	// Use this for initialization
	void Start () {
		fadeIn = true;
		myImg = GetComponent<Image> ();
		myImg.color = new Color (myImg.color.r, myImg.color.g, myImg.color.b, 0.0f);
		int randIndex;

		randIndex = Random.Range (0, transform.parent.GetComponent<SpriteContainer> ().spriteArray.Count - 1);
		myImg.sprite = transform.parent.GetComponent<SpriteContainer> ().spriteArray [randIndex];

		float rand = Random.Range (300, 600);
		GetComponent<RectTransform>().sizeDelta = new Vector2 (rand, rand);
		rand = Random.Range (200, 500);
		float rand2 = (int) Random.Range (-1,2);
		while( rand2 == 0 || rand2 == 2 )
			rand2 = (int) Random.Range (-1,1);
		rand *= rand2;
		rand2 = Random.Range (-100, 100);

		GetComponent<RectTransform> ().localPosition = new Vector2 (rand, rand2);
		rand = Random.Range (-45, 45);
		GetComponent<RectTransform> ().rotation = Quaternion.Euler(0,0, rand);
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		float currentAlpha = 0.0f;
		if (fadeIn) {
			currentAlpha = 0.01f;
			if( myImg.color.a >= 1.0f ){ fadeIn = false; fadeWaitStart = true; }
		} else if(fadeWaitStart){
			currentTime = 0;
			timerLimit = 3;
			fadeWaitStart = false;
			fadeWait = true;
		} else if (fadeWait) {
			currentAlpha = 0.0f;
			if( currentTime > timerLimit ){
				fadeWait = false;
				fadeOut = true;
			}
		} else if (fadeOut) {
			//currentAlpha = -0.01f;
			if( myImg.color.a >= 0.9f ){
				GameObject temp = (GameObject) Instantiate ( creditIMG, Vector3.zero, Quaternion.identity );
				temp.transform.SetParent(this.transform.parent);
				//Destroy (this.gameObject);
				fadeOut = false;
			}
		}

		myImg.color = new Color (myImg.color.r,myImg.color.g,myImg.color.b,myImg.color.a+currentAlpha);
	}
}
