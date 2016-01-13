using UnityEngine;
using System.Collections;

public class AncientTreeBoss : MonoBehaviour {
	
	public float rootsAreaTimer = 3.0f;
	public Vector3 placementPool;
	public Transform poolOfDeathPrefab;
	private float spawnDistance = 1.0f;

	// Update is called once per frame
	void Update () 
	{
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		placementPool = player.transform.position - (player.transform.forward * spawnDistance);

		rootsAreaTimer -= Time.deltaTime;
		if (rootsAreaTimer < 0) 
		{
			Instantiate(poolOfDeathPrefab, placementPool, Quaternion.Euler(90, 0, 0));
			rootsAreaTimer = 3.0f;
		}
	}
}
