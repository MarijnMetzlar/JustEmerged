﻿using UnityEngine;
using System.Collections;

public class RotateGunsTwin : MonoBehaviour {

    private GameObject CubePos;
    private GameObject turretPos;
    private CameraRotation cameraClick;
    private MakingCar garageEnterLeaving;
    private GameObject car;

    private int inGarage;
    private bool moveCrosshair;

    private ParticleSystem BulletsL;
    private ParticleSystem BulletsR;

	private int shootSound = 0;
	public AudioSource twinGun;
	public AudioSource twinGun2;
	public AudioSource twinGun3;

    // Use this for initialization
    void Start()
    {
        cameraClick = GameObject.Find("Car Camera").GetComponent<CameraRotation>();
        turretPos = GameObject.Find("TurretPos");
        CubePos = GameObject.Find("CubePos");
        car = GameObject.Find("car");
        garageEnterLeaving = GameObject.Find("car").GetComponent<MakingCar>();
    }

    void Rotation()
    {
        if (inGarage == 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (inGarage == 1)
        {
            if (moveCrosshair == true)
            {
                transform.LookAt(turretPos.transform);
            }
            else if (moveCrosshair == false)
            {
                transform.localEulerAngles = new Vector3(0, car.transform.rotation.y + 180, 0);
            }
        }
    }

    void ShootGun()
    {
        if (cameraClick.moveMouseCrosshair == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
				if(shootSound == 0)
				{
					shootSound += 1;
					//sound!
					twinGun.Play();
				}
				else if(shootSound == 1)
				{
					shootSound += 1;
					//sound!
					twinGun2.Play();
				}

				else if(shootSound == 2)
				{
					shootSound -= 2;
					//sound!
					twinGun3.Play();
				}

                BulletsL.Emit(100);
                BulletsR.Emit(100);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        BulletsL = GameObject.Find("BulletsL").GetComponent<ParticleSystem>();
        BulletsR = GameObject.Find("BulletsR").GetComponent<ParticleSystem>();

        Rotation();
        ShootGun();

        inGarage = garageEnterLeaving.garageEnterLeaving;
        moveCrosshair = cameraClick.moveMouseCrosshair;
    }
}