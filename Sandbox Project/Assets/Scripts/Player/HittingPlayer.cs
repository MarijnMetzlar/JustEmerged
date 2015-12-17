using UnityEngine;
using System.Collections;

public class HittingPlayer : MonoBehaviour {

    public float healthPoints;
    private MoveCar carHP;
    private float damage = 2;

	// Use this for initialization
	void Start () {
        healthPoints = GetComponent<MoveCar>().carHP;
	}

    void OnParticleCollision()
    {
        healthPoints = healthPoints - damage;
    }

    // Update is called once per frame
    void Update () {
        if (healthPoints <= 0)
        {
            Destroy(this.gameObject);
        }
        //Debug.Log(healthPoints);
    }
}
