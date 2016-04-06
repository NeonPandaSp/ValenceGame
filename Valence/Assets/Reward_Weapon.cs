using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Reward_Weapon : MonoBehaviour {
	public Text weaponName;
	public Text weaponType;
	public Image weaponImg;
	public Text dmgMod;
	public Text accMod;
	public Text rngMod;

	public Sprite hSprite, sSprite, rSprite;

	public void Start(){
		if( weaponType.text == "[Handgun]" ){
			weaponImg.sprite = hSprite;
		} else if ( weaponType.text == "[Shotgun]" ){
			weaponImg.sprite = sSprite;
		} else {
			weaponImg.sprite = rSprite;
		}
	}
}
