using UnityEngine;
using System.Collections;
using System;

public class StageRecycler : MonoBehaviour 
{

	public static Action<StageRecycler> RecycleAction;
	public bool canBeRecycled = false;
	public Transform chunk;

	void Start ()
	{
		chunk = this.GetComponent<Transform>();
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