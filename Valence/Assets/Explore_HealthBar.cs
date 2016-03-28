using UnityEngine;
using System.Collections;

public class Explore_HealthBar : MonoBehaviour {
	public Unit myUnit;

	public float myMax;

	public float currentValue;
	public float currentTime;

	public float lastHealth;
	public float preDamageHealth;

	public bool shakeMe;
	public float shakeSpeed;
	public float timeSinceShakeStart;
	public float shakeLength = 2.0f;
	public Vector3 resetPosition;

	public bool customUnit;
	// Use this for initialization
	void Start () {
		if (!customUnit) {
			myUnit = transform.parent.transform.parent.GetComponent<Unit> ();
		}

		myMax = myUnit.health;

		currentTime = 0;
		currentValue = Remap (myMax, 0.0f, myMax, 0.0f, 1.0f);
		lastHealth = Remap (myMax, 0.0f, myMax, 0.0f, 1.0f);
		preDamageHealth = Remap (myMax, 0.0f, myMax, 0.0f, 1.0f);;
	}
	
	// Update is called once per frame
	void Update () {

		currentTime += Time.deltaTime;

		float currentHealth;

		currentHealth = myUnit.health;

		currentHealth = Remap (currentHealth, 0.0f, myMax, 0.0f, 1.0f);

		if (shakeMe && !customUnit) {
			transform.parent.transform.position = resetPosition;
			transform.parent.transform.position += Random.insideUnitSphere * ( shakeSpeed / 5 );
			timeSinceShakeStart += Time.deltaTime;
			if( timeSinceShakeStart > shakeLength ){
				shakeMe = false;
				transform.parent.transform.position = resetPosition;
			}
		}

		if( currentHealth != lastHealth ){
			preDamageHealth = lastHealth;
			currentTime = 0;
			shakeParent(currentHealth);
		}

		lastHealth = currentHealth;

		if (currentHealth < currentValue) {
			currentValue = easeInOutQuad (currentTime, preDamageHealth, currentHealth - preDamageHealth, 2.0f);
			if (currentValue - currentHealth < 0.01f)
				currentValue = currentHealth;
		} else if (currentHealth > currentValue) {
			currentValue = currentHealth;
		}


		this.gameObject.transform.localScale = new Vector3( currentValue, this.gameObject.transform.localScale.y, this.gameObject.transform.localScale.z);
	}

	public float Remap (float value, float from1, float to1, float from2, float to2) {
		float remapped = (value - from1) / (to1 - from1) * (to2 - from2) + from2;
		return remapped;
	}


	float easeInOutQuad( float time, float start, float change, float duration ){
		time /= duration / 2;
		if (time < 1)
			return change / 2 * time * time + start;
		time--;
		return -change / 2 * (time * (time - 2) - 1) + start;
	}

	void shakeParent(float newHealth){
		shakeMe = true;
		shakeSpeed = preDamageHealth - newHealth;
		timeSinceShakeStart = 0;
		resetPosition = transform.parent.position;
	}
}
