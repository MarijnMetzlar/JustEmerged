using UnityEngine;
using System.Collections;

public class MetalBullet : MonoBehaviour {

	private float speed = 10.0f;
	private float elapsedTime = 0.0f;

	// Update is called once per frame
	void Update () 
	{
		elapsedTime += Time.deltaTime;
		transform.Translate (Vector3.forward * speed * Time.deltaTime);

		Vector3 playerPosition = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ().position;
		gameObject.transform.LookAt (playerPosition);

		if (elapsedTime >= 5.0f) 
		{
			Destroy(gameObject);
			elapsedTime = 0.0f;
		}
	}
}
