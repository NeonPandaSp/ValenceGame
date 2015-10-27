using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {

	public GameController _myGameController;

	public BuildingType bType;
	public string myType; 
	public int myArea; 

	// Use this for initialization
	void Start () {

		bType = new BuildingType (myType, myArea);
		beginProduction ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void beginProduction(){
		InvokeRepeating("GenerateResource", bType.pTime, bType.pTime);
	}

	void GenerateResource(){
		if (bType.typeName == "shelter") {
			// nada 
		} else if (bType.typeName == "farm") {
			_myGameController.food += bType.pRate;
		} else if (bType.typeName == "power") {
			_myGameController.power += bType.pRate;
		} else if (bType.typeName == "water") {
			_myGameController.water += bType.pRate;
		} else {
			Debug.Log ( "Production Type Error @ Resource Generation");
		}
	}
}
