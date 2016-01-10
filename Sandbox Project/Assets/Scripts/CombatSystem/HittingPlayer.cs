using UnityEngine;
using System.Collections;

public class HittingPlayer : MonoBehaviour {

    public float healthPoints;
    private MoveCar carHP;
    private StatsEnemy damage;
	private float damageAtt1;
	private float damageAtt2;

	// Use this for initialization
	void Start () 
	{
        healthPoints = GetComponent<MoveCar>().carHP;
		damageAtt1 = GetComponent<StatsEnemy>().dmgPhysicalSlimeBoss;
		damageAtt2 = GetComponent<StatsEnemy>().dmgRangeSlimeBoss;

	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("ouch");
		healthPoints = healthPoints - damageAtt1;
	}

    void OnParticleCollision()
    {
        healthPoints = healthPoints - damageAtt2;
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
