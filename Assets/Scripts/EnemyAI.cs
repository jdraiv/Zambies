using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public Transform target;
	public float enemySpeed;
	private GameObject Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		findPlayer();
	}

	void findPlayer() {
		Vector3 playerPosition = Player.transform.position;
		playerPosition.x -= 1;
		transform.position = Vector2.MoveTowards(transform.position, playerPosition, enemySpeed * Time.deltaTime);

	}
	

}