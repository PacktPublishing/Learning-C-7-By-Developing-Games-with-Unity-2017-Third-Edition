using UnityEngine;
using System.Collections;

public class LearningReusableMethodsWithReturn : MonoBehaviour {


	public int number1 = 2;
	public int number2 = 3;



	void Start () {

		int sumResult = AddTwoNumbers(number1, number2); 

		DisplayResult(sumResult);
		
	}
	
	
	
	int AddTwoNumbers (int firstNumber, int secondNumber) {
		
		int result = firstNumber + secondNumber;
		return result;
		
	}


	void DisplayResult (int total) {

		Debug.Log("The grand total is: " + total);

	}

}




