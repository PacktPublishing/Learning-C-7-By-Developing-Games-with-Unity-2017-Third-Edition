using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpForce = 6f;
	public float runningSpeed = 1.5f;
	private Rigidbody2D rigidBody;
	public Animator animator;

	void Awake() {
		rigidBody = GetComponent<Rigidbody2D>();
	}

	void Start() {
		animator.SetBool("isAlive", true);
	}


	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			Jump();
		}

		animator.SetBool("isGrounded", IsGrounded());
	}


	void FixedUpdate() {

		if (rigidBody.velocity.x < runningSpeed) {
			rigidBody.velocity = new Vector2(runningSpeed, rigidBody.velocity.y);
		}
	}



	void Jump() {
		if (IsGrounded()) {
			rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		}
	}

	public LayerMask groundLayer;

	bool IsGrounded() {

		if (Physics2D.Raycast(this.transform.position, Vector2.down, 0.2f, groundLayer.value)) {
			return true;
		}
		else {
			return false;
		}
	}


}



