using UnityEngine;
using System.Collections;

public class TerrainRenderer : MonoBehaviour {

	public GameObject[] _terrainsPrefabs;
	
	// Update is called once per frame
	void Update () 
	{
		//locate the position of the player every frame
		Vector3 playerPosition = GameObject.FindGameObjectWithTag ("Player").transform.position;

		//needed to change the prefabs in the scene!
		_terrainsPrefabs [0] = GameObject.FindGameObjectWithTag ("TerrainOne");
		_terrainsPrefabs [1] = GameObject.FindGameObjectWithTag ("TerrainTwo");
		_terrainsPrefabs [2] = GameObject.FindGameObjectWithTag ("TerrainThree");
		_terrainsPrefabs [3] = GameObject.FindGameObjectWithTag ("TerrainFour");
		_terrainsPrefabs [4] = GameObject.FindGameObjectWithTag ("TerrainFive");
		_terrainsPrefabs [5] = GameObject.FindGameObjectWithTag ("TerrainSix");
		_terrainsPrefabs [6] = GameObject.FindGameObjectWithTag ("TerrainSeven");
		_terrainsPrefabs [7] = GameObject.FindGameObjectWithTag ("TerrainEight");
		_terrainsPrefabs [8] = GameObject.FindGameObjectWithTag ("TerrainNine");

		//if player is on terrain zero(leftunder)
		if(playerPosition.x < 1000.0f && playerPosition.z < 1000.0f)
		{
			_terrainsPrefabs [0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber1].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber2].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber3].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber4].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber5].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber6].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber7].GetComponent<Terrain> ().enabled = false;
		}
		//if player is on terrain one(middleunder)
		else if(playerPosition.x < 2000.0f && playerPosition.x > 1000.0f && playerPosition.z < 1000.0f)
		{
			_terrainsPrefabs [0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber1].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber2].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber3].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber4].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber5].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber6].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber7].GetComponent<Terrain> ().enabled = false;
		}
		//if player is on terrain two(rightunder)
		else if(playerPosition.x < 3000.0f && playerPosition.x > 2000.0f && playerPosition.z < 1000.0f)
		{
			_terrainsPrefabs [0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber0].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber1].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber2].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber3].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber4].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber5].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber6].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber7].GetComponent<Terrain> ().enabled = false;
		}
		//if player is on terrain three(left)
		else if(playerPosition.x < 1000.0f && playerPosition.z > 1000.0f && playerPosition.z < 2000.0f)
		{
			_terrainsPrefabs [0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber1].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber2].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber3].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber4].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber5].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber6].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber7].GetComponent<Terrain> ().enabled = false;
		}
		//if player is on terrain home(0)
		else if(playerPosition.x < 2000.0f && playerPosition.x > 1000.0f && playerPosition.z < 2000.0f && playerPosition.z > 1000.0f)
		{
			_terrainsPrefabs [0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber0].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber1].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber2].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber3].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber4].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber5].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber6].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber7].GetComponent<Terrain> ().enabled = false;
		}
		//if player is on terrain four(right)
		else if(playerPosition.x < 3000.0f && playerPosition.x > 2000.0f && playerPosition.z < 2000.0f && playerPosition.z > 1000.0f)
		{
			_terrainsPrefabs [0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber0].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber1].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber2].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber3].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber4].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber5].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber6].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber7].GetComponent<Terrain> ().enabled = true;
		}
		//if player is on terrain five(leftup)
		else if(playerPosition.x < 1000.0f && playerPosition.z < 3000.0f && playerPosition.z > 2000.0f)
		{
			_terrainsPrefabs [0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber0].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber1].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber2].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber3].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber4].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber5].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber6].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber7].GetComponent<Terrain> ().enabled = false;
		}
		//if player is on terrain six(middleup)
		else if(playerPosition.x < 2000.0f && playerPosition.x > 1000.0f && playerPosition.z < 3000.0f && playerPosition.z > 2000.0f)
		{
			_terrainsPrefabs [0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber0].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber1].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber2].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber3].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber4].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber5].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber6].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber7].GetComponent<Terrain> ().enabled = true;
		}
		//if player is on terrain seven(rightup)
		else if(playerPosition.x < 3000.0f && playerPosition.x > 2000.0f && playerPosition.z < 3000.0f && playerPosition.z > 2000.0f)
		{
			_terrainsPrefabs [0].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber0].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber1].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber2].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber3].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber4].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber5].GetComponent<Terrain> ().enabled = false;
			_terrainsPrefabs [TerrainPlacer.terrainNumber6].GetComponent<Terrain> ().enabled = true;
			_terrainsPrefabs [TerrainPlacer.terrainNumber7].GetComponent<Terrain> ().enabled = true;
		}
	}
}
