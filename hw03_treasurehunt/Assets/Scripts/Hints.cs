using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hints : MonoBehaviour {

	public Text textUI;
	public Transform player;
	public float distance = 5f;

	// Update is called once per frame
	void Update ()
	{
		distance = Vector3.Distance(player.position, transform.position);

		if (player.position.x < -10f)
		{
			textUI.text = "Too far west. Head east towards the futuristic camera art sculpture.";
		}
		else if (player.position.z > 350f)
		{
			textUI.text = "Too far north. Backtrack and head east towards the delicious ice cream cone.";
		}
		else if (player.position.x > 400f)
		{
			textUI.text = "Too far east. Head west towards the delicious ice cream cone.";
		}
		else if (player.position.z < 0f)
		{
			textUI.text = "Too far south. Head north towards the futuristic camera art sculpture.";
		}
		else
		{
			textUI.text = "";
		}
	}
}