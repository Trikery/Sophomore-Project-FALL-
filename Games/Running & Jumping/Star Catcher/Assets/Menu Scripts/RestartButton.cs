using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {

	public StartButton Restart;

	public void RestartThisGame (){
		StageRecycleVars.nextSectionPosition = 14;
		StageRecycleVars.distance = 14;
		StaticPointSystem.starCount = 0;
		StaticPointSystem.timer = 20;
		StaticPointSystem.canRestartGame = true;
		SceneManager.LoadScene ("TestStage", LoadSceneMode.Single);
		print ("restartingStage");
	}
}
