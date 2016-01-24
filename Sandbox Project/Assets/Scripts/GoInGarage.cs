using UnityEngine;
using System.Collections;

public class GoInGarage : MonoBehaviour {

	void Update()
	{
		gameObject.GetComponent<Transform> ().Rotate (Vector3.right + Vector3.up * 3);
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			//Debug.Log("hi");
			//GameObject.Find("car").GetComponent<MakingCar>().SendMessage("EnterGarage");
		}
	}
}
