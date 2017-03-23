using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public GameObject bullet;
	public GameObject bulletTwo;
	public float bulletSpeed;
	public bool left;

	public float ammo;
	private float fireRate = 0.3f;
	private float nextBullet = 0.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Shooting();
		Reloading();
	}

	void Shooting () {
		if (ammo > 0)
		{

			if (Input.GetKeyDown(KeyCode.A)){
				left = true;
			}

			if (Input.GetKeyDown(KeyCode.D))
			{
				left = false;
			}

			if (Input.GetKeyDown("space") & (left == true) & (Time.time > nextBullet))
			{
				nextBullet = Time.time + fireRate;
				Vector3 newPosition = transform.position;
				newPosition.x -= 1;
				Instantiate(bulletTwo, newPosition, transform.rotation);
				ammo -= 1;
			}

			if (Input.GetKeyDown("space") & (left == false) & (Time.time > nextBullet))
			{
				nextBullet = Time.time + fireRate;
				Vector3 newPosition = transform.position;
				newPosition.x += 0.5f;
				Instantiate(bullet, newPosition, transform.rotation);
				ammo -= 1;
			}
		}

	}

	void Reloading () {
		if (Input.GetKeyDown(KeyCode.R))
		{
			ammo = 12;
		}
	}




}
