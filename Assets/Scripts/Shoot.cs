using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public GameObject bullet;
	public GameObject bulletTwo;
	public float bulletSpeed;
	public bool left;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.A)){
			left = true;
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			left = false;
		}

		if (Input.GetKeyDown("space") & (left == true))
		{
			Instantiate(bulletTwo, transform.position, transform.rotation);
		}

		if (Input.GetKeyDown("space") & (left == false))
		{
			Instantiate(bullet, transform.position, transform.rotation);
		}
	}
	
}
