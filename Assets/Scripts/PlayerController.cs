using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float horizontalInput;
	private float speed = 10.0f;
	private float xRange = 10.0f;
	public GameObject projectilePrefab;
	void Start()
	{

	}

	void Update()
	{
		// Screen player limiter conditionals
		if (transform.position.x < -xRange)
		{
			transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
		}
		if (transform.position.x > xRange)
		{
			transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
		}
		// launch projectiles from the player
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
		}

		horizontalInput = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
	}
}
