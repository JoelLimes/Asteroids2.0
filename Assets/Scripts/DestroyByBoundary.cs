using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

	// Use this for initialization
	void OnTriggerExit(Collider other) {
		// Destroy everything that leaves the trigger
		Destroy(other.gameObject);
	}
}
