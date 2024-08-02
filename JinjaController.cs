using UnityEngine;

public class JinjaController : MonoBehaviour {
	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		//check if the right arrow key is down, move jinja
		if (Input.GetKey(KeyCode.RightArrow)) {
			GetComponent<Transform>().position += Vector3.right * 0.1f;
		}

		//check if the left arrow key is down, move jinja
		if (Input.GetKey(KeyCode.LeftArrow)) {
			GetComponent<Transform>().position += Vector3.left * 0.1f;
		}

	}
}
