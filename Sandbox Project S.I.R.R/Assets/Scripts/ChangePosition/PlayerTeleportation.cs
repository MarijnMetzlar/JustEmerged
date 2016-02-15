using UnityEngine;
using System.Collections;

public class PlayerTeleportation : MonoBehaviour {

	public Transform fadeInPrefab;

	void Update () 
	{
		Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position;
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		if (playerPosition.z > 2997.5f) 
		{
			Instantiate (fadeInPrefab, new Vector3(0, 0, 0), Quaternion.identity);
			player.GetComponent<Transform>().position = new Vector3(playerPosition.x, playerPosition.y, 5.0f);
		}

		else if (playerPosition.z < 2.5f) 
		{
			Instantiate (fadeInPrefab, new Vector3(0, 0, 0), Quaternion.identity);
			player.GetComponent<Transform>().position = new Vector3(playerPosition.x, playerPosition.y, 2995.0f);
		}

		if (playerPosition.x > 2997.5f) 
		{
			Instantiate (fadeInPrefab, new Vector3(0, 0, 0), Quaternion.identity);
			player.GetComponent<Transform>().position = new Vector3(5.0f, playerPosition.y, playerPosition.z);
		}

		if (playerPosition.x < 2.5f) 
		{
			Instantiate (fadeInPrefab, new Vector3(0, 0, 0), Quaternion.identity);
			player.GetComponent<Transform> ().position = new Vector3 (2995.0f, playerPosition.y, playerPosition.z);
		}
	}
}
