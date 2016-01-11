using UnityEngine;
using System.Collections;

public class StatsEnemy : MonoBehaviour {

	[Header("Car")]
	public float hpCar = 10;

	[Header("MiniSlime")]
    public float hpMiniSlime = 5;
    public float dmgMiniSlime = 1;
    

	[Header("SlimeBoss")]
	public float hpSlimeBoss = 100;
	public float dmgPhysicalSlimeBoss = 3;
	public float dmgRangeSlimeBoss = 1;

	[Header("MetalEnemy")]
	public float hpMetalEnemy = 10;
	public float dmgPhysicalMetalEnemy = 2;
	public float dmgRangeMetalEnemy = 2;
}
