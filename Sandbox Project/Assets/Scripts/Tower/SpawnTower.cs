using UnityEngine;
using System.Collections;

public class SpawnTower : MonoBehaviour {

	public Transform towerPrefab;

	// Use this for initialization
	void Start () 
	{
		Instantiate (towerPrefab, new Vector3 (0.0f, 33.05f, 40.3f), Quaternion.identity);
	}
}
