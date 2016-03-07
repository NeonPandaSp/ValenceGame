using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class PlayIntroMovie : MonoBehaviour {

    public MovieTexture movie;

	// Use this for initialization
	void Start () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        movie.Play();
        movie.loop = true;
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
