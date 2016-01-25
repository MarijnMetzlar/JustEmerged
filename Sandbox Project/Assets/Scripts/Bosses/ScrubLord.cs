using UnityEngine;
using System.Collections;

public class ScrubLord : MonoBehaviour {
	
	public float targetDistance;
	public float enemyLookDistance;
	public float attackDistance;
	public float damping;
	private float enemyMovementSpeed = 17.5f;
	
	public float spawnDistance;
	public float enemyHeight;
	
	private float throwTimer = 10.0f;
	private float goBackTimer = 1.0f;
	
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
		if (targetDistance < 2.0f) 
		{
			enemyMovementSpeed = -17.5f;

			goBackTimer -= Time.deltaTime;
			if(goBackTimer < 0)
			{
				enemyMovementSpeed = 17.5f;
				goBackTimer = 1.0f;
			}
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
			if (gameObject.transform.position.z > (obeliskPosition.z - 160.0f) && Dir1 == false) 
			{
				Dir1 = true;
				//Debug.Log("Turn now 90");
				gameObject.transform.eulerAngles = new Vector3 (0, 90, 0);
				Dir3 = false;
			}
		
			if (gameObject.transform.position.x > (obeliskPosition.x - 181.0f) && Dir2 == false) 
			{
				Dir2 = true;
				//Debug.Log("Turn now 180");
				gameObject.transform.eulerAngles = new Vector3 (0, 180, 0);
				Dir4 = false;
			} 
			else if (gameObject.transform.position.z < (obeliskPosition.z - 210.0f) && Dir3 == false) 
			{
				Dir3 = true;
				//Debug.Log("Turn now 270");
				gameObject.transform.eulerAngles = new Vector3 (0, 270, 0);
				Dir1 = false;
			} 
			else if (gameObject.transform.position.x < (obeliskPosition.x - 240.0f) && Dir4 == false) 
			{
				Dir4 = true;
				//Debug.Log("Turn now 0");
				gameObject.transform.eulerAngles = new Vector3 (0, 0, 0);
				Dir2 = false;
			}
		}

		if (miniBossType == 1) 
		{
			if (gameObject.transform.position.z > (obeliskPosition.z - 283.0f) && Dir1 == false) 
			{
				Dir1 = true;
				//Debug.Log("Turn now 90");
				gameObject.transform.eulerAngles = new Vector3 (0, 90, 0);
				Dir3 = false;
			}
			if (gameObject.transform.position.x > (obeliskPosition.x + 42.0f) && Dir2 == false) 
			{
				Dir2 = true;
				//Debug.Log("Turn now 180");
				gameObject.transform.eulerAngles = new Vector3 (0, 180, 0);
				Dir4 = false;
			} 
			else if (gameObject.transform.position.z < (obeliskPosition.z - 344.0f) && Dir3 == false) 
			{
				Dir3 = true;
				//Debug.Log("Turn now 270");
				gameObject.transform.eulerAngles = new Vector3 (0, 270, 0);
				Dir1 = false;
			} 
			else if (gameObject.transform.position.x < (obeliskPosition.x - 27.0f) && Dir4 == false) 
			{
				Dir4 = true;
				//Debug.Log("Turn now 0");
				gameObject.transform.eulerAngles = new Vector3 (0, 0, 0);
				Dir2 = false;
			}
		}

		if (miniBossType == 2) 
		{
			if (gameObject.transform.position.z > (obeliskPosition.z + 258.0f) && Dir1 == false) 
			{
				Dir1 = true;
				//Debug.Log("Turn now 90");
				gameObject.transform.eulerAngles = new Vector3 (0, 90, 0);
				Dir3 = false;
			}
			if (gameObject.transform.position.x > (obeliskPosition.x - 196.0f) && Dir2 == false) 
			{
				Dir2 = true;
				//Debug.Log("Turn now 180");
				gameObject.transform.eulerAngles = new Vector3 (0, 180, 0);
				Dir4 = false;
			} 
			else if (gameObject.transform.position.z < (obeliskPosition.z + 206.0f) && Dir3 == false) 
			{
				Dir3 = true;
				//Debug.Log("Turn now 270");
				gameObject.transform.eulerAngles = new Vector3 (0, 270, 0);
				Dir1 = false;
			} 
			else if (gameObject.transform.position.x < (obeliskPosition.x - 260.0f) && Dir4 == false) 
			{
				Dir4 = true;
				//Debug.Log("Turn now 0");
				gameObject.transform.eulerAngles = new Vector3 (0, 0, 0);
				Dir2 = false;
			}
		}
	}
}