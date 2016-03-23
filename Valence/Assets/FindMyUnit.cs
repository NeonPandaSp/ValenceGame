using UnityEngine;
using System.Collections;

public class FindMyUnit : MonoBehaviour {
	public string varToBetSet;
	// Use this for initialization
	void Awake () {

		if (varToBetSet == "AlertObj") {
			transform.parent.transform.parent.GetComponent<Unit>().AlertObject = this.gameObject;
		}
		if (varToBetSet == "CautionObj") {
			transform.parent.transform.parent.GetComponent<Unit>().CautionObject = this.gameObject;
		}
		this.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
