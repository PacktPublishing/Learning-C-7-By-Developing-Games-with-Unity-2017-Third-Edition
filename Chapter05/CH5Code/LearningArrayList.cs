using UnityEngine;
using System.Collections;

public class LearningArrayList : MonoBehaviour {


	public ArrayList inventory = new ArrayList();


	void Start() {

		inventory.Add(10);
		inventory.Add(20);
		inventory.Add("Adam");
		inventory.Add(GameObject.Find("Player"));


		Debug.Log(inventory[1].GetType());
		Debug.Log(inventory[2].GetType());

	}


}
