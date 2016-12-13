using UnityEngine;
using System.Collections;

public class Penny : Coin {					//Inheritance #3

	protected override int getValue(){		//Polymorphism #3
		return 1;
		
	}
}
