using UnityEngine;
using System.Collections;

public class HittingEnemies : MonoBehaviour {

    public int enemyType = 0;
    private int gunDamage;
    private StatsEnemy stats;

    public float healthPoints;
    public float damagePoints;

    // Use this for initialization
    void Start () {
        stats = GetComponent<StatsEnemy>();

        if (enemyType == 0)
        {
            healthPoints = stats.hpMiniSlime;
            damagePoints = stats.dmgMiniSlime;
        }

		else if (enemyType == 1)
		{
			healthPoints = stats.hpSlimeBoss;
			damagePoints = stats.dmgPhysicalSlimeBoss;
			damagePoints = stats.dmgRangeSlimeBoss;
		}

		else if (enemyType == 2)
		{
			healthPoints = stats.hpMetalEnemy;
			damagePoints = stats.dmgPhysicalMetalEnemy;
		}

        gunDamage = GameObject.Find("car").GetComponent<MoveCar>().gunDamage;
    }

    void OnParticleCollision ()
    {
        healthPoints = healthPoints - gunDamage;
    }
	
	// Update is called once per frame
	void Update () {
	    if (healthPoints <= 0)
        {
            Destroy(this.gameObject);
        }
	}
}
