using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	public float anglePerSecond;

	void Update() {
		float deltaAngle = (anglePerSecond*Time.deltaTime);
		transform.Rotate (deltaAngle, deltaAngle, 0);
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Pickup") {
			other.gameObject.SetActive (false);
		}
	}
}
