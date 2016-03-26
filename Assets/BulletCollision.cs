using UnityEngine;
using System.Collections;
	

public class BulletCollision : MonoBehaviour {

	private Rigidbody2D rb2d;
	//Basically, when you left click, shoot in direction of the mouse
	public float speed;
	// Use this for initialization

	float mouseX;
	float mouseY;
	Vector2 mouseCoord;

	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();

		mouseX = Input.mousePosition.x - Screen.width / 2;
		mouseY = Input.mousePosition.y - Screen.height / 2;
		mouseCoord = new Vector2 (mouseX, mouseY);
		//rb2d.velocity = transform.forward * speed;
		rb2d.AddForce (mouseCoord * speed);
		//rb2d.velocity = new Vector2(speed,speed);

	}
	
	// Update is called once per frame
	void Update () {
		//rb2d.velocity = transform.forward * speed;
		rb2d.AddForce (mouseCoord * speed);
		
	}
}
