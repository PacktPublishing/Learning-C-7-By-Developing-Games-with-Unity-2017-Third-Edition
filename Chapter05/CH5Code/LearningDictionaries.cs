using UnityEngine;
using System.Collections;

public class LearningDictionaries : MonoBehaviour {

	public Hashtable personalDetails = new Hashtable();


	void Start() {

		personalDetails.Add("firstName", "Greg");
		personalDetails.Add("lastName", "Lukosek");
		personalDetails.Add("gender", "male");
		personalDetails.Add("isMarried", true);
		personalDetails.Add("age", 29);



		if (personalDetails.Contains("firstName")) {
			Debug.Log((string)personalDetails["firstName"]);
		}
		else {
			Debug.Log("First name isnt stored in the hashtable");
		}




	}

}




