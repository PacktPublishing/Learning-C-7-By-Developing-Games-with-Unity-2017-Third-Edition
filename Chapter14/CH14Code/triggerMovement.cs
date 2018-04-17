using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerMovement : MonoBehaviour {

	public bool movingForward;

	void OnTriggerEnter(Collider other) {

		if (movingForward == true)
		{
			Enemy.turnAround = true;
		}

		else
		{
			Enemy.turnAround = false;
		}

	}
}
