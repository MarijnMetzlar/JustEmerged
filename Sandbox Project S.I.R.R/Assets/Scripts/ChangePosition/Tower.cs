﻿using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	public Transform fadeInPrefab;

	void Update ()
	{
		gameObject.GetComponent<Transform> ().Rotate (Vector3.right + Vector3.up * 3);
	}

	void OnTriggerEnter(Collider other)
	{
		Instantiate (fadeInPrefab, new Vector3(0, 0, 0), Quaternion.identity);
		GameObject.Find("car").GetComponent<Transform>().position = new Vector3(1562.0f, -1441.9f, 1622.6f);
	}

//	if (SpawnTower.tower == 1) 
//	{
//		Application.LoadLevel("Boss area 5");
//	}
//	
//	else if (SpawnTower.tower == 2) 
//	{
//		Debug.Log ("Load Boss level 2");
//	}
//	
//	else if (SpawnTower.tower == 3) 
//	{
//		Debug.Log ("Load Boss level 3");
//	}
//	
//	else if (SpawnTower.tower == 4) 
//	{
//		Debug.Log ("Load Boss level 4");
//	}
//	
//	else if (SpawnTower.tower == 5) 
//	{
//		Debug.Log ("Load Boss level 5");
//	}
//	
//	else if (SpawnTower.tower == 6) 
//	{
//		Debug.Log ("Load Boss level 6");
//	}
//	
//	else if (SpawnTower.tower == 7) 
//	{
//		Debug.Log ("Load Boss level 7");
//	}
//	
//	else if (SpawnTower.tower == 8) 
//	{
//		Debug.Log ("Load Boss level 8");
//	}
}