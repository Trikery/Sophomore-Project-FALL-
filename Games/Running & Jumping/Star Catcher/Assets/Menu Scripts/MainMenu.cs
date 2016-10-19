using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

	//public Image menuImage;
	public GameObject character;
	public MoveCamera camera;

	int fadeCount = 3;  //I hope to add a function that will make the game fade from black and then have the button appear based on this number
	public GameObject playButton;

	IEnumerator StartUpMenu (){  //makes the game wait 1 second before making the play button appear
		while (fadeCount > 0) {
			yield return new WaitForSeconds (1);
			fadeCount--;
		}

		GameStates.currentGameState = GameStates.States.MenuScreen;
		playButton.SetActive (true);

	}
	void Start (){
		//menuImage.GetComponent<Image> ().CrossFadeColor (Color.black, fadeCount, false, false);   //hoped to use this to make a fade in but all I can make is a... Fadeout?
		playButton.SetActive (false);
		character.SetActive (false);
		camera.enabled = false;

		StartCoroutine (StartUpMenu ());
	}
}
