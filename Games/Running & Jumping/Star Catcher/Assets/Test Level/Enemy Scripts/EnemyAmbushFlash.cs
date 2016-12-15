using UnityEngine;
using System.Collections;

public class EnemyAmbushFlash : MonoBehaviour
{
	public GameObject flashCanvas;
	public AudioSource source;

	public int maxframecount = 30;

	void Start(){
		source = GetComponent<AudioSource> ();
	}

	public void StartFlash()
	{
		source.Play();
		flashCanvas.SetActive (true);
	}

	public void EndFlash()
	{
		flashCanvas.SetActive (false);	
	}

	IEnumerator TimerOne()
	{
		int framecount = maxframecount;

		while (framecount > 0)
		{
			framecount--;
			yield return new WaitForEndOfFrame ();
		}
		framecount = maxframecount;
	}

	public void FlashAnimation()
	{
		StartCoroutine (TimerOne ());
	}
}
