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
		if (other.gameObject.tag == "MetalRocket") 
		{
			healthPoints = healthPoints - 2;
			Destroy(other.gameObject);

		}
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
