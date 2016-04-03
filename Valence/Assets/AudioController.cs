using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioController : MonoBehaviour {

	public List<AudioClip> audioClips = new List<AudioClip>();
	public AudioSource targetSource;
	public GameObject audioPrefab;

	public bool fadingOut;
	float volFactor = 1;
	float FADE_HOW_MANY_SECONDS = 1;

	public AudioSource backgroundMusic;
	// Use this for initialization
	void Start () {
		/* EXAMPLE CODE
		playAudioClipOnce (0, Vector3.zero, 500);
		*/
	}
	
	// Update is called once per frame
	void Update () {
		if ( fadingOut && targetSource != null ) {
			Debug.Log ("FADING");
			fadeOut ( targetSource );
		}
	}
	
	void fadeOut(AudioSource clip){

		float clipVolume = clip.volume;
		
		if (clipVolume > 0) {
			clipVolume -= (Time.deltaTime * volFactor / FADE_HOW_MANY_SECONDS);
			
			if (clipVolume <= 0.0f)
				clipVolume = 0.0f;
			
			clip.volume = clipVolume;

		} else {
			clip.Stop ();
			fadingOut = false;
		}
	}

	public void playAudioClipOnce(int audioIndex, Vector3 sndPosition, float maxDist){
		GameObject sndObj = (GameObject) Instantiate (audioPrefab, sndPosition, Quaternion.identity);
		sndObj.transform.SetParent (this.transform);
		sndObj.GetComponent<AudioSource>().clip = audioClips[audioIndex];
		sndObj.GetComponent<AudioSource>().Play ();
		sndObj.GetComponent<AudioSource> ().maxDistance = maxDist;
	}
}
