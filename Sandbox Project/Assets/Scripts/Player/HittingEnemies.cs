using UnityEngine;
using System.Collections;

public class HittingEnemies : MonoBehaviour {

    public int enemyType = 0;
    private int gunDamage;
    private StatsEnemy stats;

    public float healthPoints;
    public float damagePoints;
    public float moveSpeed;
    public float attackRange;
    public float followRange;
    public float attackSpeed;

    // Use this for initialization
    void Start () {
        stats = GetComponent<StatsEnemy>();

        if (enemyType == 0)
        {
            healthPoints = stats.hpEnemy1;
            damagePoints = stats.dmgEnemy1;
            moveSpeed = stats.spdEnemy1;
            attackRange = stats.attrEnemy1;
            followRange = stats.flwEnemy1;
            attackSpeed = stats.aspEnemy1;
        }
        else if (enemyType == 1)
        {
            healthPoints = stats.hpEnemy2;
            damagePoints = stats.dmgEnemy2;
            moveSpeed = stats.spdEnemy2;
            attackRange = stats.attrEnemy2;
            followRange = stats.flwEnemy2;
            attackSpeed = stats.aspEnemy2;
        }
        else if (enemyType == 2)
        {
            healthPoints = stats.hpEnemy3;
            damagePoints = stats.dmgEnemy3;
            moveSpeed = stats.spdEnemy3;
            attackRange = stats.attrEnemy3;
            followRange = stats.flwEnemy3;
            attackSpeed = stats.aspEnemy3;
        }


        gunDamage = GameObject.Find("Car").GetComponent<MoveCar>().gunDamage;
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
