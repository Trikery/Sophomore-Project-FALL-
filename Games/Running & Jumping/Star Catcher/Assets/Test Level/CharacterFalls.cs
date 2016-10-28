using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharacterFalls : MonoBehaviour {

	public GameObject character;

	void OnTriggerEnter (){  //when the player enters the death area, the scene will reset
		StageRecycleVars.nextSectionPosition = 14;
		StageRecycleVars.distance = 14;
		SceneManager.LoadScene ("TestStage", LoadSceneMode.Single);;
	}  //MonoDevelop says this is obsolete.  I guess that means there is a better way to do it now.  But right now I donw't care
}
