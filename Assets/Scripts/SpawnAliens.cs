using UnityEngine;
using System.Collections;

public class SpawnAliens : MonoBehaviour {

	public GameObject aliens;
	public Vector3 spawnValues;
	public int aliensCount;
	
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	void Start ()
	{
		//		score = 0;
		//		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}
	
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int j = 0; j < aliensCount; j++)
			{
				Vector3 spawnPos = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (aliens, spawnPos, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
		}
	}
	
	//	public void AddScore(int newScoreValue)
	//	{
	//		score += newScoreValue;
	//		UpdateScore ();
	//	}
	//
	//	void UpdateScore ()
	//	{
	//		scoreText.text = "Score:" + score; 
	//	}
}