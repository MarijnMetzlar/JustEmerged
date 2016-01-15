using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {

	public Transform snakeEnemyPrefab;
	public Transform metalEnemyPrefab;
	public Transform slimePrefab;

	private int testEnemyLocation;

	// Use this for initialization
	void Start () 
	{
		SpawnSnakes ();
		SpawnMetalEnemies ();
		SpawnSlimeEnemies ();
	}

	void SpawnSnakes()
	{
		Vector3 alienPosition = (GameObject.FindGameObjectWithTag ("LocationAlien").GetComponent<Transform>().position);

		for (int i = 0; i < 20; i++) 
		{
			Instantiate (snakeEnemyPrefab, new Vector3 (Random.Range (alienPosition.x - 250.0f, alienPosition.x + 250.0f), alienPosition.y + 50.0f, Random.Range (alienPosition.z - 250.0f, alienPosition.z + 250.0f)), Quaternion.identity);
		}
	}

	void SpawnMetalEnemies ()
	{
		Vector3 metalPosition = (GameObject.FindGameObjectWithTag ("LocationMetal").GetComponent<Transform>().position);
		
		for (int i = 0; i < 20; i++) 
		{
			Instantiate (metalEnemyPrefab, new Vector3 (Random.Range (metalPosition.x - 250.0f, metalPosition.x + 250.0f), metalPosition.y + 130.0f, Random.Range (metalPosition.z - 250.0f, metalPosition.z + 250.0f)), Quaternion.identity);
		}
	}

	void SpawnSlimeEnemies ()
	{
		Vector3 slimePosition = (GameObject.FindGameObjectWithTag ("LocationPlasma").GetComponent<Transform>().position);
		
		for (int i = 0; i < 20; i++) 
		{
			Instantiate (slimePrefab, new Vector3 (Random.Range (slimePosition.x - 250.0f, slimePosition.x + 250.0f), slimePosition.y + 130.0f, Random.Range (slimePosition.z - 250.0f, slimePosition.z + 250.0f)), Quaternion.identity);
		}
	}
}
