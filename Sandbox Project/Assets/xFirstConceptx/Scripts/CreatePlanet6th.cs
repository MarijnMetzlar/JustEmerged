using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreatePlanet6th : MonoBehaviour {

	public Transform[] planet6thPrefabs;

	private List<int> RealmsList = new List<int>();
	
	public int randomPiece0;
	public int randomPiece1;
	public int randomPiece2;
	public int randomPiece3;
	public int randomPiece4;
	public int randomPiece5;

	// Use this for initialization
	void Awake () 
	{
		RealmsList.Add (0);
		RealmsList.Add (1);
		RealmsList.Add (2);
		RealmsList.Add (3);
		RealmsList.Add (4);
		RealmsList.Add (5);

		randomPiece0 = RealmsList [Random.Range(0,6)];
		RealmsList.Remove (randomPiece0);
		//throw used number out of array, 5 numbers in array

		randomPiece1 = RealmsList [Random.Range(0,5)];
		RealmsList.Remove (randomPiece1);
		//throw used number out of array, 4 numbers in array

		randomPiece2 = RealmsList [Random.Range(0,4)];
		RealmsList.Remove (randomPiece2);
		//throw used number out of array, 3 numbers in array

		randomPiece3 = RealmsList [Random.Range(0,3)];
		RealmsList.Remove (randomPiece3);
		//throw used number out of array, 2 numbers in array

		randomPiece4 = RealmsList [Random.Range(0,2)];
		RealmsList.Remove (randomPiece4);
		//throw used number out of array, 1 number in array for randomPiece5.

		randomPiece5 = RealmsList [Random.Range(0,1)];
		// -> one possibility

		Instantiate (planet6thPrefabs [randomPiece0], new Vector3 (24.3f, -310.3f, 1071.9f), Quaternion.Euler (0, 180, 180));
		Instantiate (planet6thPrefabs [randomPiece1], new Vector3 (-0.8f, -1382.4f, -25.5f), Quaternion.Euler (270, 90, 0));
		Instantiate (planet6thPrefabs [randomPiece2], new Vector3 (-25.3f, -1382.3f, -0.1f), Quaternion.Euler (270, 180, 0));
		Instantiate (planet6thPrefabs [randomPiece3], new Vector3 (0.0f, -1382.3f, 24.9f), Quaternion.Euler (270, 270, 0));
		Instantiate (planet6thPrefabs [randomPiece4], new Vector3 (-24.0f, -310.3f, 1071.9f), Quaternion.Euler (0, 180, 0));
		Instantiate (planet6thPrefabs [randomPiece5], new Vector3 (24.2f, -1382.5f, -0.5f), Quaternion.Euler (270, 0, 0));
	}
}
