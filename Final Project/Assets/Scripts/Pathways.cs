﻿using UnityEngine;
using System.Collections;

public class Pathways : MonoBehaviour {

	public GameObject player;
	public GameObject darkI;
	public GameObject darkO;
	public GameObject coverWall;
	public AudioClip outerRoom;
	public int room;
	//x and y of the wall of the room you just left
	//wall

	void Start () {
		GameObject timer = GameObject.Find ("Timer");
		CountDown countDown = timer.GetComponent<CountDown> ();
		coverWall.SetActive (false);
	}

	void Update () {
		if (CountDown.walls == true) {
			coverWall.SetActive (false);
			CountDown.walls = false;
		}
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)) 
		{
			darkO.SetActive(false);
			darkI.SetActive(false);
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			darkI.SetActive (true);
			SoundManager.instance.MainMusic (outerRoom);
			coverWall.SetActive (true);
		} else {
			darkO.SetActive (true);
		}
	}		

}
