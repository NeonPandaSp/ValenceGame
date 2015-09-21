using UnityEngine;
using System.Collections;

public class generateBarrels : MonoBehaviour {
	public int numBarrels;
	public int area;
	public GameObject barrels;
	// Use this for initialization
	void Start () {
		for (int i = 1; i <= numBarrels; i++) {
			Instantiate (barrels,new Vector3(Random.Range (-area,area), 0,Random.Range (-area,area)), Quaternion.identity );
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
