using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinjaController : MonoBehaviour {
	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		//check if the arrow key is down
		if (Input.GetKey(KeyCode.RightArrow)) {
			// move jinja
			GetComponent<Transform>().position += Vector3.right * 0.1f;
		}

		//check if the arrow key is down
		if (Input.GetKey(KeyCode.LeftArrow)) {
			// move jinja
			GetComponent<Transform>().position += Vector3.left * 0.1f;
		}

	}
}
