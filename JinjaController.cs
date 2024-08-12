using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinjaController : MonoBehaviour {

	//a field to store jinja's velocity
	Vector3 velocity = Vector3.zero;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		Transform tf = GetComponent<Transform>();

		//check if the arrow key is down
		if (Input.GetKey(KeyCode.RightArrow)) {
			// increasing velocity
			velocity += Vector3.right * 0.1f;
		}

		//check if the arrow key is down
		if (Input.GetKey(KeyCode.LeftArrow)) {
			// decreasing velocity
			velocity += Vector3.left * 0.1f;
		}

		//move jinja
		tf.position += velocity;

	}
}
