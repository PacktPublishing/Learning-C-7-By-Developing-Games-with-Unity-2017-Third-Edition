using System.Collections;
using UnityEngine;

public class returnTotal : MonoBehaviour {


	public int number1 = 2;
	public int number2 = 3;
	public int number3 = 6;
	public int number4 = 8;



	void Start () {

		int sumResult = AddTwoNumbers (number1, number2);
		int sumAnotherResult = AddTwoNumbers (number3, number4);

		DisplayResult (sumResult);
		DisplayResult (sumAnotherResult);
	}




	int AddTwoNumbers (int firstNumber, int secondNumber) {

		int result = firstNumber + secondNumber;
		return result;
	}


	void DisplayResult (int total) {

		Debug.Log("The grand total is : " + total);
	}
}








