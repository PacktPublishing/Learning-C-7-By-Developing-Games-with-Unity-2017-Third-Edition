using UnityEngine;
using System.Collections;

public class Person {

	public string firstName = "";
	public string lastName = "";
	public Person spouse;


	public Person () {

	}


	public Person (string pFirstName, string pLastName) {
		this.firstName = pFirstName;
		this.lastName = pLastName;
	}






	public bool IsMarriedWith (Person otherPerson) {

		if (spouse != null) {
			//Person object is stored in spouse variable
			if (otherPerson == this.spouse) {
				//otherPerson object is the same as stored spouse
				return true;
			}
			else {
				//not married
				return false;
			}
		}
		else {
			//spouse variable is not assigned so this
			//Person is not married at all
			return false;
		}
	}

}










