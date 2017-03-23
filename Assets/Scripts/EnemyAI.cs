using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public Transform target;
	public float enemySpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		findPlayer();
	}

	void findPlayer() {
		transform.LookAt(target.position);
		transform.Rotate(new Vector3(0,-90,0),Space.Self);

		if (Vector3.Distance(transform.position, target.position)>1f)
		{
			transform.Translate(new Vector3(enemySpeed * Time.deltaTime,0,0));
		}
	}
}