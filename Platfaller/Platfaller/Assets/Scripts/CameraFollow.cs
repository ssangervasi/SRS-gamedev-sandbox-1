using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject following;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = new Vector3(following.transform.position.x,
										  transform.position.y,
										  transform.position.z);
		transform.position = newPosition;
	}
}
