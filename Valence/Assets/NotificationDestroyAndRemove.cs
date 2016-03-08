using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NotificationDestroyAndRemove : MonoBehaviour {
	public int timeToDestroy;
	float currentTime;
	public NotificationController notificationController;
	// Use this for initialization
	void Start () {
		notificationController = GameObject.Find("NotificationController").GetComponent<NotificationController>();
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (currentTime > timeToDestroy) {
			notificationController.notifications.Remove (this.gameObject.GetComponent<Image>());
			Destroy ( this.gameObject.GetComponent<FadeIn>() );
			GetComponent<FadeOut>().begin = true;
			GetComponent<FadeOut>().andDestroy = true;
			//Destroy ( this.gameObject );
		}
	}

	public void DestroyNow(){
		notificationController.notifications.Remove (this.gameObject.GetComponent<Image>());
		Destroy ( this.gameObject.GetComponent<FadeIn>() );
		GetComponent<FadeOut>().begin = true;
		GetComponent<FadeOut>().andDestroy = true;
		//Destroy ( this.gameObject );
	}
}
