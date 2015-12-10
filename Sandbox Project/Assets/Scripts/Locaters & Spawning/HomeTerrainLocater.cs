using UnityEngine;
using System.Collections;

public class HomeTerrainLocater : MonoBehaviour {

	public Transform garagePrefab;
	public Transform player;

	public int garageLocation;
	public Vector3 garagePosition;

	// Use this for initialization
	void Start () 
	{
		//find specific location on the home realm!
		Vector3 homePosition = (GameObject.FindGameObjectWithTag ("LocationHome").GetComponent<Transform>().position);
		//3 different locations for the garage
		garageLocation = Random.Range (0, 5);

		if (garageLocation == 0) 
		{
			garagePosition = new Vector3 (homePosition.x + 40.0f, homePosition.y + 20.0f, homePosition.z);
		} 
		else if (garageLocation == 1) 
		{
			garagePosition = new Vector3 (homePosition.x + 250.0f, homePosition.y - 30.5f, homePosition.z);
		} 
		else if(garageLocation == 2) 
		{
			garagePosition = new Vector3 (homePosition.x, homePosition.y - 30.5f, homePosition.z + 250.0f);
		}
		else if(garageLocation == 3) 
		{
			garagePosition = new Vector3 (homePosition.x - 250.0f, homePosition.y - 30.5f, homePosition.z);
		}
		else if(garageLocation == 4) 
		{
			garagePosition = new Vector3 (homePosition.x, homePosition.y - 30.5f, homePosition.z - 250.0f);
		}

		Instantiate (player, homePosition, Quaternion.identity);
		Instantiate (garagePrefab, garagePosition, Quaternion.identity);
	}
}
