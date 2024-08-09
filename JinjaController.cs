using UnityEngine;

public class JinjaController : MonoBehaviour {

	// a field to store jinja's velocity
	Vector3 velocity = Vector3.zero;

	// a field to store jinja's acceleration setting
	[SerializeField]
	float acceleration = 0.1f;

	//a field to store jinja's friction setting
	[SerializeField]
	float friction = 0.9f;

	// a field to store jinja's gravity setting
	[SerializeField]
	float gravity = 0.02f;

	// a field to store jinja's jump setting
	[SerializeField]
	float jump = 0.3f;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		//shortcut for jinja's transform component
		Transform tf = GetComponent<Transform>();

		//add friction
		velocity.x *= friction;

		//apply gravity
		velocity += Vector3.down * gravity;

		// check if the right arrow key is pressed
		if (Input.GetKey(KeyCode.RightArrow)) {
			velocity += Vector3.right * acceleration;

		}

		// check if the left arrow key is pressed
		if (Input.GetKey(KeyCode.LeftArrow)) {
			velocity += Vector3.left * acceleration;

		}


		// did the player press the spacebar this frame?
		if (Input.GetKeyDown(KeyCode.Space)) {

			//is jinja on a platform?
			RaycastHit2D hitGround = Physics2D.Raycast(tf.position, Vector3.down, 0.1f);

			if (hitGround.collider != null) {

				//jump
				velocity.y = jump;
			}

		}

		//move jinja by her current velocity
		tf.position += velocity;

		//COLLISION


		//the start of the ray (jijnjas position before she moved)
		Vector3 origin = tf.position - velocity;

		// the direction of the ray
		Vector3 direction = velocity;

		// length of the ray (the distance jinja moved)
		float length = velocity.magnitude;

		// the result of the raycast
		RaycastHit2D hit = Physics2D.Raycast(origin, direction, length);

		//did jinja go down through a platform when she moved?
		if (velocity.y < 0 && hit.collider != null) {

			//put her exactly on the platform
			tf.position = new Vector3(tf.position.x, hit.point.y, tf.position.z);

			//reset her velocity
			velocity.y = 0;
		}

	}
}
