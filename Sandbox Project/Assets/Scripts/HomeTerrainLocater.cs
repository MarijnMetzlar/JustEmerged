using UnityEngine;
using System.Collections;

public class HomeTerrainLocater : MonoBehaviour {

	public Transform garagePrefab;
	public Transform player;

	// Use this for initialization
	void Start () 
	{
		Vector3 homePosition = (GameObject.FindGameObjectWithTag ("LocationHome").GetComponent<Transform>().position);
		Instantiate (player, homePosition, Quaternion.identity);
	}
}
