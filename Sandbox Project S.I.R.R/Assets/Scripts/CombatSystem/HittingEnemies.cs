using UnityEngine;
using System.Collections;

public class HittingEnemies : MonoBehaviour {

    public int enemyType = 0;
    private int gunDamage;
    private StatsEnemy stats;

    public float healthPoints;
    public float damagePoints;

	public static int MiniBossKills = 3;

    // Use this for initialization
    void Start () {
        stats = GetComponent<StatsEnemy>();

        if (enemyType == 0) 
		{												//Metal Enemy
			healthPoints = stats.hpMetalEnemy;
			damagePoints = stats.dmgPhysicalMetalEnemy;
		} 
		else if (enemyType == 1) 
		{						    					//Slime Enemy
			healthPoints = stats.hpSlimeEnemy;
			damagePoints = stats.dmgPhysicalSlimeEnemy;
		} 
		else if (enemyType == 2)
		{												//Mini Slime
			healthPoints = stats.hpMiniSlime;
			damagePoints = stats.dmgMiniSlime;
		} 

		else if (enemyType == 7)
		{												//Snake
			healthPoints = stats.hpSnake;
		} 

		else if (enemyType == 3) 
		{												//Slime Boss
			healthPoints = stats.hpSlimeBoss;
			damagePoints = stats.dmgPhysicalSlimeBoss;
			damagePoints = stats.dmgRangeSlimeBoss;
		} 
		else if (enemyType == 4)
		{												//Ancient Tree Boss
			healthPoints = stats.hpAncientTreeBoss;
			damagePoints = stats.dmgAncientTreeBoss;
		} 
		else if (enemyType == 5) 
		{												//Scrub Lord
			healthPoints = stats.hpScrubLord;
			damagePoints = stats.dmgPhysicalScrubLord;
		}

		else if (enemyType == 6) 
		{												//Crystal Boss
			healthPoints = stats.hpCrystalEnemy;
		}


        gunDamage = GameObject.Find("car").GetComponent<MoveCar>().gunDamage;
    }

    void OnParticleCollision ()
    {
        healthPoints = healthPoints - gunDamage;
    }
	
	// Update is called once per frame
	void Update () 
	{
	    if (healthPoints <= 0)
        {
            Destroy(this.gameObject);
        }

		if(enemyType == 5 && healthPoints <= 0)
		{
			MiniBossKills -= 1;
			//camera change?
		}
	}
}
