using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MakingCar : MonoBehaviour
{

    public GameObject wheelPrefab0;
    public GameObject wheelPrefab1;
    public GameObject chassiPrefabSmall;
    public GameObject chassiPrefabMedium;
    public GameObject chassiPrefabLarge;
    public GameObject frontAxel;
    public GameObject rearAxel;
    public GameObject turretPrefabTwin;
    public GameObject turretPrefabMini;
    public GameObject boosterPrefab;

    private int Step = 0;
    public int chassyNumber = 0;
    public int wheelType = 0;
    private int wheelChange;
    private int chassyChange;
    public int upgrades = 0;
    private int upgradeUpdate;
    public int boosterType = 0;
    private int boosterChange;
    public int turretType = 0;
    private int turretChange;
    public int ablilityType = 0;
    private int ablilityChange;
    public Vector3 carPos;
    public int garageEnterLeaving = 0;
    public int spawningCar;
    private float newHealth;
    private Material[] oldmaterial;
    private float resetMaterial;

    private GameObject carChassy;

    private GameObject mainCamera;
    private GameObject carCamera;
    private GameObject canvasGarage;
    private GameObject canvasGame;
    private GameObject gameCrosshair;
    private GameObject eListener;
    private MoveCar gunStats;

    private GameObject playerObjectNumber;

    private bool garageSoundNow = false;
    public AudioSource garageSound;

    // Use this for initialization
    void Start()
    {
        ChangeCar();
        mainCamera = GameObject.Find("Main Camera");
        carCamera = GameObject.Find("Car Camera");
        canvasGarage = GameObject.Find("Garage Canvas");
        canvasGame = GameObject.Find("Game Canvas");
        playerObjectNumber = GameObject.Find("Player object numbers");
        gameCrosshair = GameObject.Find("Crosshair");
        eListener = GameObject.Find("EventSystem");
        gunStats = GameObject.Find("car").GetComponent<MoveCar>();
        oldmaterial = carChassy.GetComponent<Renderer>().materials;
    }

    void ChangeCar()
    {
        if (chassyNumber == 0)
        {
            createSmallCar();
            createSmallCar();
            createSmallCar();
            createSmallCar();
            createSmallCar();
            createSmallCar();
            createSmallCar();
        }
        if (chassyNumber == 1)
        {
            createMediumCar();
            createMediumCar();
            createMediumCar();
            createMediumCar();
            createMediumCar();
            createMediumCar();
            createMediumCar();
        }
        if (chassyNumber == 2)
        {
            createLargeCar();
            createLargeCar();
            createLargeCar();
            createLargeCar();
            createLargeCar();
            createLargeCar();
            createLargeCar();
        }

        upgradeUpdate = upgrades;
        wheelChange = wheelType;
        chassyChange = chassyNumber;
        boosterChange = boosterType;
        turretChange = turretType;
        ablilityChange = ablilityType;
        spawningCar = garageEnterLeaving;
    }

    void createSmallCar()
    {
        if (Step == 0)
        {
            GameObject newBody = Instantiate(chassiPrefabSmall);
            newBody.name = "chassy";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0f, 0f, 0f);
            newBody.transform.localEulerAngles = new Vector3(270, 0, 0);
            this.GetComponent<MoveCar>().carHP = 20;
            Step += 1;
        }
        else if (Step == 1)
        {
            GameObject newBody = Instantiate(frontAxel);
            newBody.name = "Front Axel";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0f, -0.4f, 0.78f);
            newBody.transform.localEulerAngles = new Vector3(0, 0, 0);

            if (wheelType == 0)
            {
                GameObject leftWheel = Instantiate(wheelPrefab0);
                leftWheel.name = "WheelFL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.355f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab0);
                rightWheel.name = "WheelFR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.355f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
            else if (wheelType == 1)
            {
                GameObject leftWheel = Instantiate(wheelPrefab1);
                leftWheel.name = "WheelFL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.355f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab1);
                rightWheel.name = "WheelFR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.355f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
        }
        else if (Step == 2)
        {
            GameObject newBody = Instantiate(rearAxel);
            newBody.name = "Rear Axel";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0f, -0.4f, -0.455f);
            newBody.transform.localEulerAngles = new Vector3(0, 0, 0);

            if (wheelType == 0)
            {
                GameObject leftWheel = Instantiate(wheelPrefab0);
                leftWheel.name = "WheelRL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.415f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab0);
                rightWheel.name = "WheelRR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.355f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
            else if (wheelType == 1)
            {
                GameObject leftWheel = Instantiate(wheelPrefab1);
                leftWheel.name = "WheelRL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.415f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab1);
                rightWheel.name = "WheelRR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.415f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
        }
        else if (Step == 3)
        {
            GameObject newBody = Instantiate(boosterPrefab);
            newBody.name = "Booster";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0, -0.215f, -1.2f);
            newBody.transform.localEulerAngles = new Vector3(0, 180, 0);
            Step += 1;
        }
        else if (Step == 4)
        {
            if (turretType == 0)
            {
                GameObject newBody = Instantiate(turretPrefabMini);
                newBody.name = "Turret";
                newBody.transform.parent = transform;
                newBody.transform.localPosition = new Vector3(0, 0.256f, -0.822f);
                newBody.transform.localEulerAngles = new Vector3(0, 180, 0);
                this.GetComponent<MoveCar>().gunDamage = 2;
                Step += 1;
            }
            else if (turretType == 1)
            {
                GameObject newBody = Instantiate(turretPrefabTwin);
                newBody.name = "Turret";
                newBody.transform.parent = transform;
                newBody.transform.localPosition = new Vector3(0, 0.25f, -0.881f);
                newBody.transform.localEulerAngles = new Vector3(0, 180, 0);
                this.GetComponent<MoveCar>().gunDamage = 3;
                Step += 1;
            }
        }
        else
        {
            Step = 5;
        }
    }
    void createMediumCar()
    {
        if (Step == 0)
        {
            GameObject newBody = Instantiate(chassiPrefabMedium);
            newBody.name = "chassy";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0f, 0f, 0f);
            newBody.transform.localEulerAngles = new Vector3(270, 0, 0);
            this.GetComponent<MoveCar>().carHP = 22;
            Step += 1;
        }
        else if (Step == 1)
        {
            GameObject newBody = Instantiate(frontAxel);
            newBody.name = "Front Axel";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0f, -0.4f, 0.78f);
            newBody.transform.localEulerAngles = new Vector3(0, 0, 0);

            if (wheelType == 0)
            {
                GameObject leftWheel = Instantiate(wheelPrefab0);
                leftWheel.name = "WheelFL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.355f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab0);
                rightWheel.name = "WheelFR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.355f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
            else if (wheelType == 1)
            {
                GameObject leftWheel = Instantiate(wheelPrefab1);
                leftWheel.name = "WheelFL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.355f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab1);
                rightWheel.name = "WheelFR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.355f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
        }
        else if (Step == 2)
        {
            GameObject newBody = Instantiate(rearAxel);
            newBody.name = "Rear Axel";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0f, -0.4f, -0.455f);
            newBody.transform.localEulerAngles = new Vector3(0, 0, 0);

            if (wheelType == 0)
            {
                GameObject leftWheel = Instantiate(wheelPrefab0);
                leftWheel.name = "WheelRL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.415f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab0);
                rightWheel.name = "WheelRR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.355f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
            else if (wheelType == 1)
            {
                GameObject leftWheel = Instantiate(wheelPrefab1);
                leftWheel.name = "WheelRL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.415f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab1);
                rightWheel.name = "WheelRR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.415f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
        }
        else if (Step == 3)
        {
            GameObject newBody = Instantiate(boosterPrefab);
            newBody.name = "Booster";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0, -0.215f, -1.2f);
            newBody.transform.localEulerAngles = new Vector3(0, 180, 0);
            Step += 1;
        }
        else if (Step == 4)
        {
            if (turretType == 0)
            {
                GameObject newBody = Instantiate(turretPrefabMini);
                newBody.name = "Turret";
                newBody.transform.parent = transform;
                newBody.transform.localPosition = new Vector3(0, 0.256f, -0.822f);
                newBody.transform.localEulerAngles = new Vector3(0, 180, 0);
                this.GetComponent<MoveCar>().gunDamage = 2;
                Step += 1;
            }
            else if (turretType == 1)
            {
                GameObject newBody = Instantiate(turretPrefabTwin);
                newBody.name = "Turret";
                newBody.transform.parent = transform;
                newBody.transform.localPosition = new Vector3(0, 0.25f, -0.881f);
                newBody.transform.localEulerAngles = new Vector3(0, 180, 0);
                this.GetComponent<MoveCar>().gunDamage = 3;
                Step += 1;
            }
        }
        else
        {
            Step = 5;
        }
    }
    void createLargeCar()
    {
        if (Step == 0)
        {
            GameObject newBody = Instantiate(chassiPrefabLarge);
            newBody.name = "chassy";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0, 0, 0);
            newBody.transform.localEulerAngles = new Vector3(270, 0, 0);
            this.GetComponent<MoveCar>().carHP = 24;
            Step += 1;
        }
        else if (Step == 1)
        {
            GameObject newBody = Instantiate(frontAxel);
            newBody.name = "Front Axel";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0f, -0.4f, 0.78f);
            newBody.transform.localEulerAngles = new Vector3(0, 0, 0);

            if (wheelType == 0)
            {
                GameObject leftWheel = Instantiate(wheelPrefab0);
                leftWheel.name = "WheelFL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.355f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab0);
                rightWheel.name = "WheelFR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.355f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
            else if (wheelType == 1)
            {
                GameObject leftWheel = Instantiate(wheelPrefab1);
                leftWheel.name = "WheelFL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.355f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab1);
                rightWheel.name = "WheelFR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.355f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
        }
        else if (Step == 2)
        {
            GameObject newBody = Instantiate(rearAxel);
            newBody.name = "Rear Axel";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0f, -0.4f, -0.455f);
            newBody.transform.localEulerAngles = new Vector3(0, 0, 0);

            if (wheelType == 0)
            {
                GameObject leftWheel = Instantiate(wheelPrefab0);
                leftWheel.name = "WheelRL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.415f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab0);
                rightWheel.name = "WheelRR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.355f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
            else if (wheelType == 1)
            {
                GameObject leftWheel = Instantiate(wheelPrefab1);
                leftWheel.name = "WheelRL";
                leftWheel.transform.parent = newBody.transform;
                leftWheel.transform.localPosition = new Vector3(-0.415f, 0f, 0f);
                leftWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                GameObject rightWheel = Instantiate(wheelPrefab1);
                rightWheel.name = "WheelRR";
                rightWheel.transform.parent = newBody.transform;
                rightWheel.transform.localPosition = new Vector3(0.415f, 0f, 0f);
                rightWheel.transform.localEulerAngles = new Vector3(0, 0, 0);

                Step += 1;
            }
        }
        else if (Step == 3)
        {
            GameObject newBody = Instantiate(boosterPrefab);
            newBody.name = "Booster";
            newBody.transform.parent = transform;
            newBody.transform.localPosition = new Vector3(0, -0.215f, -1.2f);
            newBody.transform.localEulerAngles = new Vector3(0, 180, 0);
            Step += 1;
        }
        else if (Step == 4)
        {
            if(turretType == 0)
            {
                GameObject newBody = Instantiate(turretPrefabMini);
                newBody.name = "Turret";
                newBody.transform.parent = transform;
                newBody.transform.localPosition = new Vector3(0, 0.256f, -0.822f);
                newBody.transform.localEulerAngles = new Vector3(0, 180, 0);
                this.GetComponent<MoveCar>().gunDamage = 2;
                Step += 1;
            }
            else if (turretType == 1)
            {
                GameObject newBody = Instantiate(turretPrefabTwin);
                newBody.name = "Turret";
                newBody.transform.parent = transform;
                newBody.transform.localPosition = new Vector3(0, 0.25f, -0.881f);
                newBody.transform.localEulerAngles = new Vector3(0, 180, 0);
                this.GetComponent<MoveCar>().gunDamage = 3;
                Step += 1;
            }
        }
        else
        {
            Step = 5;
        }

    }


    public void changeTire ()
    {
        wheelType = wheelType + 1;
        playerObjectNumber.GetComponent<PlayerObjects>().wheels = playerObjectNumber.GetComponent<PlayerObjects>().wheels + 1;
        if (wheelType == 2)
        {
            wheelType = 0;
            playerObjectNumber.GetComponent<PlayerObjects>().wheels = 0;
        }
    }

    public void changeChassy ()
    {
        chassyNumber = chassyNumber + 1;
        playerObjectNumber.GetComponent<PlayerObjects>().chassys = playerObjectNumber.GetComponent<PlayerObjects>().chassys + 1;
        if (chassyNumber == 3)
        {
            chassyNumber = 0;
            playerObjectNumber.GetComponent<PlayerObjects>().chassys = 0;
        }
    }
    public void changeTurret ()
    {
        turretType = turretType + 1;
        playerObjectNumber.GetComponent<PlayerObjects>().turret = playerObjectNumber.GetComponent<PlayerObjects>().turret + 1;
        if (turretType == 2)
        {
            turretType = 0;
            playerObjectNumber.GetComponent<PlayerObjects>().turret = 0;
        }
    }

    public void LeaveGarage()
    {
		carPos = new Vector3(1550f, 41.61f, 1465f);
        transform.position = carPos;
        garageEnterLeaving = 1;
        transform.eulerAngles = new Vector3(0,90,0);
        mainCamera.GetComponent<Camera>().enabled = false;
        eListener.SetActive(false);
        carCamera.GetComponent<Camera>().enabled = true;
        canvasGarage.GetComponent<Canvas>().enabled = false;
        canvasGame.GetComponent<ChangeCanvas>().UpdateCanvas(chassyNumber, wheelType, turretType, ablilityType);
        canvasGame.GetComponent<Canvas>().enabled = true;
        carCamera.GetComponent<CameraRotation>().inGarage = false;
        this.GetComponent<MoveCar>().enabled = true;
        this.GetComponent<MoveCar>().UpdateStats();
        newHealth = gunStats.carHP;
        oldmaterial = carChassy.GetComponent<Renderer>().materials;
        Cursor.visible = false;
        garageSound.Stop();
        garageSoundNow = false;
    }

    void EnterGarage()
    {
		carPos = new Vector3 (1530f, 41.61f, 1465f);
		transform.position = carPos;
		transform.eulerAngles = new Vector3 (0, 0, 0);
		garageEnterLeaving = 0;
		mainCamera.GetComponent<Camera> ().enabled = true;
		eListener.SetActive (true);
		carCamera.GetComponent<Camera> ().enabled = false;
		canvasGarage.GetComponent<Canvas> ().enabled = true;
		canvasGame.GetComponent<Canvas> ().enabled = false;
		carCamera.GetComponent<CameraRotation> ().inGarage = true;
		this.GetComponent<MoveCar> ().rb.velocity = Vector3.zero;
		this.GetComponent<MoveCar> ().enabled = false;
        Cursor.visible = true;
        garageSound.Play();
        GameObject.Find("car").GetComponent<MoveCar>().engine.Stop();
        GameObject.Find("car").GetComponent<MoveCar>().idle.Stop();
        GameObject.Find("car").GetComponent<MoveCar>().boosterSound.Stop();
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "GarageEntering" || Input.GetKeyDown(KeyCode.P)) 
		{
			EnterGarage();
		}
	}

    void HpDeceased()
    {
        if (gunStats.carHP <= 0)
        {
            EnterGarage();
            
            gunStats.carHP = 20;
            canvasGame.GetComponent<ChangeCanvas>().damage = 0;
        }
    }

    void DamageIndicator()
    {
        float timezone = Time.deltaTime;
        resetMaterial += timezone; 

        if (gunStats.carHP < newHealth)
        {
            for (int i = 0; i < carChassy.GetComponent<Renderer>().materials.Length; i++)
            {
                carChassy.GetComponent<Renderer>().materials[i].color = Color.red;
            }
            resetMaterial = 0;
            newHealth = gunStats.carHP;
        }
        else if(resetMaterial >= 0.05f)
        {
            carChassy.GetComponent<Renderer>().materials = oldmaterial;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (wheelChange != wheelType || chassyChange != chassyNumber || spawningCar != garageEnterLeaving || boosterChange != boosterType || turretChange != turretType)
        {
            Step = 0;
            Destroy(GameObject.Find("chassy"));
            Destroy(GameObject.Find("WheelFL"));
            Destroy(GameObject.Find("WheelFR"));
            Destroy(GameObject.Find("WheelRL"));
            Destroy(GameObject.Find("WheelRR"));
            Destroy(GameObject.Find("Turret"));
            Destroy(GameObject.Find("Booster"));
            Destroy(GameObject.Find("Rear Axel"));
            Destroy(GameObject.Find("Front Axel"));
            upgrades = 1;
        }
        if (upgrades == 1)
        {
            ChangeCar();
            upgrades = 0;
        }

        if (garageEnterLeaving == 0)
        {
            if(garageSoundNow == false)
            {
                garageSound.Play();
                garageSoundNow = true;
            }
            
            this.transform.position = new Vector3(1530f, 40.61f, 1465f);
            this.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        HpDeceased();
        carChassy = GameObject.Find("chassy");
        DamageIndicator();
    }
}
