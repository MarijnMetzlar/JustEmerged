using UnityEngine;
using System.Collections;

public class CollectablePoint : MonoBehaviour {

	private float poof = 250.0f;
	public MoveCar car;

	void Start ()
	{
		gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * poof);
		car = GameObject.Find ("car").GetComponent<MoveCar>();
	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < Treasure.thisChest.y) 
		{
			GetComponent<Rigidbody>().isKinematic = true;
			GetComponent<Rigidbody>().useGravity = false;
			RotateCollectable ();
		}
	}

	void RotateCollectable()
	{
		gameObject.GetComponent<Transform> ().Rotate (Vector3.right + Vector3.up * 5);
	}

	void OnTriggerEnter ()
	{
		Destroy (gameObject);
		car.upgradePoints += 1;
	}
}
