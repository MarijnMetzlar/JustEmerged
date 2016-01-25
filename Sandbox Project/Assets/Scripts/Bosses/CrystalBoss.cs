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

	private float throwTimer = 5.0f;

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
			Attack ();
		}
	}

	void LookAtPlayer ()
	{
		Quaternion rotation = Quaternion.LookRotation (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}

	void WalkingPattern ()
	{
		//ok
	}

	void Attack ()
	{
		throwTimer -= Time.deltaTime;
		if (throwTimer < 2.0f) 
		{
			soundEffect += 1;
			//play animation I guess
			enemyMovementSpeed = 0;
		}
		
		if (soundEffect == 1) 
		{
			evilLaugh.Play();
		}
		
		if (throwTimer < 0) 
		{
			ThrowSpike ();
			throwTimer = 5.0f;
			enemyMovementSpeed = 10;
			soundEffect = 0;
		}
	}

	void ThrowSpike ()
	{
		Vector3 enemyPosition = transform.position + (transform.forward * spawnDistance) + (transform.up * enemyHeight);
		Instantiate(spikePrefab, new Vector3(enemyPosition.x + 5.0f, enemyPosition.y, enemyPosition.z), transform.rotation);
		Instantiate(spikePrefab, new Vector3(enemyPosition.x, enemyPosition.y, enemyPosition.z), transform.rotation);
		Instantiate(spikePrefab, new Vector3(enemyPosition.x - 5.0f, enemyPosition.y, enemyPosition.z), transform.rotation);
	}
}
