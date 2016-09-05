using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public Vector2 speed = new Vector2(50,50);
	public Vector2 direction = new Vector2(-1,0);
	private Vector2 movement;
	
	//Update movement with each frame
	void Update () {
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");
		
		movement = new Vector2 (
			speed.x * direction.x,
			speed.y * direction.y);
		
		
	}
	
	//Update position on rendered frames 
	void FixedUpdate () {
		GetComponent<Rigidbody2D>().velocity = movement;
		
	}
}
