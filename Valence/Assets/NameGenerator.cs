using UnityEngine;
using System.Collections;

public class NameGenerator : MonoBehaviour {
	public TextAsset verbText;
	public TextAsset adjectiveText;

	public string[] verbs;
	public string[] adjectives;

	void Start() {
		verbs = verbText.text.Split('\n');
		adjectives = adjectiveText.text.Split ('\n');
//
//		for (int i = 0; i < 100; i++) {
//			string newString = GetAdjective() + " " + GetVerbs ();
//			newString = newString.ToUpper();
//			Debug.Log ( newString );
//		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string GetAdjective(){
		int rand = (int) Random.Range (0, adjectives.Length-1);

		return adjectives [rand];
	}

	public string GetVerbs(){
		int rand = (int) Random.Range (0, verbs.Length-1);

		return verbs [rand];
	}
}
