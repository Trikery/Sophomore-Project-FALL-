using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LogosSplash : MonoBehaviour {

	public GameObject uvuLogo;
	public GameObject thornLogo;

	int maxTimer = 3;

	IEnumerator Timer (){
		int timer = maxTimer;
		while (timer > 0) {
			timer--;
			yield return new WaitForSeconds (1);
		}
		timer = maxTimer;
		uvuLogo.SetActive (false);
		thornLogo.SetActive (true);
		while (timer > 0) {
			timer--;
			yield return new WaitForSeconds (1);
		}
		timer = maxTimer;
		SceneManager.LoadScene ("TestStage", LoadSceneMode.Single);
	}

	void Start (){
		thornLogo.SetActive (false);
		uvuLogo.SetActive (true);
		StartCoroutine (Timer ());

	}

}
