using UnityEngine;

public class JinjaController : MonoBehaviour {

	[SerializeField]
	float acceleration = 0.1f;

	[SerializeField]
	float friction = 0.9f;

	// a field to store how fast Jinja is moving
	Vector3 velocity = Vector3.zero;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		//shortcut for Jinja's transform component
		Transform tf = GetComponent<Transform>();

		// apply friction
		velocity.x *= friction;

		//if the right arrow key is pressed
		if (Input.GetKey(KeyCode.RightArrow)) {
			// increase Jinja's velocity
			velocity += Vector3.right * acceleration;
		}

		//if the left arrow key is pressed
		if (Input.GetKey(KeyCode.LeftArrow)) {
			// decrease Jinja's velocity
			velocity += Vector3.left * acceleration;
		}

		//move jinja by her current velocity
		tf.position += velocity;

	}
}
