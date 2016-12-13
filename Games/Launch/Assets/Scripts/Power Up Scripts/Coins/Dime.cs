using UnityEngine;
using System.Collections;

public class Dime : Coin {						//Inheritance #1

	protected override int getValue (){			//Polymorphism #1
		return 10;
	}
}
