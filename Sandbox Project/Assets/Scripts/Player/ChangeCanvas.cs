using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeCanvas : MonoBehaviour {

    private Image imageChassy1;
    private Image imageChassy2;
    private Image imageChassy3;
    private Image imageWheels1;
    private Image imageWheels2;
    private Image imageTurret1;
    private Image imageTurret2;
    private Image imageTurret3;
    private Image imageTurret4;
    private Image imageAbility1;
    private Image imageAbility2;
    private Image imageAbility3;
    private Image imageAbility4;

    private MoveCar carHP;
    private float halfMaxHealth;
    private int something;
    private float damage;

    // Use this for initialization
    void Start () {
        imageChassy1 = GameObject.Find("Chassy Small UI").GetComponent<Image>();
        imageChassy2 = GameObject.Find("Chassy Medium UI").GetComponent<Image>();
        imageChassy3 = GameObject.Find("Chassy Large UI").GetComponent<Image>();
        imageWheels1 = GameObject.Find("Wheel Type 1 UI").GetComponent<Image>();
        imageWheels2 = GameObject.Find("Wheel Type 2 UI").GetComponent<Image>();
        imageTurret1 = GameObject.Find("Turret Mini UI").GetComponent<Image>();
        imageTurret2 = GameObject.Find("Turret Twin UI").GetComponent<Image>();
        imageTurret3 = GameObject.Find("Turret Rail UI").GetComponent<Image>();
        imageTurret4 = GameObject.Find("Turret Bazooka UI").GetComponent<Image>();
        imageAbility1 = GameObject.Find("Ability Dash UI").GetComponent<Image>();
        imageAbility2 = GameObject.Find("Ability Repair UI").GetComponent<Image>();
        imageAbility3 = GameObject.Find("Ability Spring UI").GetComponent<Image>();
        imageAbility4 = GameObject.Find("Ability Shield UI").GetComponent<Image>();

        carHP = GameObject.Find("car").GetComponent<MoveCar>();
        halfMaxHealth = carHP.carHP;
        something = (int)Math.Round(255 / carHP.carHP);
    }

    void ChangeColor()
    {
        if(carHP.carHP != halfMaxHealth)
        {
            imageChassy1.color = new Color(something * damage / 255, something * carHP.carHP / 255,0);
            imageChassy2.color = new Color(something * damage / 255, something * carHP.carHP / 255, 0);
            imageChassy3.color = new Color(something * damage / 255, something * carHP.carHP / 255, 0);
            halfMaxHealth = carHP.carHP;
        }
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.K))
        {
            carHP.carHP -= 2;
            damage += 2;
        }
        ChangeColor();
    }

    public void UpdateCanvas (int chassys, int wheels, int turret, int abilitys)
    {
        if (chassys == 0)
        {
            imageChassy1.enabled = true;
            imageChassy2.enabled = false;
            imageChassy3.enabled = false;
        }
        else if (chassys == 1)
        {
            imageChassy1.enabled = false;
            imageChassy2.enabled = true;
            imageChassy3.enabled = false;
        }
        else if (chassys == 2)
        {
            imageChassy1.enabled = false;
            imageChassy2.enabled = false;
            imageChassy3.enabled = true;
        }
        if (wheels == 0)
        {
            imageWheels1.enabled = true;
            imageWheels2.enabled = false;
        }
        else if (wheels == 1)
        {
            imageWheels1.enabled = false;
            imageWheels2.enabled = true;
        }
        if (turret == 0)
        {
            imageTurret1.enabled = true;
            imageTurret2.enabled = false;
            imageTurret3.enabled = false;
            imageTurret4.enabled = false;
        }
        else if (turret == 1)
        {
            imageTurret1.enabled = false;
            imageTurret2.enabled = true;
            imageTurret3.enabled = false;
            imageTurret4.enabled = false;
        }
        else if (turret == 2)
        {
            imageTurret1.enabled = false;
            imageTurret2.enabled = false;
            imageTurret3.enabled = true;
            imageTurret4.enabled = false;
        }
        else if (turret == 3)
        {
            imageTurret1.enabled = false;
            imageTurret2.enabled = false;
            imageTurret3.enabled = false;
            imageTurret4.enabled = true;
        }
        if (abilitys == 0)
        {
            imageAbility1.enabled = true;
            imageAbility2.enabled = false;
            imageAbility3.enabled = false;
            imageAbility4.enabled = false;
        }
        else if (abilitys == 1)
        {
            imageAbility1.enabled = false;
            imageAbility2.enabled = true;
            imageAbility3.enabled = false;
            imageAbility4.enabled = false;
        }
        else if (abilitys == 2)
        {
            imageAbility1.enabled = false;
            imageAbility2.enabled = false;
            imageAbility3.enabled = true;
            imageAbility4.enabled = false;
        }
        else if (abilitys == 3)
        {
            imageAbility1.enabled = false;
            imageAbility2.enabled = false;
            imageAbility3.enabled = false;
            imageAbility4.enabled = true;
        }

    }
}
