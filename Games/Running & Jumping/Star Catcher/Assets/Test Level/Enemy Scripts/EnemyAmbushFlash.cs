using UnityEngine;
using System.Collections;

public class EnemyAmbushFlash : MonoBehaviour
{
	public GameObject flashCanvas;

	public int maxframecount = 30;


	public void StartFlash()
	{
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
