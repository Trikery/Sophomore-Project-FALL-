using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class RecycleLevels : MonoBehaviour {

	private Vector3 newLocation;
	public List<Recycler> recyclableList;
	private int i = 0;

	void Start () 
	{
		recyclableList = new List<Recycler> ();
		Recycler.RecycleAction += RecycleActionHandler;
	}

	private void RecycleActionHandler (Recycler _r)
	{
		recyclableList.Add (_r);
	}

	void OnTriggerEnter(Collider other)
	{
		newLocation.x = StaticVars.nextSectionPosition;
		recyclableList[i].cube.position = newLocation;  //transform.position = newLocation;
		StaticVars.nextSectionPosition += StaticVars.distance;
		if (i < recyclableList.Count -1)
			i++;
	}
}
