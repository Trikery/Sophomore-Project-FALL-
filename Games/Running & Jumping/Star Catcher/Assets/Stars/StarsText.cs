using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarsText : MonoBehaviour {

	public Text starText;

	void Start () {
		starText = GetComponent<Text> ();
	}
	

	void Update () {
		starText.text = "Stars: " + StaticPointSystem.starCount;
	}
}
