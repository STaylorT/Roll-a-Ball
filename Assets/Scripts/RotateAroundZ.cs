using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundZ : MonoBehaviour
{
	// The speed at which the coin rotates.
	public float Speed = 10;

	// FixedUpdate is called before each step in the physics engine.
	void FixedUpdate()
	{	// Rotate the object by 15 (x axis), 30 (y axis) and 45 (z axis) times deltaTime
		// to make the rotation per second rather than per frame.
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}