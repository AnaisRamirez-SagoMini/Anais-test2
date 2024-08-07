using UnityEngine;

public class JinjaController : MonoBehaviour {
	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		// check if the arrow key is dowm
		if (Input.GetKey(KeyCode.RightArrow)) {
			// move jinja to the right
			GetComponent<Transform>().position += Vector3.right;
		}
	}
}
