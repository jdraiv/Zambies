using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
	public float speed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Left and right movement
		Vector3 newPosition = transform.position;
		newPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		transform.position = newPosition;
		
	}
}
