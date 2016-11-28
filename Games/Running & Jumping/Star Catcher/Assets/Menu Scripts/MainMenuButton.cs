using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour {
	
	public void ReturnToMenu (){
		StageRecycleVars.nextSectionPosition = 14;
		StageRecycleVars.distance = 14;
		StaticPointSystem.starCount = 0;
		StaticPointSystem.timer = 90;
		SceneManager.LoadScene ("TestStage", LoadSceneMode.Single);
	}

	void Start () {
		
	}
}
