using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinjaController : MonoBehaviour {

	// a field to store Jinja's velocity
	Vector3 velocity = Vector3.zero;

	[SerializeField]
	float acceleration = 0.1f;

	[SerializeField]
	float friction = 0.9f;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		//variable to store jinja's transform component
		Transform tf = GetComponent<Transform>();

		// add friction
		velocity.x *= friction;

		// check if the right arrow key is down
		if (Input.GetKey(KeyCode.RightArrow)) {
			//add to the velocity
			velocity += Vector3.right * acceleration;
		}

		// check if the left arrow key is down
		if (Input.GetKey(KeyCode.LeftArrow)) {
			//reduce velocity
			velocity += Vector3.left * acceleration;
		}

		//move jinja by her current velocity
		tf.position += velocity;
	}
}
