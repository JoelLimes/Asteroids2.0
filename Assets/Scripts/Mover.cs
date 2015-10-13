using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float speed;
	
	void Start ()
	{

	}

	void Update()
	{
		transform.Translate (new Vector3 (0,0,1) * speed * Time.deltaTime);
	}

	void OnTriggerExit(Collider coll) 
	{
		if(coll.transform.tag == "Boundary") 
		{
			Destroy(this.gameObject);
		}
	}

	void OnTriggerStay(Collider coll) 
	{
		if(coll.transform.tag ==  "Boundary") 
		{

		}
	}
}