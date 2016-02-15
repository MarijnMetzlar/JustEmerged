using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TerrainPlacer : MonoBehaviour {

	public GameObject[] terrainsPrefabs;

	private List<int> terrainsList = new List<int>();

	public static int terrainNumber0;
	public static int terrainNumber1;
	public static int terrainNumber2;
	public static int terrainNumber3;
	public static int terrainNumber4;
	public static int terrainNumber5;
	public static int terrainNumber6;
	public static int terrainNumber7;

	// Use this for initialization
	void Awake () 
	{
		terrainsList.Add (1);
		terrainsList.Add (2);
		terrainsList.Add (3);
		terrainsList.Add (4);
		terrainsList.Add (5);
		terrainsList.Add (6);
		terrainsList.Add (7);
		terrainsList.Add (8);

		terrainNumber0 = terrainsList [Random.Range (0, 7)];
		terrainsList.Remove (terrainNumber0);

		terrainNumber1 = terrainsList [Random.Range (0, 6)];
		terrainsList.Remove (terrainNumber1);

		terrainNumber2 = terrainsList [Random.Range (0, 5)];
		terrainsList.Remove (terrainNumber2);

		terrainNumber3 = terrainsList [Random.Range (0, 4)];
		terrainsList.Remove (terrainNumber3);

		terrainNumber4 = terrainsList [Random.Range (0, 3)];
		terrainsList.Remove (terrainNumber4);

		terrainNumber5 = terrainsList [Random.Range (0, 2)];
		terrainsList.Remove (terrainNumber5);

		terrainNumber6 = terrainsList [Random.Range (0, 1)];
		terrainsList.Remove (terrainNumber6);

		terrainNumber7 = terrainsList [0];
		terrainsList.Remove (terrainNumber7);

	}

	void Start () 
	{
		Instantiate (terrainsPrefabs [terrainNumber0], new Vector3 (0, 0, 0), Quaternion.identity);
			//terrainOne = terrainsPrefabs [terrainNumber0];
		Instantiate (terrainsPrefabs [terrainNumber1], new Vector3 (1000, 0, 0), Quaternion.identity);
			//terrainTwo = terrainsPrefabs [terrainNumber1];
		Instantiate (terrainsPrefabs [terrainNumber2], new Vector3 (2000, 0, 0), Quaternion.identity);
			//terrainThree = terrainsPrefabs [terrainNumber2];
		Instantiate (terrainsPrefabs [terrainNumber3], new Vector3 (0, 0, 1000), Quaternion.identity);
			//terrainFour = terrainsPrefabs [terrainNumber3];
		Instantiate (terrainsPrefabs [0], new Vector3 (1000, 0, 1000), Quaternion.identity);
			//terrainFive = terrainsPrefabs [0];
		Instantiate (terrainsPrefabs [terrainNumber4], new Vector3 (2000, 0, 1000), Quaternion.identity);
			//terrainSix = terrainsPrefabs [terrainNumber4];
		Instantiate (terrainsPrefabs [terrainNumber5], new Vector3 (0, 0, 2000), Quaternion.identity);
			//terrainSeven = terrainsPrefabs [terrainNumber5];
		Instantiate (terrainsPrefabs [terrainNumber6], new Vector3 (1000, 0, 2000), Quaternion.identity);
			//terrainEight = terrainsPrefabs [terrainNumber6];
		Instantiate (terrainsPrefabs [terrainNumber7], new Vector3 (2000, 0, 2000), Quaternion.identity);
			//terrainNine = terrainsPrefabs [terrainNumber7];
	}
}
