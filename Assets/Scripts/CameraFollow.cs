using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	private Transform Player;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player").transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = Player.position;
		playerPos.z = transform.position.z;
		playerPos.y = transform.position.y;
		transform.position = playerPos;

	}
}
