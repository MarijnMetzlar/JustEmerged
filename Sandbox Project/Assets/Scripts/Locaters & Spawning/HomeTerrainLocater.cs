using UnityEngine;
using System.Collections;

public class HomeTerrainLocater : MonoBehaviour {

	public Transform garagePrefab;
	//public Transform player;

	public int garageLocation;

	// Use this for initialization
	void Start () 
	{
		//find specific location on the home realm!
		Vector3 homePosition = (GameObject.FindGameObjectWithTag ("LocationHome").GetComponent<Transform>().position);
		//3 different locations for the garage
		garageLocation = 1; //Random.Range (0, 5);

		if (garageLocation == 0) 
		{
			Instantiate (garagePrefab, new Vector3 (homePosition.x + 40.0f, 50.0f, homePosition.z), Quaternion.identity);
		} 
		else if (garageLocation == 1) 
		{
			Instantiate (garagePrefab, new Vector3 (homePosition.x + 250.0f, 50.0f, homePosition.z), Quaternion.identity);
		} 
		else if(garageLocation == 2) 
		{
			Instantiate (garagePrefab, new Vector3 (homePosition.x, 50.0f, homePosition.z + 250.0f), Quaternion.identity);
		}
		else if(garageLocation == 3) 
		{
			Instantiate (garagePrefab, new Vector3 (homePosition.x - 250.0f, 50.0f, homePosition.z), Quaternion.Euler(0, 90, 0));
		}
		else if(garageLocation == 4) 
		{
			Instantiate (garagePrefab, new Vector3 (homePosition.x, 50.0f, homePosition.z - 250.0f), Quaternion.identity);
		}
	}
}
