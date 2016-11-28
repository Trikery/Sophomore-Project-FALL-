using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DistanceCounter : MonoBehaviour {

	public static float distance;

	Text distanceText;
	public GameObject character;
	// Use this for initialization
	void Start () {
		distanceText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		distance = (character.transform.position.x + 30);
		distanceText.text = "DISTANCE: " + distance.ToString("F0") ;

	}
}
