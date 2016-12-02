using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

	//public Image menuImage;
	public GameObject character;
	public MoveCamera cameraMovement;
	public GameObject widgets;
	public GameObject gameOver;
	public GameObject starSpawners;
	public GameObject countDown;
	public CharacterMovement controls;
	public SunRise skyTimer;

	public GameObject playButton;
	public GameObject quitButton;

	public StartButton startButton;

	void Start (){

		//menuImage.GetComponent<Image> ().CrossFadeColor (Color.black, fadeCount, false, false);   //hoped to use this to make a fade in but all I can make is a... Fadeout?
		starSpawners.SetActive (false);
		character.SetActive (false);
		cameraMovement.enabled = false;
		widgets.SetActive (false);
		gameOver.SetActive (false);
		countDown.SetActive (false);
		controls.enabled = false;
		skyTimer.enabled = false;

		if (StaticPointSystem.canRestartGame) {
			startButton.ActivateCount ();
			StaticPointSystem.canRestartGame = false;
		}

	}
}
