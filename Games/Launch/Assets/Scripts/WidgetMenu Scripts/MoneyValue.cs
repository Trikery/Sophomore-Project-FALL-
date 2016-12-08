using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyValue : MonoBehaviour {

	public Text moneyText;

	private void ReloadMoneyText (){
		string t = "Money: $" + (StaticVariables.totalCoins / 100f);
		moneyText.text = t;
	}


	void Start () {
		UserInputs.MoneyText += ReloadMoneyText;
	}


}
