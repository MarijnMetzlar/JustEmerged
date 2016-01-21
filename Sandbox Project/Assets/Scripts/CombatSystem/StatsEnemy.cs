using UnityEngine;
using System.Collections;

public class StatsEnemy : MonoBehaviour {

	[Header("SlimeEnemy")]
	public float hpSlimeEnemy = 10;
	public float dmgPhysicalSlimeEnemy = 2;

	[Header("MetalEnemy")]
	public float hpMetalEnemy = 10;
	public float dmgPhysicalMetalEnemy = 2;
	public float dmgRangeMetalEnemy = 2;

	//bosses and enemies from that spawns through boss battles
	[Header("AncientTreeBoss")]
	public float hpAncientTreeBoss = 300;
	public float dmgAncientTreeBoss = 2;

	[Header("MiniSlime")]
    public float hpMiniSlime = 5;
    public float dmgMiniSlime = 1;
    
	[Header("SlimeBoss")]
	public float hpSlimeBoss = 300;
	public float dmgPhysicalSlimeBoss = 3;
	public float dmgRangeSlimeBoss = 1;

	[Header("ScrubLord")]
	public float hpScrubLord = 70;
	public float dmgPhysicalScrubLord = 3;
	public float dmgRangeScrubLord = 4;
}
