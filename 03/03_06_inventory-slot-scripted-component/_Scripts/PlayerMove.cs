﻿using UnityEngine;

/*
 * basic 2D character controller
 * use array keys / WASD to move object up/down/left/right
 */
public class PlayerMove : MonoBehaviour
{
	// change speed
	public float speed = 10;

	// cached reference to a physics RigidBody
	private Rigidbody2D rigidBody2D;

	// the new velocity based on inputs
	private Vector2 newVelocity;

	//--------------------------
	// get reference tot the RigidBody 2D compoonent
	// that is in the parent GameObject to which an instance of this script has been added
	void Awake()
	{
		rigidBody2D = GetComponent<Rigidbody2D>();
	}

	//---------------------------
	void Update()
	{
		// read from movement keys
		// arrow keys / WASD
		// GetAxis returns values between -1.0...0...+1.0
		float xMove = Input.GetAxis("Horizontal");
		float yMove = Input.GetAxis("Vertical");

		// mutliple by speed factor
		float xSpeed = xMove * speed;
		float ySpeed = yMove * speed;

		// create (dx,dy) vector object
		newVelocity = new Vector2(xSpeed, ySpeed);
	}
	
	//---------------------------
	void FixedUpdate()
	{
		// set the velocity of the Physicsl rigid body to this (x,y) vector
		rigidBody2D.velocity = newVelocity;
	}
}
