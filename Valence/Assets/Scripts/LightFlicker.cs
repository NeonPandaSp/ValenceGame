using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {

    float minFlickerSpeed = 0.1f;
    float maxFlickerSpeed = 60.0f;

    // Use this for initialization
    void Update () {
        StartCoroutine(FlickerLight());
	}
 
    IEnumerator FlickerLight(){

        GetComponent<Light>().enabled = true;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        GetComponent<Light>().enabled = false;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
    }
}
