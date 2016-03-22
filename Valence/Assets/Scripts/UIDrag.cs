using UnityEngine;
using System.Collections;

public class UIDrag : MonoBehaviour {

    float OffsetX;
    float OffsetY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BeginDrag() {
        OffsetX = transform.position.x - Input.mousePosition.x;
        OffsetY = transform.position.y - Input.mousePosition.y;
    }

    public void Drag() {
        transform.position = new Vector3(OffsetX + Input.mousePosition.x, OffsetY + Input.mousePosition.y);
    }
}
