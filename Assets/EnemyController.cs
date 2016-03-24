using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	
	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.


	// Use this for initialization
	void Start () {
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
