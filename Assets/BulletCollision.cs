using UnityEngine;
using System.Collections;
	

public class BulletCollision : MonoBehaviour {

	private Rigidbody2D rb2d;
	//Basically, when you left click, shoot in direction of the mouse
	public float speed;
	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
