using UnityEngine;
using System.Collections;

public class BlueEnemies : MonoBehaviour {

	private float elapsedTime = 5.0f;
	private string[] animations = {"Take 001"};


	// Update is called once per frame
	void Update () 
	{
		elapsedTime -= Time.deltaTime;
		if (elapsedTime < 0) 
		{
			elapsedTime = 5.0f;
			GetComponent<Animation>().Play(animations[0]);

		}
	}
}
