using UnityEngine;
using System.Collections;

public class RotateGunsMini : MonoBehaviour {

    private GameObject CubePos;
    private GameObject turretPos;
    private CameraRotation cameraClick;
    private MakingCar garageEnterLeaving;
    private GameObject car;

    private int inGarage;
    private bool moveCrosshair;
    private float timePassed;

    private GameObject Bullets;

	private int shootSound = 0;
	public AudioSource miniGun;
	public AudioSource miniGun2;

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
            float timer =  Time.deltaTime;
            timePassed = timePassed + timer;

            if (timePassed > 0.2f && Input.GetKey(KeyCode.Mouse0))
            {
                Bullets.GetComponent<ParticleSystem>().Emit(100);

                if (shootSound == 0)
                {
                    shootSound += 1;
                    //sound!
                    miniGun.Play();
                }
                else if (shootSound == 1)
                {
                    shootSound -= 1;
                    //sound!
                    miniGun2.Play();
                }

                timePassed = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Bullets = GameObject.Find("Bullets");

        Rotation();
        ShootGun();

        inGarage = garageEnterLeaving.garageEnterLeaving;
        moveCrosshair = cameraClick.moveMouseCrosshair;
    }
}