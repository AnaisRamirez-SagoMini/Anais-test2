using UnityEngine;

public class JinjaController : MonoBehaviour {
	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		//shortcut for jinja's transform component
		Transform tf = GetComponent<Transform>();

		// check if the right arrow key is pressed
		if (Input.GetKey(KeyCode.RightArrow)) {
			// make jinja move
			tf.position += Vector3.right * 0.1f;

		}

		// check if the left arrow key is pressed
		if (Input.GetKey(KeyCode.LeftArrow)) {
			// make jinja move
			tf.position += Vector3.left * 0.1f;

		}
	}
}
