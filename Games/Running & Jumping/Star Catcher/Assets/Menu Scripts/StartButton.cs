using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartButton : MonoBehaviour {

	public MainMenu main;
	public Vector3 texObj;
	public Image button;
	public Text title;
	public Image screen;



	IEnumerator FadeButton (){
		float fadeTime = 2;
		button.GetComponent<Image> ().CrossFadeAlpha (0f, fadeTime, false);
		title.GetComponent<Text> ().CrossFadeAlpha (0f, fadeTime, false);
		screen.GetComponent<Image> ().CrossFadeColor (Color.black, fadeTime, false, false);
		while (fadeTime > 0) {
			yield return new WaitForSeconds (1);
			fadeTime--;
		}
		AcivateGamePlay ();
	}

	public void AcivateGamePlay (){
		main.character.SetActive (true);
		main.cameraMovement.enabled = true;
		main.widgets.SetActive (true);
		main.starSpawners.SetActive (true);
		GameStates.currentGameState = GameStates.States.Playing;
		main.gameObject.SetActive (false);
	}
	void Start (){		//set the level inactive so that the entities don't kill the player prematurely
		}

		public void StartThisGame (){  //button activates the gameplay
			StartCoroutine(FadeButton());
		}
}