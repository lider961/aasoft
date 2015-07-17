using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {
	// Prefab for creating apples
	
	public GameObject applePrefab;
	public GameObject applePrefab2;
	public GameObject applePrefab3;
		
	// Rate at which the apples are created
	public float secondsBetweenAppleDrops = 1f;
	
	public float speed = 2f;
	// Distance where the AppleTree turns around
	public float leftAndRightEdge = 6f;
	// Chance that the tree will change direction
	public float chanceToChangeDirection = 0.1f;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating ("DropApple", 1f, secondsBetweenAppleDrops);
	}
	void DropApple()
	{
		int randomNumber = Random.Range (1, 4);
		if (randomNumber == 1) {
			GameObject apple = Instantiate (applePrefab) as GameObject;
			apple.transform.position = transform.position;
		}
		else if(randomNumber==2){
			GameObject apple = Instantiate (applePrefab2) as GameObject;
			apple.transform.position = transform.position;
		}
		else{
			GameObject apple = Instantiate (applePrefab3) as GameObject;
			apple.transform.position = transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 savedTreePosition = transform.position; // a
		savedTreePosition.x += speed * Time.deltaTime; // b
		transform.position = savedTreePosition; 
		if (savedTreePosition.x < -leftAndRightEdge) { // left edge
			speed = Mathf.Abs (speed); // Move right
		}
		else if (savedTreePosition.x > leftAndRightEdge) { // right edge
			speed = -Mathf.Abs(speed); // move left
		}
	}
	void FixedUpdate() {
		// changing direction randomly
		if (Random.value < chanceToChangeDirection) {
			speed *= -1; //change direction
		}
	}
}
