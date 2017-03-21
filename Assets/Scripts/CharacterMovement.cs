using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
	public float speed;
	public float forcePower;
	public bool grounded;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Movement();
		Jump();

	}

	void Movement () {
		Vector3 newPosition = transform.position;
		newPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		transform.position = newPosition;
	}

	void Jump () {

		Rigidbody2D rb = GetComponent<Rigidbody2D> ();

		if (Input.GetKey(KeyCode.W) && (grounded == true))
		{
			if (rb.velocity.y <= 0)
			{
				rb.AddForce(new Vector2(0, 20), ForceMode2D.Impulse); 
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
			grounded = true;
		}

	void OnCollisionExit2D(Collision2D coll) {
		grounded = false;
	}

}
