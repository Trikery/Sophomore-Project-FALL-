using UnityEngine;
using System.Collections;

public class EnemyAmbushFlash : MonoBehaviour
{
	public GameObject flashCanvas;
	public Animator animWolf;
	public Animator animMask;
	public Animator animBG;

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
		animMask.Play ("TextMaskAnimation");
		animBG.Play ("AmbushBGFlashIn");
		StartCoroutine (TimerOne ());
		animWolf.Play ("WolfFlashAnimation");
	}
}
