using UnityEngine;
using System.Collections;

public class Nickle : Coin {				//Inheritance #2

	protected override int getValue (){		//Polymorphism #2
		return 5;
	}
}
