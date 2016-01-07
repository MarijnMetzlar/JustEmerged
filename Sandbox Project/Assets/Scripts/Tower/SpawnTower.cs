using UnityEngine;
using System.Collections;

public class SpawnTower : MonoBehaviour {

	public Transform towerPrefab;
	public int tower;
	public int locationTower;

	// Use this for initialization
	void Start () 
	{
		tower = Random.Range (1, 9);
		locationTower = Random.Range (1, 7);

		switch (tower) 
		{
		case 1:
			SpawnTowerAlienForest ();
			break;
		case 2:
			SpawnTowerRocky ();
			break;
		case 3:
			SpawnTowerLava ();
			break;
		case 4:
			SpawnTowerMetal ();
			break;
		case 5:
			SpawnTowerDesert ();
			break;
		case 6:
			SpawnTowerSavana ();
			break;
		case 7:
			SpawnTowerSnow ();
			break;
		case 8:
			SpawnTowerPlasma ();
			break;
		default:
			break;
		}
	}

	void SpawnTowerAlienForest ()
	{
		Vector3 LocaterAlienForest = GameObject.FindGameObjectWithTag ("LocationAlien").GetComponent<Transform> ().position;

		if(locationTower == 1)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterAlienForest.x - 368.4f, 60.0f, LocaterAlienForest.z + 412.0f), Quaternion.identity);
		}
		
		else if(locationTower == 2)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterAlienForest.x - 344.0f, 60.0f, LocaterAlienForest.z - 16.0f), Quaternion.identity);
		}
		
		else if(locationTower == 3)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterAlienForest.x + 118.6f, 60.0f, LocaterAlienForest.z + 189.5f), Quaternion.identity);
		}
		
		else if(locationTower == 4)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterAlienForest.x + 253.8f, 60.0f, LocaterAlienForest.z + 233.3f), Quaternion.identity);
		}
		
		else if(locationTower == 5)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterAlienForest.x + 253.8f, 53.6f, LocaterAlienForest.z + 233.3f), Quaternion.identity);
		}
		
		else
		{
			Instantiate (towerPrefab, new Vector3 (LocaterAlienForest.x + 458.7f, 53.6f, LocaterAlienForest.z + 233.3f), Quaternion.identity);
		}
	}

	void SpawnTowerRocky ()
	{
		Vector3 LocaterRocky = (GameObject.FindGameObjectWithTag ("LocationRocky").GetComponent<Transform>().position);

		if(locationTower == 1)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterRocky.x + 402.6f, 50.8f, LocaterRocky.z + 314.0f), Quaternion.identity);
		}
		
		else if(locationTower == 2)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterRocky.x + 196.8f, 146.2f, LocaterRocky.z + 223.6f), Quaternion.identity);
		}
		
		else if(locationTower == 3)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterRocky.x - 53.3f, 49.4f, LocaterRocky.z + 122.1f), Quaternion.identity);
		}
		
		else if(locationTower == 4)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterRocky.x - 26.4f, 87.8f, LocaterRocky.z - 90.0f), Quaternion.identity);
		}
		
		else 
		{
			Instantiate (towerPrefab, new Vector3 (LocaterRocky.x - 171.2f, 95.5f, LocaterRocky.z - 177.3f), Quaternion.identity);
		}
	}

	void SpawnTowerLava ()
	{
		Vector3 LocaterLava = (GameObject.FindGameObjectWithTag ("LocationLava").GetComponent<Transform>().position);

		if(locationTower == 1)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterLava.x - 70.0f, 53.0f, LocaterLava.z + 429.9f), Quaternion.identity);
		}
		
		else if(locationTower == 2)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterLava.x - 456.0f, 53.0f, LocaterLava.z + 94.0f), Quaternion.identity);
		}
		
		else if(locationTower == 3)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterLava.x + 300.3f, 53.1f, LocaterLava.z + 76.8f), Quaternion.identity);
		}
		
		else if(locationTower == 4)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterLava.x - 277.0f, 55.7f, LocaterLava.z - 221.5f), Quaternion.identity);
		}
		
		else 
		{
			Instantiate (towerPrefab, new Vector3 (LocaterLava.x + 300.3f, 55.7f, LocaterLava.z - 238.7f), Quaternion.identity);
		}
	}

	void SpawnTowerMetal ()
	{
		Vector3 LocaterMetal = (GameObject.FindGameObjectWithTag ("LocationMetal").GetComponent<Transform>().position);

		if(locationTower == 1)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterMetal.x + 342.0f, 53.0f, LocaterMetal.z + 346.0f), Quaternion.identity);
		}
		
		else if(locationTower == 2)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterMetal.x - 322.0f, 53.0f, LocaterMetal.z + 158.0f), Quaternion.identity);
		}
		
		else if(locationTower == 3)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterMetal.x + 411.0f, 53.0f, LocaterMetal.z - 74.0f), Quaternion.identity);
		}
		
		else if(locationTower == 4)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterMetal.x + 112.6f, 53.0f, LocaterMetal.z - 248.6f), Quaternion.identity);
		}
		
		else 
		{
			Instantiate (towerPrefab, new Vector3 (LocaterMetal.x - 441.0f, 53.0f, LocaterMetal.z - 365.0f), Quaternion.identity);
		}
	}

	void SpawnTowerDesert ()
	{
		Vector3 LocaterDesert = (GameObject.FindGameObjectWithTag ("LocationDesert").GetComponent<Transform>().position);

		if(locationTower == 1)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterDesert.x - 342.0f, 55.0f, LocaterDesert.z + 243.0f), Quaternion.identity);
		}
		
		else if(locationTower == 2)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterDesert.x + 254.0f, 52.0f, LocaterDesert.z + 318.0f), Quaternion.identity);
		}
		
		else if(locationTower == 3)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterDesert.x - 86.0f, 54.2f, LocaterDesert.z + 101.0f), Quaternion.identity);
		}
		
		else if(locationTower == 4)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterDesert.x - 271.0f, 52.7f, LocaterDesert.z - 405.0f), Quaternion.identity);
		}
		
		else 
		{
			Instantiate (towerPrefab, new Vector3 (LocaterDesert.x + 353.0f, 53.6f, LocaterDesert.z - 335.0f), Quaternion.identity);
		}
	}

	void SpawnTowerSavana ()
	{
		Vector3 LocaterSavana = (GameObject.FindGameObjectWithTag ("LocationSavana").GetComponent<Transform>().position);

		if(locationTower == 1)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterSavana.x - 368.9f, 61.8f, LocaterSavana.z + 391.4f), Quaternion.identity);
		}
		
		else if(locationTower == 2)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterSavana.x + 366.7f, 63.0f, LocaterSavana.z + 349.4f), Quaternion.identity);
		}
		
		else if(locationTower == 3)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterSavana.x - 94.3f, 50.2f, LocaterSavana.z + 38.0f), Quaternion.identity);
		}
		
		else if(locationTower == 4)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterSavana.x - 299.0f, 63.0f, LocaterSavana.z - 285.0f), Quaternion.identity);
		}
		
		else 
		{
			Instantiate (towerPrefab, new Vector3 (LocaterSavana.x + 128.3f, 63.0f, LocaterSavana.z - 335.9f), Quaternion.identity);
		}
	}

	void SpawnTowerSnow ()
	{
		Vector3 LocaterSnow = (GameObject.FindGameObjectWithTag ("LocationSnow").GetComponent<Transform>().position);

		if(locationTower == 1)
		{
			Debug.Log("Snow terrain has no tower yet!");
		}
		
		else if(locationTower == 2)
		{
			Debug.Log("Snow terrain has no tower yet!");
		}
		
		else if(locationTower == 3)
		{
			Debug.Log("Snow terrain has no tower yet!");
		}
		
		else if(locationTower == 4)
		{
			Debug.Log("Snow terrain has no tower yet!");
		}
		
		else 
		{
			Debug.Log("Snow terrain has no tower yet!");
		}
	}

	void SpawnTowerPlasma ()
	{
		Vector3 LocaterPlasma = (GameObject.FindGameObjectWithTag ("LocationPlasma").GetComponent<Transform>().position);

		if(locationTower == 1)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterPlasma.x - 394.0f, 56.8f, LocaterPlasma.z + 331.0f), Quaternion.identity);
		}
		
		else if(locationTower == 2)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterPlasma.x + 376.0f, 56.8f, LocaterPlasma.z + 331.0f), Quaternion.identity);
		}
		
		else if(locationTower == 3)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterPlasma.x - 89.0f, 56.8f, LocaterPlasma.z - 23.7f), Quaternion.identity);
		}
		
		else if(locationTower == 4)
		{
			Instantiate (towerPrefab, new Vector3 (LocaterPlasma.x - 394.0f, 56.8f, LocaterPlasma.z - 454.0f), Quaternion.identity);
		}
		
		else 
		{
			Instantiate (towerPrefab, new Vector3 (LocaterPlasma.x + 376.0f, 56.8f, LocaterPlasma.z - 393.8f), Quaternion.identity);
		}
	}
}
