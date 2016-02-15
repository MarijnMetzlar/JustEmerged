using UnityEngine;
using System.Collections;

public class HittingPlayer : MonoBehaviour {

    public float healthPoints;
    private MoveCar carHP;
    private StatsEnemy damage;
	private float damageAtt2;

	// Use this for initialization
	void Start () 
	{
		healthPoints = GameObject.Find("car").GetComponent<MoveCar>().carHP;
		damageAtt2 = GetComponent<StatsEnemy>().dmgRangeSlimeBoss;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "SlimeEnemy") 
		{
			carHP.carHP = carHP.carHP - 2;
		}

		if (other.gameObject.tag == "MetalEnemy") 
		{
            carHP.carHP = carHP.carHP - 2;
		}

		if (other.gameObject.tag == "Snake") 
		{
            carHP.carHP = carHP.carHP - 1;
		}

		if (other.gameObject.tag == "MetalRocket") 
		{
            carHP.carHP = carHP.carHP - 2;
			Destroy(other.gameObject);
		}

		if (other.gameObject.tag == "MiniSlime") 
		{
            carHP.carHP = carHP.carHP - 1;
		}

		if (other.gameObject.tag == "SlimeBoss") 
		{
            carHP.carHP = carHP.carHP - 3;
		}

		if (other.gameObject.tag == "PoolOfDeath") 
		{
            carHP.carHP = carHP.carHP - 0.5f;
		}

		if (other.gameObject.tag == "Spike") 
		{
            carHP.carHP = carHP.carHP - 3;
			Destroy(other.gameObject);
		}

		if (other.gameObject.tag == "ScrubLord") 
		{
            carHP.carHP = carHP.carHP - 2;
		}
	}

    void OnParticleCollision()
    {
        carHP.carHP = carHP.carHP - damageAtt2;
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(healthPoints);
    }
}
