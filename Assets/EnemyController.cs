using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public Vector2 direction;             //Floating point variable to store the player's movement speed.

	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.


	// Use this for initialization
	void Start (float dirX,float dirY) {
		direction = new Vector2(dirX,dirY);
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*if ()
		{
			//While it's on screen, go forwards.

			rb2d.AddForce(direction*20)
		}*/
	
	}
}
