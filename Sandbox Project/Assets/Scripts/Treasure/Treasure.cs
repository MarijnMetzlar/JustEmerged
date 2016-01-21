using UnityEngine;
using System.Collections;

public class Treasure : MonoBehaviour {

	public Transform collectablePoint;
	public static Vector3 thisChest;

	void OnTriggerEnter (Collider other) 
	{
		thisChest = gameObject.GetComponent<Transform>().position;

		if (other.gameObject.tag == "Player") 
		{
			Destroy(gameObject);
			Instantiate(collectablePoint, new Vector3 (thisChest.x, thisChest.y + 1.0f, thisChest.z), Quaternion.identity);
		}
	}
}
