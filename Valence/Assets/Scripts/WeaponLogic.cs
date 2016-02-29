using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponLogic : MonoBehaviour {

    public List<ParticleSystem> particles;

    //This is a debug bool to manually trigger the weapon fire flash
    public bool trigger;

	// Use this for initialization
	void Start () {
        particles = new List<ParticleSystem>(GetComponentsInChildren<ParticleSystem>());

        trigger = false;
        
	}

    void Update() {
        if (trigger) {
            FireWeapon();
        }
    }

	// When Called weapon plays a muzzle flash
	public void FireWeapon () {
        foreach (ParticleSystem MuzzleFlash in particles) {
            MuzzleFlash.Play();
        }

        trigger = false;
    }
}
