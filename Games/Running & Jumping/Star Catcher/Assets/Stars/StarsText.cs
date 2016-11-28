using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarsText : MonoBehaviour {

	Text starText;

	void Start () {
		starText = GetComponent<Text> ();
	}
	

	void Update () {
		starText.text = "STARS: " + StaticPointSystem.starCount;
	}
}
