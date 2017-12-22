using UnityEngine;
using System.Collections;

public class LearningScript : MonoBehaviour {

	public int number1 = 2;
	public int number2 = 9;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Return)) AddTwoNumbers();
	}


	void AddTwoNumbers() {
		Debug.Log( number1 + number2);
	}

}
