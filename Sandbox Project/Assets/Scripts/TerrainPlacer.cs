using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TerrainPlacer : MonoBehaviour {

	public Transform[] terrainsPrefabs;

	private List<int> terrainsList = new List<int>();

	public int terrainNumber0;
	public int terrainNumber1;
	public int terrainNumber2;
	public int terrainNumber3;
	public int terrainNumber4;
	public int terrainNumber5;
	public int terrainNumber6;
	public int terrainNumber7;
	public int terrainNumber8;

	// Use this for initialization
	void Awake () 
	{
		terrainsList.Add (0);
		terrainsList.Add (1);
		terrainsList.Add (2);
		terrainsList.Add (3);
		terrainsList.Add (4);
		terrainsList.Add (5);
		terrainsList.Add (6);
		terrainsList.Add (7);
		terrainsList.Add (8);

		terrainNumber0 = terrainsList [Random.Range (0, 8)];
		terrainsList.Remove (terrainNumber0);

		terrainNumber1 = terrainsList [Random.Range (0, 7)];
		terrainsList.Remove (terrainNumber1);

		terrainNumber2 = terrainsList [Random.Range (0, 6)];
		terrainsList.Remove (terrainNumber2);

		terrainNumber3 = terrainsList [Random.Range (0, 5)];
		terrainsList.Remove (terrainNumber3);

		terrainNumber4 = terrainsList [Random.Range (0, 4)];
		terrainsList.Remove (terrainNumber4);

		terrainNumber5 = terrainsList [Random.Range (0, 3)];
		terrainsList.Remove (terrainNumber5);

		terrainNumber6 = terrainsList [Random.Range (0, 3)];
		terrainsList.Remove (terrainNumber6);

		terrainNumber7 = terrainsList [Random.Range (0, 2)];
		terrainsList.Remove (terrainNumber7);

		terrainNumber8 = terrainsList [Random.Range (0, 1)];
		terrainsList.Remove (terrainNumber8);

	}
	
	// Update is called once per frame
	void Start () 
	{

		Instantiate (terrainsPrefabs [terrainNumber0], new Vector3 (0, 0, 0), Quaternion.identity);
		Instantiate (terrainsPrefabs [terrainNumber1], new Vector3 (350, 0, 0), Quaternion.identity);
		Instantiate (terrainsPrefabs [terrainNumber2], new Vector3 (700, 0, 0), Quaternion.identity);
		Instantiate (terrainsPrefabs [terrainNumber3], new Vector3 (0, 0, 350), Quaternion.identity);
		Instantiate (terrainsPrefabs [terrainNumber4], new Vector3 (350, 0, 350), Quaternion.identity);
		Instantiate (terrainsPrefabs [terrainNumber5], new Vector3 (700, 0, 350), Quaternion.identity);
		Instantiate (terrainsPrefabs [terrainNumber6], new Vector3 (0, 0, 700), Quaternion.identity);
		Instantiate (terrainsPrefabs [terrainNumber7], new Vector3 (350, 0, 700), Quaternion.identity);
		Instantiate (terrainsPrefabs [terrainNumber8], new Vector3 (700, 0, 700), Quaternion.identity);
	}
}
