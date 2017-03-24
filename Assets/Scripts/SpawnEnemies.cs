using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		InvokeRepeating("BrainEaters", 3.0f, 3.0f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void BrainEaters() {

		Vector3 enemyPosition = transform.position;
		int randomPosition = Random.Range(-9, -2);
		enemyPosition.y += 1;
		enemyPosition.x += randomPosition;
		Instantiate(enemy, enemyPosition, transform.rotation);
	}
}
