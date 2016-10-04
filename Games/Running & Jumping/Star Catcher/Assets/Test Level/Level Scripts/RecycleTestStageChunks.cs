using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class RecycleTestStageChunks : MonoBehaviour {

	private Vector3 newLocation;
	public List<StageRecycler> recyclableList;

	private int i = 0;

	void Start () 
	{
		recyclableList = new List<StageRecycler> ();
		StageRecycler.RecycleAction += RecycleActionHandler;
	}

	private void RecycleActionHandler (StageRecycler _r)
	{
		recyclableList.Add (_r);
	}

	void OnTriggerEnter(Collider other)
	{
		i = UnityEngine.Random.Range(0, recyclableList.Count - 1);
		newLocation.x = StageRecycleVars.nextSectionPosition;
		recyclableList[i].chunk.position = newLocation;
		StageRecycleVars.nextSectionPosition += StageRecycleVars.distance;
		if (recyclableList.Count > 0)
			recyclableList.RemoveAt(i);
	}
}
