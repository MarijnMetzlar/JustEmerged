using UnityEngine;
using System.Collections;

public class SlimeBoss : MonoBehaviour {
	
	public float targetDistance;
	public float enemyMovementSpeed;
	public float jumpSpeed;
	public float damping;

	public float enemyHeight;
	public float shootDistance;

	private float jumpTimer = 0.0f;
	private float shootTimer = 0.0f;
	private float testTimer = 0.0f;

	public GameObject target;
	public Transform slimeRocketPrefab;
	public Transform slimePrefab;

	public Vector3 slimeBossPosition;

	void Update () 
	{
		targetDistance = Vector3.Distance (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position, transform.position);
		
		LookAtPlayer ();
		Jump ();

		//if the boss got hit multiple times create mini slimes
		testTimer += Time.deltaTime;
		if (testTimer >= 10.0f) 
		{
			GotDamaged ();
			testTimer = 0.0f;
		}

		if (gameObject.transform.position.y < 10.0f) 
		{
			transform.Translate(0.0f, 40.0f, 0.0f);
		}
	}
	
	void LookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>().position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);

		//Vector3 playerPosition = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ().position;
		//gameObject.transform.LookAt (playerPosition);
	}
	
	void Jump()
	{
		jumpTimer += Time.deltaTime;

		if (jumpTimer >= 3.5f) 
		{
			gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpSpeed);

			jumpTimer = 0.0f;
		}

		if (gameObject.transform.position.y > 45.0f) {
			transform.Translate (Vector3.forward * enemyMovementSpeed * Time.deltaTime);
		} 
	}

	void GotDamaged()
	{
		slimeBossPosition = GameObject.FindGameObjectWithTag ("SlimeBoss").GetComponent<Transform> ().position;

		Instantiate (slimePrefab, new Vector3 (slimeBossPosition.x + 30.0f, slimeBossPosition.y + 2.0f, slimeBossPosition.z), Quaternion.identity);
		Instantiate (slimePrefab, new Vector3 (slimeBossPosition.x - 30.0f, slimeBossPosition.y + 2.0f, slimeBossPosition.z), Quaternion.identity);
		Instantiate (slimePrefab, new Vector3 (slimeBossPosition.x, slimeBossPosition.y + 2.0f, slimeBossPosition.z + 30.0f), Quaternion.identity);
	}
}
