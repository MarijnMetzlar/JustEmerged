﻿using UnityEngine;
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
	[Header("MiniSlime")]
    public float hpMiniSlime = 5;
    public float dmgMiniSlime = 1;
    
	[Header("SlimeBoss")]
	public float hpSlimeBoss = 100;
	public float dmgPhysicalSlimeBoss = 3;
	public float dmgRangeSlimeBoss = 1;
}
