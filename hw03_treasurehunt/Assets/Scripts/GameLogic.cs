using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public Text textUI;
	public Transform player;
	public float distance = 10f;


	// Update is called once per frame
	void Update ()
	{
		distance = Vector3.Distance(player.position, transform.position);

		if (Input.GetKey(KeyCode.Space) && distance < 8f)
		{
			textUI.text = "You've found the elusive 10 karat diamond orb! YOU WIN!";
		}
	}
}