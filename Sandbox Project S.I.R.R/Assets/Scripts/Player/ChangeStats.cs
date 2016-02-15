using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeStats : MonoBehaviour {

    private MoveCar carStats;
    private int upgradeAmount;
    private int speedUpgrade;
    private int accelerationUpgrade;
    private int damageUpgrade;
    private int hpUpgrade;
    private int boosterUpgrade;
    private int upgradeStat;

    private Image upgrade1;
    private Image upgrade2;
    private Image upgrade3;
    private Image upgrade4;
    private Image upgrade5;

    private Text whatUpgrading;
    private Text upPoints;

    // Use this for initialization
    void Start () {
        carStats = GameObject.Find("car").GetComponent<MoveCar>();

        whatUpgrading = GameObject.Find("What Upgrading").GetComponent<Text>();
        upPoints = GameObject.Find("Upgrade Points").GetComponent<Text>();
        upgrade1 = GameObject.Find("Upgrade Circle 1").GetComponent<Image>();
        upgrade2 = GameObject.Find("Upgrade Circle 2").GetComponent<Image>();
        upgrade3 = GameObject.Find("Upgrade Circle 3").GetComponent<Image>();
        upgrade4 = GameObject.Find("Upgrade Circle 4").GetComponent<Image>();
        upgrade5 = GameObject.Find("Upgrade Circle 5").GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
	    if (upgradeAmount == 0)
        {
            upgrade1.enabled = false;
            upgrade2.enabled = false;
            upgrade3.enabled = false;
            upgrade4.enabled = false;
            upgrade5.enabled = false;
        }
        else if (upgradeAmount == 1)
        {
            upgrade1.enabled = true;
            upgrade2.enabled = false;
            upgrade3.enabled = false;
            upgrade4.enabled = false;
            upgrade5.enabled = false;
        }
        else if (upgradeAmount == 2)
        {
            upgrade1.enabled = true;
            upgrade2.enabled = true;
            upgrade3.enabled = false;
            upgrade4.enabled = false;
            upgrade5.enabled = false;
        }
        else if (upgradeAmount == 3)
        {
            upgrade1.enabled = true;
            upgrade2.enabled = true;
            upgrade3.enabled = true;
            upgrade4.enabled = false;
            upgrade5.enabled = false;
        }
        else if (upgradeAmount == 4)
        {
            upgrade1.enabled = true;
            upgrade2.enabled = true;
            upgrade3.enabled = true;
            upgrade4.enabled = true;
            upgrade5.enabled = false;
        }
        else if (upgradeAmount == 5)
        {
            upgrade1.enabled = true;
            upgrade2.enabled = true;
            upgrade3.enabled = true;
            upgrade4.enabled = true;
            upgrade5.enabled = true;
        }
        upPoints.text = "Upgrading: " + carStats.upgradePoints;
    }

    public void UpgradeSpeed()
    {
        upgradeAmount = speedUpgrade;
        upgradeStat = 0;
        whatUpgrading.text = "Speed";
    }
    public void UpgradeAcceleration()
    {
        upgradeAmount = accelerationUpgrade;
        upgradeStat = 1;
        whatUpgrading.text = "Acceleration";
    }
    public void UpgradeDamage()
    {
        upgradeAmount = damageUpgrade;
        upgradeStat = 2;
        whatUpgrading.text = "Damage";
    }
    public void UpgradeHp()
    {
        upgradeAmount = hpUpgrade;
        upgradeStat = 3;
        whatUpgrading.text = "Hp";
    }

    public void upgradeBooster()
    {
        upgradeAmount = boosterUpgrade;
        upgradeStat = 4;
        whatUpgrading.text = "Booster";
    }

    public void UpgradeStat()
    {
        if (upgradeStat == 0)
        {
            if (upgradeAmount < 5 && carStats.upgradePoints > 0)
            {
                speedUpgrade += 1;
                upgradeAmount += 1;
                carStats.speedMultiplier += 1;
                carStats.upgradePoints -= 1;
            }
        }
        else if (upgradeStat == 1)
        {
            if (upgradeAmount < 5 && carStats.upgradePoints > 0)
            {
                accelerationUpgrade += 1;
                upgradeAmount += 1;
                carStats.accelerationMultiplier += 1;
                carStats.upgradePoints -= 1;
            }
        }
        else if (upgradeStat == 2)
        {
            if (upgradeAmount < 5 && carStats.upgradePoints > 0)
            {
                damageUpgrade += 1;
                upgradeAmount += 1;
                carStats.damageMultiplier += 1;
                carStats.upgradePoints -= 1;
            }
        }
        else if (upgradeStat == 3)
        {
            if (upgradeAmount < 5 && carStats.upgradePoints > 0)
            {
                hpUpgrade += 1;
                upgradeAmount += 1;
                carStats.hpMultiplier += 1;
                carStats.upgradePoints -= 1;
            } 
        }
        else if (upgradeStat == 4)
        {
            if (upgradeAmount < 5 && carStats.upgradePoints > 0)
            {
                boosterUpgrade += 1;
                upgradeAmount += 1;
                carStats.boosterDecreaser += 0.2f;
                carStats.boosterIncreaser += 0.5f;
                carStats.upgradePoints -= 1;
            }
        }
    }
    public void DowngradeStat()
    {
        if (upgradeStat == 0)
        {
            if (upgradeAmount > 0)
            {
                speedUpgrade -= 1;
                upgradeAmount -= 1;
                carStats.speedMultiplier -= 1;
                carStats.upgradePoints += 1;
            }
        }
        else if (upgradeStat == 1)
        {
            if (upgradeAmount > 0)
            {
                accelerationUpgrade -= 1;
                upgradeAmount -= 1;
                carStats.accelerationMultiplier -= 1;
                carStats.upgradePoints += 1;
            }
        }
        else if (upgradeStat == 2)
        {
            if (upgradeAmount > 0)
            {
                damageUpgrade -= 1;
                upgradeAmount -= 1;
                carStats.damageMultiplier -= 1;
                carStats.upgradePoints += 1;
            }
        }
        else if (upgradeStat == 3)
        {
            if (upgradeAmount > 0)
            {
                hpUpgrade -= 1;
                upgradeAmount -= 1;
                carStats.hpMultiplier -= 1;
                carStats.upgradePoints += 1;
            }
        }
        else if (upgradeStat == 4)
        {
            if (upgradeAmount < 5 && carStats.upgradePoints > 0)
            {
                boosterUpgrade -= 1;
                upgradeAmount -= 1;
                carStats.boosterDecreaser -= 0.2f;
                carStats.boosterIncreaser -= 0.5f;
                carStats.upgradePoints += 1;
            }
        }
    }
}
