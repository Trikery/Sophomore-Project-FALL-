using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartButton : MonoBehaviour {

	public MainMenu main;
	public Vector3 texObj;
	public Image button;
	public Image quitButton;
	public Text title;
	public Image screen;
	public Text button1;
	public Text button2;
	public GameObject count;

	IEnumerator FadeButton ()
	{
		float fadeTime = 2;
		button.GetComponent<Image> ().CrossFadeAlpha (0f, fadeTime, false);
		quitButton.GetComponent<Image> ().CrossFadeAlpha (0f, fadeTime, false);
		title.GetComponent<Text> ().CrossFadeAlpha (0f, fadeTime, false);
		button1.GetComponent<Text> ().CrossFadeAlpha (0f, fadeTime, false);
		button2.GetComponent<Text> ().CrossFadeAlpha (0f, fadeTime, false);
		screen.GetComponent<Image> ().CrossFadeColor (Color.black, fadeTime, false, false);
		while (fadeTime > 0) {
			yield return new WaitForSeconds (1);
			fadeTime--;
		}
		ActivateCount ();
	}

	public void ActivateCount (){
		main.character.SetActive (true);
		GameStates.currentGameState = GameStates.States.Playing;
		main.gameObject.SetActive (false);
		count.SetActive (true);
	}

		public void StartThisGame (){  //button activates the gameplay
			StartCoroutine(FadeButton());
		}
}