using UnityEngine;
using System.Collections;

public class LeaveTrigger : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other) {

		LevelGenerator.instance.AddPiece();
		LevelGenerator.instance.RemoveOldestPiece();
	}
	
}
