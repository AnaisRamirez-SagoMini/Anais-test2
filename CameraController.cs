using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	[SerializeField]
	Transform jinjaTransform = null;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		// get the current position
		Vector3 current = GetComponent<Transform>().position;

		// get the target position (jinja)
		Vector3 target = jinjaTransform.position + Vector3.up;

		//make sure the camera's z coordinate doesn't change
		target.z = current.z;

		//get the new position
		Vector3 position = Vector3.Lerp(current, target, 0.1f);

		//move the camera to the new position
		GetComponent<Transform>().position = position;

	}
}
