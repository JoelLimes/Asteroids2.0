﻿using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour 
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private gameController gameController;
	public GameObject smallHazards;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) 
		{
			gameController = gameControllerObject.GetComponent<gameController>();
		}

		if (gameController == null) 
		{
			Debug.Log ("Cannot find GameControllerScript");
	
		}

	}

	void OnTriggerEnter(Collider other)
	{ 

		if (other.tag == "Boundary") 
		{
			return;
		}

		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player"){
		Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
		}

		gameController.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
		Instantiate (smallHazards, transform.position, transform.rotation);
	}	
}