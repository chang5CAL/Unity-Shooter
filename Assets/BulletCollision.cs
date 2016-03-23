using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {
	//Basically, when you left click, shoot in direction of the mouse
	public float speed;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
