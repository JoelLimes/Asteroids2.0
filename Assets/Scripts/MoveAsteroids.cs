using UnityEngine;
using System.Collections;

public class MoveAsteroids : MonoBehaviour {
	
	public float minSpeed;
	public float maxSpeed;

	private float curSpeed;

		
	void Start ()
	{
		curSpeed = Random.Range (minSpeed, maxSpeed);
	}
		
		void Update()
	{
		transform.Translate (new Vector3 (0,0,-1)* curSpeed * Time.deltaTime, Space.World);
	}

}