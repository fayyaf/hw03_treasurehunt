using UnityEngine;
using System.Collections;

public class BasicPlayerController : MonoBehaviour {

	public float moveSpeed = 5f;
	public float turnSpeed = 15f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{ 
		if (Input.GetKey (KeyCode.A))
		{
			// move the current object, framerate independent
			transform.position += new Vector3(0f, 0f, moveSpeed)* Time.deltaTime;
			// rotate the current object to face the way it's moving
			transform.eulerAngles = new Vector3(0f, turnSpeed, 0f) * Time.deltaTime;
		}

		Camera.main.transform.position = transform.position + new Vector3(0f, 5f, -25f);
	}
}
