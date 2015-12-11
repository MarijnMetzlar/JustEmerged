using UnityEngine;
using System.Collections;

public class PlayerTeleportation : MonoBehaviour {

	void Update () 
	{
		Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position;
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		if (playerPosition.z > 2950.0f) 
		{
			player.GetComponent<Transform>().position = new Vector3(playerPosition.x, playerPosition.y, 85.0f);
		}

		else if (playerPosition.z < 50.0f) 
		{
			player.GetComponent<Transform>().position = new Vector3(playerPosition.x, playerPosition.y, 2915.0f);
		}

		if (playerPosition.x > 2950.0f) 
		{
			player.GetComponent<Transform>().position = new Vector3(85.0f, playerPosition.y, playerPosition.z);
		}

		if (playerPosition.x < 50.0f) 
		{
			player.GetComponent<Transform> ().position = new Vector3 (2915.0f, playerPosition.y, playerPosition.z);
		}
	}
}
