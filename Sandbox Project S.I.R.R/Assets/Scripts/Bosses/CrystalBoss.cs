using UnityEngine;
using System.Collections;

public class CrystalBoss : MonoBehaviour {

	public float targetDistance;
	public float enemyLookDistance;
	public float attackDistance;
	public float damping;

	public float spawnDistance;
	public float enemyHeight;

	public Vector3 crystalBossPosition;
	public Transform snakePrefab;

	public Transform spikePrefab;

	public float throwTimer = 5.0f;
	private float spawnEnemies = 10.0f;

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
			Attack ();

			spawnEnemies -= Time.deltaTime;
			if(spawnEnemies < 0)
			{
				SpawnEnemies ();
				spawnEnemies = 10.0f;
			}

		} 
	}

	void LookAtPlayer ()
	{
		Quaternion rotation = Quaternion.LookRotation (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}

	void Attack ()
	{
		throwTimer -= Time.deltaTime;
		if (throwTimer < 2.0f) 
		{
			soundEffect += 1;
			//play animation I guess
		}
		
		if (soundEffect == 1) 
		{
			evilLaugh.Play();
		}
		
		if (throwTimer < 0) 
		{
			ThrowSpike ();
			throwTimer = 5.0f;
			soundEffect = 0;
		}
	}

	void ThrowSpike ()
	{
		Vector3 enemyPosition = transform.position + (transform.forward * spawnDistance) + (transform.up * enemyHeight);
		Instantiate(spikePrefab, enemyPosition, transform.rotation);
	}

	void SpawnEnemies()
	{
		crystalBossPosition = GameObject.FindGameObjectWithTag ("CrystalBoss").GetComponent<Transform> ().position;
		
		Instantiate (snakePrefab, new Vector3 (crystalBossPosition.x + 30.0f, crystalBossPosition.y + 2.0f, crystalBossPosition.z), Quaternion.identity);
		Instantiate (snakePrefab, new Vector3 (crystalBossPosition.x - 30.0f, crystalBossPosition.y + 2.0f, crystalBossPosition.z), Quaternion.identity);
		Instantiate (snakePrefab, new Vector3 (crystalBossPosition.x, crystalBossPosition.y + 2.0f, crystalBossPosition.z + 30.0f), Quaternion.identity);
	}
}
