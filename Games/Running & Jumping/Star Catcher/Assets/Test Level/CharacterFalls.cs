﻿using UnityEngine;
using System.Collections;

public class CharacterFalls : MonoBehaviour {

	public GameObject character;

	void OnTriggerEnter (){  //when the player enters the death area, the scene will reset
		Application.LoadLevel ("TestStage");	}  //MonoDevelop says this is obsolete.  I guess that means there is a better way to do it now.  But right now I donw't care
}