using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetection : MonoBehaviour {

	private int enemyHealth = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Bullet" && (enemyHealth == 1))
		{
			Destroy(coll.gameObject);
			Destroy(this.gameObject);
		}
		if (coll.gameObject.tag == "Bullet" && (enemyHealth == 2))
		{
			enemyHealth -= 1;
			Destroy(coll.gameObject);
		}

	}
}
