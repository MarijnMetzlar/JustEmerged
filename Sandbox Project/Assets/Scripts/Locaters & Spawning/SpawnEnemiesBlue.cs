using UnityEngine;
using System.Collections;

public class SpawnEnemiesBlue : MonoBehaviour {

	public Transform blueEnemy;
	
	void Start ()
	{
		Vector3 blueEnemyPosition = (GameObject.FindGameObjectWithTag ("LocationBlue").GetComponent<Transform>().position);
		Quaternion blueEnemyRotation = GameObject.FindGameObjectWithTag ("Blue").GetComponent<Transform>().rotation;

		for (int i = 0; i < 3; i++) 
		{
			Instantiate (blueEnemy, new Vector3(Random.Range (blueEnemyPosition.x, blueEnemyPosition.x + 200.0f ), blueEnemyPosition.y, Random.Range(blueEnemyPosition.z, blueEnemyPosition.z + 200.0f)), blueEnemyRotation);
		}

		for (int i = 0; i < 2; i++)
		{
			Instantiate (blueEnemy, new Vector3(Random.Range (blueEnemyPosition.x - 200.0f, blueEnemyPosition.x), blueEnemyPosition.y, Random.Range(blueEnemyPosition.z - 200.0f, blueEnemyPosition.z)), blueEnemyRotation);
		}
	}
}
