using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour {
	public float bulletSpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 bulletPosition = transform.position;
		bulletPosition.x += bulletSpeed * Time.deltaTime * 2;
		transform.position = bulletPosition;
	}

}


