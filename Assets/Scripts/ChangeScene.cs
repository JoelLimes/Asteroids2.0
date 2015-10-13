using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	[SerializeField] void Change(int scene) {
		Application.LoadLevel (scene);
	}
}
