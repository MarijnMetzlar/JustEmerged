using UnityEngine;
using System.Collections;

public class PoolOfDeath : MonoBehaviour {
	
	private float HitTimer = 1.5f;
	private float DestroyTimer = 30.0f;

	// Update is called once per frame
	void Update () 
	{
		HitTimer -= Time.deltaTime;
		if (HitTimer < 0) 
		{
			gameObject.GetComponent<BoxCollider>().enabled = true;
		}

		DestroyTimer -= Time.deltaTime;
		if (DestroyTimer < 0) 
		{
			Destroy(gameObject);
		}

	}
}
