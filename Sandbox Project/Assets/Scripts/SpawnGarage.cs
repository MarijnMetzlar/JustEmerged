using UnityEngine;
using System.Collections;

public class SpawnGarage : MonoBehaviour {

	public Transform garagePrefab;

	// Use this for initialization
	void Start () 
	{
		Vector3 garagePosition = (GameObject.FindGameObjectWithTag ("LocationHome").GetComponent<Transform>().position);
		Quaternion garageRotation = GameObject.FindGameObjectWithTag ("Home").GetComponent<Transform>().rotation;
		Instantiate (garagePrefab, garagePosition, garageRotation);
	}
}
