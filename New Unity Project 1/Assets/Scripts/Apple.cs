using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnBecameInvisible() {
		// Destroy the apple
		Destroy(gameObject);
	}
}
