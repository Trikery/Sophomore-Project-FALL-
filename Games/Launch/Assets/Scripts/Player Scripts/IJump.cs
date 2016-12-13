using UnityEngine;
using System.Collections;

public interface IJump {

	void Start ();
	void Jump (KeyCode _keycode);
	void Charge(KeyCode _keycode);
}
