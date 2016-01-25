using UnityEngine;
using System.Collections;

public class CrystalBoss : MonoBehaviour {

	public float targetDistance;
	public float enemyLookDistance;
	public float attackDistance;
	public float damping;
	private float enemyMovementSpeed = 17.5f;

	public float spawnDistance;
	public float enemyHeight;

	private Vector3 pointA;
	private Vector3 pointB;

	public Transform spikePrefab;

	private int soundEffect;
	public AudioSource evilLaugh;


	void Start ()
	{
		GameObject _Spike = GameObject.FindGameObjectWithTag ("Spike");
		Physics.IgnoreCollision(_Spike.GetComponent<Collider>(), GetComponent<Collider>());
	}
	
	// Update is called once per frame
	void Update () 
	{
		targetDistance = Vector3.Distance (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position, transform.position);
		
		if (targetDistance < enemyLookDistance) 
		{
			LookAtPlayer ();
			WalkingPattern ();
		}
	}

	void LookAtPlayer ()
	{
		Quaternion rotation = Quaternion.LookRotation (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}

	void WalkingPattern ()
	{
		pointA = new Vector3 (182.8f, 60.11f, 203.38f);
		pointB = new Vector3 (102.1f, 60.11f, 318.28f);
		transform.position = Vector3.Lerp (pointA, pointB);
	}
}
