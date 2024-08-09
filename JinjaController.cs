using UnityEngine;

public class JinjaController : MonoBehaviour {

	// a field to store jinja's velocity
	Vector3 velocity = Vector3.zero;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		//shortcut for jinja's transform component
		Transform tf = GetComponent<Transform>();

		// check if the right arrow key is pressed
		if (Input.GetKey(KeyCode.RightArrow)) {
			velocity += Vector3.right * 0.1f;

		}

		// check if the left arrow key is pressed
		if (Input.GetKey(KeyCode.LeftArrow)) {
			velocity += Vector3.left * 0.1f;

		}

		//move jinja by her current velocity
		tf.position += velocity;
	}
}
