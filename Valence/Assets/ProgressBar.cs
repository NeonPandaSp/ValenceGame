using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {
	public BuildingScript myBuildingScript;

	public float currentTime;
	public float productionCompleteTime;

	public Image powerImg;
	public Image workImg;
	// Use this for initialization
	void Start () {
		myBuildingScript = transform.parent.transform.parent.GetComponent<BuildingScript> ();
		currentTime = 0;
		productionCompleteTime = myBuildingScript.bType.pTime;
	}
	
	// Update is called once per frame
	void Update () {

		if (productionCompleteTime == 0) {
			productionCompleteTime = myBuildingScript.bType.pTime;
		}
		if (myBuildingScript.bType.typeName != "PowerStation") {
			if (myBuildingScript.powered) {
				powerImg.color = new Color (0, 181, 255, 75);
			} else {
				powerImg.color = new Color (255, 0, 0, 75);
			}
		}
		if (myBuildingScript.worked) {
			workImg.color = new Color(0,181,255,75);
		} else {
			workImg.color = new Color(255,0,0,75);
		}

		currentTime = myBuildingScript.resourceProgress;

		float barScale = Remap (currentTime, 0.0f, productionCompleteTime, 0.0f, 1.0f);
        //Debug.Log (currentTime);
        //Debug.Log (barScale);
		//if (myBuildingScript.powered) {
		this.gameObject.transform.localScale = new Vector3( barScale, this.gameObject.transform.localScale.y, this.gameObject.transform.localScale.z);
		//}

		if (barScale >= 1.0f) {
			currentTime = 0;
		}
	}

	public float Remap (float value, float from1, float to1, float from2, float to2) {
		float remapped = (value - from1) / (to1 - from1) * (to2 - from2) + from2;
		return remapped;
	}
}
