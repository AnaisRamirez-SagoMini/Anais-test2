using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinjaController : MonoBehaviour {

	// a field to store Jinja's velocity
	Vector3 velocity = Vector3.zero;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		//variable to store jinja's transform component
		Transform tf = GetComponent<Transform>();

		// check if the right arrow key is down
		if (Input.GetKey(KeyCode.RightArrow)) {
			//add to the velocity
			velocity += Vector3.right * 0.1f;
		}

		// check if the left arrow key is down
		if (Input.GetKey(KeyCode.LeftArrow)) {
			//reduce velocity
			velocity += Vector3.left * 0.1f;
		}

		//move jinja by her current velocity
		tf.position += velocity;
	}
}
