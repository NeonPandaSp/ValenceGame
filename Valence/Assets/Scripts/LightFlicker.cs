using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {

    float minFlickerSpeed = 0.1f;
    float maxFlickerSpeed = 0.5f;

    // Use this for initialization
    void Start () {
        StartCoroutine(FlickerLight());
	}
 
    IEnumerator FlickerLight(){

        GetComponent<Light>().enabled = true;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed+1.0f, maxFlickerSpeed+1.0f));
        
		GetComponent<Light>().enabled = false;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));

		StartCoroutine(FlickerLight());
    }
}
