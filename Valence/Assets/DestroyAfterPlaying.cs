using UnityEngine;
using System.Collections;

public class DestroyAfterPlaying : MonoBehaviour {

	public float currentTime;
	public float timeToDestroy;
	bool timeToDestroyIsNotSet = true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (timeToDestroyIsNotSet && GetComponent<AudioSource> ().clip != null) {
			timeToDestroy = GetComponent<AudioSource> ().clip.length;
			timeToDestroyIsNotSet = false;
		} else {
			currentTime += Time.deltaTime;
			if (currentTime > timeToDestroy) {
				Destroy (this.gameObject);
			}
		}
	}
}
