using UnityEngine;
using System.Collections;

public class SunRise : MonoBehaviour {

	public CharacterFalls restart;
	public float scrollSpeed;
	Vector3 tempVector;
	public SpriteRenderer sky;
	public SpriteRenderer vignette;

	public float t = 1f;

	IEnumerator DayTimer (){
		while (StaticPointSystem.gameTimer > 0) {
			StaticPointSystem.gameTimer--;
			yield return new WaitForSeconds (1);
		}
	}

	void Start (){
		StartCoroutine (DayTimer ());
	}

	void Update(){
		
		if (StaticPointSystem.gameTimer >= 10) {
			tempVector.y = scrollSpeed * Time.deltaTime;
			transform.Translate (tempVector);
		} else if (StaticPointSystem.gameTimer > 0) { 
			sky.color = new Color (1f, 1f, 1f, t);
			vignette.color = new Color (1f, 1f, 1f, t);
			t -= 0.004f;
		} else {  
			restart.RestartScreen ();
		}
	}
}
