using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class LearningLists : MonoBehaviour {

	
	public List<string> familyMembers = new List<string>();


	void Start() {

		familyMembers.Add("Greg");
		familyMembers.Add("Kate");
		familyMembers.Add("Adam");
		familyMembers.Add("Mia");


		string thirdFamilyMember = familyMembers[2];
		Debug.Log(thirdFamilyMember);

	}

}


