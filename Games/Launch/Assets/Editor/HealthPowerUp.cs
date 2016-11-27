using UnityEngine;
using System.Collections;
using System;

public class HealthPowerUp : MonoBehaviour, IPowerUp { // ,IPowerUp indicates the addition of the interface

	public int power 
	{ 
		get
		{
			throw new NotImplementedException ();
		} 
	} 
	//what kind of variable is this?  what is it going to do?

	public void Start ()
	{
		print ("start");
	}

	public void OnTriggerEnter()
	{
		print ("enter");
	}

}