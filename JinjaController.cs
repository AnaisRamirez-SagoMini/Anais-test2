using UnityEngine;

public class JinjaController : MonoBehaviour {
	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		// check if the right arrow key is pressed
		if (Input.GetKey(KeyCode.RightArrow)) {
			// make jinja move
			GetComponent<Transform>().position += Vector3.right;

		}
	}
}
