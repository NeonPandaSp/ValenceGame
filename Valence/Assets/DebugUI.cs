using UnityEngine;
using System.Collections;

public class DebugUI : MonoBehaviour {
	public GameController _gameController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SpawnAgent(){
		_gameController.myAgentSpawner.SpawnAgent ();
	}

	public void ForceEvent(){
		_gameController.randomEventController.currentTime = 99999;
	}

	public void MoreScrap(){
		_gameController.scrap += 100;
	}

	public void AllTheScrap(){
		_gameController.scrap += 999;
	}

	public void MorePower(){
		_gameController.power += 999;
	}

	public void MoreFood(){
		_gameController.food += 999;
	}

	public void MoreWater(){
		_gameController.water += 999;
	}
}
