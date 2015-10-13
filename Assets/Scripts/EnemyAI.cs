using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public GameObject explosion;
	public GameObject enemyExplosion;
	

	Transform tr_Player;
	float f_Rotspeed = 3.0f, f_MoveSpeed = 12.0f;

	// Use this for initialization
	void Start () 
	{
		tr_Player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{   // Look at player
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (tr_Player.position - transform.position),
		                                      f_Rotspeed * Time.deltaTime);

		// Move to Player
		transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
	}

	void OnTriggerEnter(Collider other)
	{ 
		if (other.tag == "Boundary") 
		{
			return;
		}
		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player"){
			Instantiate(enemyExplosion, other.transform.position, other.transform.rotation);
		}

		Destroy (this.gameObject);
		Destroy (other.gameObject);
	}
}
