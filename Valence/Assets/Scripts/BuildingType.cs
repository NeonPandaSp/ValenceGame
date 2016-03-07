using UnityEngine;
using System.Collections;

[System.Serializable]
public class BuildingType  {

	public string typeName;

	public int cost;

	public float pRate;
	public float pTime;
    public float cRate;
	public int area;

    public int farmerVal, farmVal;

    // Use this for initialization

    void Awake() {
    }

	public BuildingType( string n, int a){
		typeName = n;
		area = a;

        Debug.Log("farmerVal " + farmerVal);

		cost = getBuildingCost ();
		pRate = getProductionRate (area);
		pTime = getProductionTime ();
        cRate = getConsumptionRate(area);
	}
	public int getBuildingCost(){
		if (typeName == "Shelter") {
			return 50;
		} else if (typeName == "Farm") {
			return 25;
		} else if (typeName == "PowerStation") {
			return 25;
		} else if (typeName == "WaterStation") {
			return 25;
		} else {
			Debug.Log ( "Building Cost Error");
			return 0;
		}
	}

	public float getProductionRate(int a){
		if (typeName == "Shelter") {
			return 10.0f;
		} else if (typeName == "Farm") {
            return 1.0f;
        } else if (typeName == "PowerStation") {
            //Each power station should produce 100 power
            return 1.0f;
		} else if (typeName == "WaterStation") {
			return 1.0f;
		} else if (typeName == "TrainingArea")
        {
            return 1.0f;
        }
        else {
			Debug.Log ( "Production Type Error");
			return 0.0f;
		}
	}

    //Currently buildings consume 1 power per tile they consume, 80 tiles = 80 power -Zach
    public float getConsumptionRate(int a) {
		if (typeName == "Shelter") {
			return 0.0f;
		} else if (typeName == "Farm") {
			return 3.0f;
		} else if (typeName == "PowerStation") {
			return 0.0f;
		} else if (typeName == "WaterStation") {
			return 3.0f;
		} else if (typeName == "TrainingArea") {
			return 0.0f;
		}
        else {
            Debug.Log("Consumption Type Error");
            return 0.0f;
        }
    }

    public float getProductionTime(){
		if (typeName == "Shelter") {
			return 0.0f;
		} else if (typeName == "Farm") {
			return 5.0f;
		} else if (typeName == "PowerStation") {
			return 10.0f;
		} else if (typeName == "WaterStation") {
			return 10.0f;
		} else if (typeName == "TrainingArea"){
            return 120.0f;
        }
        else
        {
			Debug.Log ( "Production Type Error");
			return 0.0f;
		}
	}
}
