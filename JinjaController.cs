using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinjaController : MonoBehaviour {

	//a field to store jinja's velocity
	Vector3 velocity = Vector3.zero;

	[SerializeField]
	float acceleration = 0.1f;

	[SerializeField]
	float friction = 0.9f;

	// a field to store jinja's gravity setting
	[SerializeField]
	float gravity = 0.02f;

	//a field to store jinja's jumping setting
	[SerializeField]
	float jump = 0.3f;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		Transform tf = GetComponent<Transform>();

		// add friction
		velocity.x *= friction;

		//add gravity
		velocity += Vector3.down * gravity;

		//check if the arrow key is down
		if (Input.GetKey(KeyCode.RightArrow)) {
			// increasing velocity
			velocity += Vector3.right * acceleration;
		}

		//check if the arrow key is down
		if (Input.GetKey(KeyCode.LeftArrow)) {
			// decreasing velocity
			velocity += Vector3.left * acceleration;
		}

		// did the player press the spacebar this frame?
		if (Input.GetKeyDown(KeyCode.Space)) {

			// is jinja on a platform?
			RaycastHit2D platformHit = Physics2D.Raycast(tf.position, Vector3.down, 0.1f);

			if (platformHit.collider != null) {
				//jump 
				velocity.y = jump;
			}
		}

		//move jinja
		tf.position += velocity;


		// the start of the ray
		Vector3 origin = tf.position - velocity;

		//the direction of the ray
		Vector3 direction = velocity;

		// the length of the ray
		float length = velocity.magnitude;

		RaycastHit2D hit = Physics2D.Raycast(origin, direction, length);

		// did jinja go down through a platform when she moved?
		if (velocity.y < 0 && hit.collider != null) {
			// put her exactly on the platform
			tf.position = new Vector3(tf.position.x, hit.point.y, tf.position.z);

			//reset her y velocity
			velocity.y = 0;
		}


		//ANIMATION

		// get a reference to the Animator component
		Animator animator = GetComponentInChildren<Animator>();
		animator.ResetTrigger("Idle");
		animator.ResetTrigger("Run");
		animator.ResetTrigger("Jump");

		//check if jinja is in the air
		RaycastHit2D hitGround = Physics2D.Raycast(tf.position, Vector3.down, 0.1f);
		if (hitGround.collider == null) {
			// tell the animator to play the jump animation
			animator.SetTrigger("Jump");
		}// check if the left or right arrow key is pressed
		else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Mathf.Abs(velocity.x) >= 0.02f) {
			//tell the animator to play the run animation
			animator.SetTrigger("Run");
		} else {
			// tell the animator to play the idle animation
			animator.SetTrigger("Idle");

			//make jinja stop moving
			velocity.x = 0;
		}

		//if jinja is moving
		if (Mathf.Abs(velocity.x) >= 0.02f) {
			//get the direction from jinja's velocity, 1 or -1
			float movementDirection = Mathf.Sign(velocity.x);

			//make her face the right way
			tf.localScale = new Vector3(movementDirection, 1, 1);
		}


	}
}
