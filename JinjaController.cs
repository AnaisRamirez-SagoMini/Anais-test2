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

		//move jinja
		tf.position += velocity;

	}
}
