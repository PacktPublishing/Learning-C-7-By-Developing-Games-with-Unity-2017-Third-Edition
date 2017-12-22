using UnityEngine;
using System.Collections;

public class LearningReusableMethods : MonoBehaviour {


	public int number1 = 2;
	public int number2 = 3;
	public int number3 = 7;



	void Start () {
	
		AddAndPrintTwoNumbers(number1, number2);
		AddAndPrintTwoNumbers(number1, number3);
		AddAndPrintTwoNumbers(number2, number3);
	
	}



	void AddAndPrintTwoNumbers(int firstNumber, int secondNumber) {

		int result = firstNumber + secondNumber;
		Debug.Log(result);

	}







}
