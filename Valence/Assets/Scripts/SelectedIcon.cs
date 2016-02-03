using UnityEngine;
using System.Collections;

public class SelectedIcon : MonoBehaviour {
	public Unit selectUnit;

	public Vector3 rV = new Vector3(0,1,0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (selectUnit != null) {
			transform.position = new Vector3 (selectUnit.transform.position.x + 0.5f, 0, selectUnit.transform.position.z + 0.5f);
		}
		transform.Rotate ((50 * Time.deltaTime)*rV.x, (50 * Time.deltaTime)*rV.y,(50 * Time.deltaTime)*rV.z);
	}
}
