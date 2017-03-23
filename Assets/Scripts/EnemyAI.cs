using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {


	public float enemySpeed;
	private GameObject Player;
	public bool grounded;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		findPlayer();
	}

	void findPlayer() {
		if (grounded == true)
		{
			Vector3 playerPosition = Player.transform.position;
			playerPosition.x -= 1;
			transform.position = Vector2.MoveTowards(transform.position, playerPosition, enemySpeed * Time.deltaTime);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		grounded = true;
	}
	void OnCollisionExit2D(Collision2D coll) {
		grounded = false;
	}
	

}