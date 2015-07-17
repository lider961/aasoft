using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Basket : MonoBehaviour {
	public float speed = 0.1f;
	public Text scoreText;
	public Text scoreText2;
	public Text scoreText3;
	void Start () {
		scoreText.text = "0";
	}
	void Update () {
		/*
		Vector3 mouse2Dpos = Input.mousePosition;
		Vector3 mouse3Dpos = Camera.main.ScreenToWorldPoint (mouse2Dpos);
		Vector3 pos = this.transform.position;
		pos.x = mouse3Dpos.x;
		this.transform.position = pos;*/

		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			Vector3 position = this.transform.position;
			position.x--;
			this.transform.position = position;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;
		}


	}
	void OnTriggerEnter(Collider collider)
	{
		// Find out what hit the basket
		GameObject collidedWith = collider.gameObject;
		// if it's an apple destroy it
		if (collidedWith.CompareTag ("apple")) {
			Destroy(collidedWith);
			int score = int.Parse (scoreText.text);
			score ++;
			scoreText.text = score.ToString ();
		}
		else if (collidedWith.CompareTag ("apple_g")) {
			Destroy(collidedWith);
			int score = int.Parse (scoreText2.text);
			score ++;
			scoreText2.text = score.ToString ();
		}
		else if (collidedWith.CompareTag ("apple_y")) {
			Destroy(collidedWith);
			int score = int.Parse (scoreText3.text);
			score ++;
			scoreText3.text = score.ToString ();
		}
	}
}