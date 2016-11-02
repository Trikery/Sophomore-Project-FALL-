using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

	Text scoreText;
	float scoreTotal;
	public float extraZeros = 100;
	public float starMultiplyer = 100;
	public float distanceMultiplyer = 1;


	void Start () {
		scoreText = GetComponent<Text> ();
	}
	void Update () {
		scoreTotal = ((StaticPointSystem.starCount * starMultiplyer) + (DistanceCounter.distance));
		scoreText.text = "" + scoreTotal.ToString("F0");
	}
}
