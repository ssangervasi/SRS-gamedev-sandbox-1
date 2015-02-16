using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;

	// Update is called once per frame
	void Update() {
	
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertial = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertial);
		rigidbody.AddForce (speed*movement*Time.deltaTime);

	}

	
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Pickup") {
			other.gameObject.SetActive(false);
		}
	}
}
