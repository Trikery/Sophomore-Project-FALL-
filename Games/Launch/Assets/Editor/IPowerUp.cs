using UnityEngine;
using System.Collections;

public interface IPowerUp {

	int power { get; }  //also set;

	void Start ();

	void OnTriggerEnter ();

}
