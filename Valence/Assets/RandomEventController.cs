using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RandomEventController : MonoBehaviour {

	public GameController _gameController;
	public AgentSpawner _spawner;

	public GameObject eventPanel;
	public Text eventTitle;
	public Text eventDescription;

	public GameObject resultObject;
	public Text resultText;

	public int eventFrequency;
	public int eventChance;
	public float currentTime;

	public Button confirmButton;
	public Button declineButton;
	public Button dismissButton;

	public int eventId;

	public bool eventActive = false;

	public List<int> eventIdIndex = new List<int>();
	// Use this for initialization
	void Start () {
		currentTime = 0;
		eventPanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if( currentTime > eventFrequency && !eventActive ){
			int randChance = Random.Range (0,100);
			if( randChance > eventChance ){
				eventId = GetEventId();
				InitEvent( eventId );
				eventActive = true;
			}
		}
	}

	void InitEvent(int _eventId ){
		resultObject.SetActive (false);
		eventPanel.SetActive (true);
		dismissButton.gameObject.SetActive (true);
		switch( _eventId ){
		case 1:
			Debug.Log ("Event 001 Called");
			eventTitle.text = "Event: Knocking On The Front Gate";
			eventDescription.text = "Two individuals have arrived at the front gate looking for refuge. Accept them into your settlement and they might become productive members of your community, or they may run off with your resources. Do you let them in?";
			confirmButton.GetComponentInChildren<Text>().text = "Let Them In";
			declineButton.GetComponentInChildren<Text>().text = "Keep The Gate Closed";
			break;
		case 2:
			Debug.Log ("Event 002 Called");
			dismissButton.gameObject.SetActive(false);
			eventTitle.text = "Event: Something's in the water";
			eventDescription.text = "A few settlers haven't been feeling well as of late. People suspect the water supply may be polluted. Will you waste your current water supply to prevent the spread of further illness?";
			confirmButton.GetComponentInChildren<Text>().text = "Waste the Water Supply";
			declineButton.GetComponentInChildren<Text>().text = "Keep the Water";
			break;
		case 3:
			Debug.Log ("Event 002 Called");
			eventTitle.text = "Event: Dark Corners";
			int rand = Random.Range (0,_gameController.population.Count-1);
			eventDescription.text = _gameController.population[rand].GetComponent<AgentLogic_07>().firstLastName + " thinks he found some building resources in a nearby collapsed tunnels. Its a dangerous area, but may result in more scrap. Send a group to invertigate?";
			confirmButton.GetComponentInChildren<Text>().text  = "Send Group";
			declineButton.GetComponentInChildren<Text>().text = "Decline";
			break;
		default:
			Debug.Log ("DefaultEventCalled");
			break;
		}
	}

	void EventResult( int _eventId, bool choice ){

		int rand = Random.Range (0,100);
		resultObject.SetActive(true);

		switch( _eventId ){
			case 1:
				Debug.Log ("Event 001 Results");
				if( choice && _gameController.population.Count >= _gameController.popLimit + 2 ){
					resultText.color = new Color( 1.0f, 1.0f,1.0f );
					resultText.text = "You lack sufficient housing to accomodate new settlers. Build more houses if you want to welcome new members into your community";
				} else if( choice && rand > 50 ){
					resultText.color = new Color( 1.0f, 1.0f, 1.0f);
					resultText.text = "You welcome two new members into your group! They seem nice.";
					_spawner.SpawnAgent();
					_spawner.SpawnAgent();
				} else if( choice && rand <= 50 ){
					resultText.color = new Color( 1, 0.1f, 0.1f );
					resultText.text = "You welcome two new members into your group. In the middle of the night they make off with some of your scrap.";
					if( _gameController.scrap > 50 ){
						_gameController.scrap -= 50;
					} else {
						_gameController.scrap -= _gameController.scrap;
					}
				} else {
					resultText.color = new Color( 1, 0.1f, 0.1f );
					resultText.text = "You keep the front gate shut. Eventually their cries for help fade.";
				}

				break;
			case 2:
				Debug.Log ("Event 002 Called");

				if( choice ){
					_gameController.water = 0;
					resultText.color = new Color( 1, 1, 1 );
					resultText.text = "You dump the water supply. Lets hope that wasn't for nothing.";
				} else if (!choice && rand < 50 ){
					int randAmoutEffected = Random.Range (1,_gameController.population.Count/3);
					for( int i = 1; i <= randAmoutEffected; i++){
						int randIndex = (int) Random.Range(0,_gameController.population.Count-1);
						_gameController.population[randIndex].GetComponent<AgentLogic_07>().health -= 50;
					}
					resultText.color = new Color( 1, 0.1f, 0.1f );
					resultText.text = "Water is a precious resource so you decide to keep it and risk spreading the illness. In the coming days " + randAmoutEffected + " settlers have come down with symptoms of the illness.";
					
				} else if (!choice && rand > 50 ){
					resultText.color = new Color( 1, 1, 1 );
					resultText.text = "Water is a precious resource so you decide to keep it and risk spreading the illness. In the coming days no new cases of the illness emerge";
				}
				break;
			case 3:
				Debug.Log ("Event 3 Called");
				if( choice && rand > 50 ){
					int amount = Random.Range ( 25, 50);
					_gameController.scrap += amount;
					resultText.color = new Color( 1, 1, 1 );
					resultText.text = "You send a group into the tunnel. They find " + amount + " SCRAP!";
				} else if (choice && rand < 50 ){
					int randAmoutEffected = Random.Range (1,4);
					if( _gameController.population.Count < 4 ){
						randAmoutEffected = Random.Range (1,_gameController.population.Count);
					}
					for( int i = 1; i <= randAmoutEffected; i++){
						int randIndex = (int) Random.Range(0,_gameController.population.Count-1);
						_gameController.population[randIndex].GetComponent<AgentLogic_07>().health -= 90;
					}
					resultText.color = new Color( 1, 0.1f, 0.1f );
					if( randAmoutEffected > 1 )
						resultText.text = "You send " + randAmoutEffected + " settlers out into the tunnel. The tunnel proves unstable and they group returns severely injured";
					else
						resultText.text = "You send " + randAmoutEffected + " settler out into the tunnel. The tunnel proves unstable and they return severely injured";
					
				} else if (!choice ){
					resultText.color = new Color( 1, 1, 1 );
					resultText.text = "You opt not to send anyone to retrieve the SCRAP. No amount of SCRAP is worth the risk.";
				}
				break;
			default:
				Debug.Log ("DefaultEventCalled");
				break;
			}
	}

	public int GetEventId(){
		int rand = Random.Range (0, 4);
		if (rand < 1)
			rand = 1;
		else if (rand > 3)
			rand = 3;
		return rand;
	}

	public void Confirm(){
		EventResult (eventId, true);
		eventActive = false;
		eventPanel.SetActive (false);
		currentTime = 0;
	}

	public void Decline(){
		EventResult (eventId, false);
		eventActive = false;
		eventPanel.SetActive (false);
		currentTime = 0;
	}

	public void Dismiss(){
		eventActive = false;
		eventPanel.SetActive (false);
		currentTime = 0;
	}
}
