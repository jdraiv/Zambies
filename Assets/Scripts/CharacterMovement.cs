using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
	public float speed;
	public bool grounded;

	private SpriteRenderer mySpriteRenderer;
	private BoxCollider2D myBoxCollider;

	// Use this for initialization
	void Start () {
		mySpriteRenderer = GetComponent<SpriteRenderer>();
		myBoxCollider = GetComponent<BoxCollider2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		Movement();
		Jump();

	}

	void Movement () {


		if (Input.GetKeyDown(KeyCode.A))
		{
			mySpriteRenderer.flipX = true;
			myBoxCollider.offset = new Vector2(0.7f, 0f);
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			mySpriteRenderer.flipX = false;
			myBoxCollider.offset = new Vector2(-0.7f, 0f);
		}

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
				rb.AddForce(new Vector2(0, 25), ForceMode2D.Impulse); 
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
