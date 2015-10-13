using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Array : MonoBehaviour {

	public GameObject[] objects;

	List<GameObject> MyGameObjectList = new List<GameObject>();

	// Use this for initialization
	void Start () 
	{

		GameObject MyObject = new GameObject ("My Object");
		MyGameObjectList.Add (MyObject);

		Debug.Log ("");

		for (int i = 0; i < MyGameObjectList.Count; i++) 
		{
			Debug.Log(MyGameObjectList.Count);
			Debug.Log(MyGameObjectList[i].gameObject.name);
		}

//		GameObject My2eObject = new GameObject ("My Second Game Object");




		/*for (int i = 0; i < objects.Length; i++) 
		{
			Debug.Log(objects[i].gameObject.name);
			Debug.Log(objects.Length);
		}*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
