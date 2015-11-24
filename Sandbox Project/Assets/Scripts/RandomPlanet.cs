using UnityEngine;
using System.Collections;

public class RandomPlanet : MonoBehaviour {

	public Transform[] upperRealmPrefabs;
	public int planetGenerator;

	// Use this for initialization
	void Start () 
	{
		planetGenerator = Random.Range (1, 24);

		if (planetGenerator == 1) 
		{
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}

		else if (planetGenerator == 2) 
		{
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}

		else if (planetGenerator == 3) 
		{
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}

		else if (planetGenerator == 4) 
		{
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}

		else if (planetGenerator == 5) 
		{
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}

		else if (planetGenerator == 6) 
		{
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}

		else if (planetGenerator == 7) 
		{
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 8) 
		{
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 9) 
		{
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 10) 
		{
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 11) 
		{
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 12) 
		{
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}

		else if (planetGenerator == 13) 
		{
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 14) 
		{
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 15) 
		{
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 16) 
		{
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 17) 
		{
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 18) 
		{
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}

		else if (planetGenerator == 19) 
		{
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 20) 
		{
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 21) 
		{
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 22) 
		{
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 23) 
		{
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
		
		else if (planetGenerator == 24) 
		{
			Instantiate (upperRealmPrefabs [3], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (270, 0, 0));
			Instantiate (upperRealmPrefabs [2], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (270, 180, 0));
			Instantiate (upperRealmPrefabs [1], new Vector3 (0.3f, -136.7f, -171.9f), Quaternion.Euler (90, 0, 0));
			Instantiate (upperRealmPrefabs [0], new Vector3 (0.3f, -136.7f, 167.8f), Quaternion.Euler (90, 180, 0));
		}
	}
}
