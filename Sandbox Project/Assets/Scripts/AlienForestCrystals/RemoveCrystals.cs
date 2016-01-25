using UnityEngine;
using System.Collections;

public class RemoveCrystals : MonoBehaviour {

	private ScrubLord scrubScript;

	private int Type1;
	private int Type2;
	private int Type3;

	void Start()
	{
		scrubScript = GameObject.Find ("ScrubLord").GetComponent<ScrubLord> ();
		scrubScript = GameObject.Find ("ScrubLord2").GetComponent<ScrubLord> ();
		scrubScript = GameObject.Find ("ScrubLord3").GetComponent<ScrubLord> ();
		Type1 = scrubScript.miniBossType;
		Type2 = scrubScript.miniBossType;
		Type3 = scrubScript.miniBossType;

	}
	// Update is called once per frame
	void Update () 
	{
		if (HittingEnemies.MiniBossKills == 0) 
		{
			gameObject.GetComponent<Transform>().position -= new Vector3 (0, 0.05f, 0);
		}

		if (gameObject.transform.position.y < 30.0f) 
		{
			Destroy(gameObject);
		}
	}
}
