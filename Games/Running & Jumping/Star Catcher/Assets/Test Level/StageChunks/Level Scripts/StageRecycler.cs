using UnityEngine;
using System.Collections;
using System;

public class StageRecycler : MonoBehaviour 
{

	public static Action<StageRecycler> RecycleAction;
	public bool canBeRecycled = false;
	public Transform cube;   

	void Start ()
	{
		cube = this.GetComponent<Transform> ();
		if (RecycleAction != null && canBeRecycled)
		{
			RecycleAction(this);
		}
	}

	void OnTriggerEnter ()
	{
		canBeRecycled = true;
		Start ();
	}
}