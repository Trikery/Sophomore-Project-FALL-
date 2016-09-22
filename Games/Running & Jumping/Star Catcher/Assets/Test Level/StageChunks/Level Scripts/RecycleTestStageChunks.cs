using UnityEngine;
using System.Collections;

public class RecycleTestStageChunks : MonoBehaviour {

	private Vector3 newLocation;

	void OnTriggerEnter()
	{

		newLocation.x = StageRecycleVars.nextSectionPosition;
		transform.position = newLocation;
		StageRecycleVars.nextSectionPosition += StageRecycleVars.distance;

	}
}
