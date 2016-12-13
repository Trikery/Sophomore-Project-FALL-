using UnityEngine;
using System.Collections;

public class EmptyPill : PowerUp {						//Use of Inheritance #4

	protected override void PowerEffect (){				//Use of Polymorphism #4
		print ("The Power Up Had No Effect...");
	}

}
