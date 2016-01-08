using UnityEngine;
using System.Collections;

public class Blob : MonoBehaviour {

	private float speed = 20.0f;
	private float lookAtTimer = 0.0f;

	// Update is called once per frame
	void Update () 
	{
		Vector3 playerPosition = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ().position;
		
		lookAtTimer += Time.deltaTime;
		if (lookAtTimer <= 2.0f) 
		{
			gameObject.transform.LookAt (playerPosition);
		}

		else if (lookAtTimer > 2.0f)
		{
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
		}
	}

	void OnTriggerEnter()
	{
		
	}
}

	//private float blobTowardsEnemy = 0.0f;

//		blobTowardsEnemy += Time.deltaTime;
//		if (blobTowardsEnemy >= 1.5f) 
//		{
//			gameObject.transform.eulerAngles += new Vector3(20.0f, 0.0f, 0.0f);
//			blobTowardsEnemy = 0.0f;
//		}