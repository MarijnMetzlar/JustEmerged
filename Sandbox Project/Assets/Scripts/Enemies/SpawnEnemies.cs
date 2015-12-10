using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {

	public Transform testEnemyPrefab;

	private int testEnemyLocation;

	// Use this for initialization
	void Start () 
	{
		Vector3 testEnemyPosition = (GameObject.FindGameObjectWithTag ("LocationMetal").GetComponent<Transform>().position);

		for (int i = 0; i < 20; i++) 
		{
			Instantiate (testEnemyPrefab, new Vector3 (Random.Range (testEnemyPosition.x - 250.0f, testEnemyPosition.x + 250.0f), testEnemyPosition.y + 130.0f, Random.Range (testEnemyPosition.z - 250.0f, testEnemyPosition.z + 250.0f)), Quaternion.identity);
		}
	}
}
