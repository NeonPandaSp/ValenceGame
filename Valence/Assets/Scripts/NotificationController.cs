using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class NotificationController : MonoBehaviour {
	public Image tempPanel;

	public List<Image> notifications = new List<Image>();
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateNewNotification(string newNotification){
		Debug.Log (this.transform.position.x);

		Image newPanel = Instantiate(tempPanel, new Vector2(this.transform.position.x - Screen.width - 430, this.transform.position.y + 100 ), Quaternion.Euler(Vector3.zero)) as Image;
		//            button.transform.SetParent(GameObject.Find("Canvas").transform, false);
		newPanel.transform.SetParent(this.transform, false);
		newPanel.GetComponentInChildren<Text> ().text = newNotification;
		
		notifications.Add (newPanel);
		for (int i = 0; i <= notifications.Count-1; i++) {
			if (i > 3) {
				Image temp = notifications [i];
				notifications.Remove (notifications [i]);
				Destroy ( temp.gameObject );
			} else {
				notifications [i].gameObject.transform.position = new Vector2 (notifications [i].transform.position.x, this.transform.position.y + (100 * ( (notifications.Count-1) - i )) + 100 ); 
			}
		}
	}
}
