using UnityEngine;
using System.Collections;

public interface IMovement {

	void Start ();
	void Move (float _moveInX);
	void Unsubscribe();
}
