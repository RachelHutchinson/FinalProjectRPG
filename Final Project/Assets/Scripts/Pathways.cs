﻿using UnityEngine;
using System.Collections;

public class Pathways : MonoBehaviour {

	GameObject player;
	public GameObject darkness;


	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnTriggerStay2D (Collider2D other) {

		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			player.transform.position = new Vector3 (10, 3, 0);
			GameObject dark =
				Instantiate (darkness, new Vector3 (3, 3, 0f), Quaternion.identity) as GameObject;

		}
		return;
	}
		

}
