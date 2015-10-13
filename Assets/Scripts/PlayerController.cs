using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour 
{
	private float moveSpeed = 25f ;
	private float turnspeed = 150f ;
	 
	public GameObject Shot;
	public Transform ShotSpawner;

	public float fireRate;
	private float nextFire;


	void Start () 
	{

	}

	void Update ()
	{
		if (Input.GetKey( KeyCode.Space) && Time.time > nextFire)

		{
			nextFire = Time.time + fireRate;
//			GameObject clone = 
			Instantiate(Shot, ShotSpawner.position, ShotSpawner.rotation);
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
	}
	
	void FixedUpdate () 
	{

		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate ( Vector3.up, -turnspeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate ( Vector3.up, turnspeed * Time.deltaTime);

		}
	void OnTriggerEnter(Collider other)
	{ 
		if (other.tag == "Asteroid") 
		{
			Destroy (this.gameObject);
			Application.LoadLevel(2);
		}
	}
} 