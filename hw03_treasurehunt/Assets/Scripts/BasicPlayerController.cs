using UnityEngine;
using System.Collections;

public class BasicPlayerController : MonoBehaviour {

	public float moveSpeed = 5f;
	public float turnSpeed = 90f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{ 

		// move up
		if (Input.GetKey (KeyCode.W))
		{
			// move the current object, framerate independent
			transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * moveSpeed;
			// rotate the current object to face the way it's moving
			transform.eulerAngles = new Vector3(0f, 1f, 0f);
		}

		// move left
		if (Input.GetKey (KeyCode.A))
		{
			// move the current object, framerate independent
			transform.position += new Vector3(-1f, 0f, 0f)* Time.deltaTime * moveSpeed;
			// rotate the current object to face the way it's moving
			transform.eulerAngles = new Vector3(0f, -90f, 0f);
		}

		// move right
		if (Input.GetKey (KeyCode.D))
		{
			// move the current object, framerate independent
			transform.position += new Vector3(1f, 0f, 0f)* Time.deltaTime * moveSpeed;
			// rotate the current object to face the way it's moving
			transform.eulerAngles = new Vector3(0f, 90f, 0f);
		}

		// move down
		if (Input.GetKey (KeyCode.S))
		{
			// move the current object, framerate independent
			transform.position += new Vector3(0f, 0f, -1f)* Time.deltaTime * moveSpeed;
			// rotate the current object to face the way it's moving
			transform.eulerAngles = new Vector3(0f, 1f, 0f);
		}
		
		Camera.main.transform.position = transform.position + new Vector3(0f, 2f, -8f);
	}
}
