using UnityEngine;
using System.Collections;

public class ScrubLord : MonoBehaviour {
	
	public float targetDistance;
	public float enemyLookDistance;
	public float attackDistance;
	public float damping;
	private float enemyMovementSpeed = 10.0f;
	
	public float spawnDistance;
	public float enemyHeight;
	
	public float throwTimer = 10.0f;
	
	private bool Dir1 = false;
	private bool Dir2 = false;
	private bool Dir3 = false;
	private bool Dir4 = false;

	public int miniBossType;

	public Transform spikePrefab;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		targetDistance = Vector3.Distance (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position, transform.position);
		
		if (targetDistance < enemyLookDistance) 
		{
			//reseting the directions
			Dir1 = false;
			Dir2 = false;
			Dir3 = false;
			Dir4 = false;
			
			LookAtPlayer ();
			Attack ();
		} 
		
		else 
		{
			WalkingPatern ();
		}
	}
	
	void LookAtPlayer ()
	{
		Quaternion rotation = Quaternion.LookRotation (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}
	
	void Attack ()
	{
		transform.Translate (Vector3.forward * enemyMovementSpeed * Time.deltaTime);
		
		//if the location of the player is close attack the player with a dash or hit
		if (targetDistance < 3.0f) 
		{
			enemyMovementSpeed = 0;
		}

		if (targetDistance > 3.0f) 
		{
			enemyMovementSpeed = 10.0f;
		}
		
		throwTimer -= Time.deltaTime;
		if (throwTimer < 1.5f) 
		{
			//play animation I guess
			enemyMovementSpeed = 0;
		}
		
		if (throwTimer < 0) 
		{
			ThrowSpike ();
			throwTimer = 10.0f;
			enemyMovementSpeed = 10;
		}
	}
	
	void ThrowSpike ()
	{
		Vector3 enemyPosition = transform.position + (transform.forward * spawnDistance) + (transform.up * enemyHeight);
		Instantiate(spikePrefab, enemyPosition, transform.rotation);
	}
	
	void WalkingPatern ()
	{
		Vector3 obeliskPosition = GameObject.FindGameObjectWithTag ("LocationAlien").GetComponent<Transform>().position;

		transform.Translate (Vector3.forward * enemyMovementSpeed * Time.deltaTime);
		
		if (miniBossType == 0) 
		{
			if (gameObject.transform.position.z > (obeliskPosition.z - 150.0f) && Dir1 == false) 
			{
				Dir1 = true;
				//Debug.Log("Turn now 90");
				gameObject.transform.eulerAngles = new Vector3 (0, 90, 0);
				Dir3 = false;
			}
		
			if (gameObject.transform.position.x > (obeliskPosition.x - 170.0f) && Dir2 == false) 
			{
				Dir2 = true;
				//Debug.Log("Turn now 180");
				gameObject.transform.eulerAngles = new Vector3 (0, 180, 0);
				Dir4 = false;
			} 
			else if (gameObject.transform.position.z < (obeliskPosition.z - 190.0f) && Dir3 == false) 
			{
				Dir3 = true;
				//Debug.Log("Turn now 270");
				gameObject.transform.eulerAngles = new Vector3 (0, 270, 0);
				Dir1 = false;
			} 
			else if (gameObject.transform.position.x < (obeliskPosition.x - 213.0f) && Dir4 == false) 
			{
				Dir4 = true;
				//Debug.Log("Turn now 0");
				gameObject.transform.eulerAngles = new Vector3 (0, 0, 0);
				Dir2 = false;
			}
		}

		if (miniBossType == 1) 
		{
			if (gameObject.transform.position.z > (obeliskPosition.z - 297.0f) && Dir1 == false) 
			{
				Dir1 = true;
				//Debug.Log("Turn now 90");
				gameObject.transform.eulerAngles = new Vector3 (0, 90, 0);
				Dir3 = false;
			}
			if (gameObject.transform.position.x > (obeliskPosition.x + 25.0f) && Dir2 == false) 
			{
				Dir2 = true;
				//Debug.Log("Turn now 180");
				gameObject.transform.eulerAngles = new Vector3 (0, 180, 0);
				Dir4 = false;
			} 
			else if (gameObject.transform.position.z < (obeliskPosition.z - 332.0f) && Dir3 == false) 
			{
				Dir3 = true;
				//Debug.Log("Turn now 270");
				gameObject.transform.eulerAngles = new Vector3 (0, 270, 0);
				Dir1 = false;
			} 
			else if (gameObject.transform.position.x < (obeliskPosition.x - 16.0f) && Dir4 == false) 
			{
				Dir4 = true;
				//Debug.Log("Turn now 0");
				gameObject.transform.eulerAngles = new Vector3 (0, 0, 0);
				Dir2 = false;
			}
		}

		if (miniBossType == 2) 
		{
			if (gameObject.transform.position.z > (obeliskPosition.z + 249.0f) && Dir1 == false) 
			{
				Dir1 = true;
				//Debug.Log("Turn now 90");
				gameObject.transform.eulerAngles = new Vector3 (0, 90, 0);
				Dir3 = false;
			}
			if (gameObject.transform.position.x > (obeliskPosition.x - 217.0f) && Dir2 == false) 
			{
				Dir2 = true;
				//Debug.Log("Turn now 180");
				gameObject.transform.eulerAngles = new Vector3 (0, 180, 0);
				Dir4 = false;
			} 
			else if (gameObject.transform.position.z < (obeliskPosition.z + 215.0f) && Dir3 == false) 
			{
				Dir3 = true;
				//Debug.Log("Turn now 270");
				gameObject.transform.eulerAngles = new Vector3 (0, 270, 0);
				Dir1 = false;
			} 
			else if (gameObject.transform.position.x < (obeliskPosition.x - 256.0f) && Dir4 == false) 
			{
				Dir4 = true;
				//Debug.Log("Turn now 0");
				gameObject.transform.eulerAngles = new Vector3 (0, 0, 0);
				Dir2 = false;
			}
		}
	}
}