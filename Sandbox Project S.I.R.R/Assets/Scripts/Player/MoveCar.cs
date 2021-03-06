﻿using UnityEngine;
using System.Collections;

public class MoveCar : MonoBehaviour {

    [Header("(Turn)Speed")]
    public float speedForward = 30;
    public float speedBackward = -10;
    public float turnSpeed = 200;
    public float accelerationSpeed = 0.1f;
    private float movingLeRi;
    private float turning;
    private float speedSaveForward;
    private float accelerationSaveSpeed;

    [Header("Jumping")]
    public float JumpCountDowntime = 2;
    private float jumpTime;
    private float jumpSaveTime;
    private float jumpCountDown = 0;

    [Header("Wheels")]
    private float turnWheelLeftorRight;

    [Header("Boosters")]
    public ParticleSystem booster;
    public float maxBoost = 3;
    private float boosterSpeed;
    public float boosterMultiplier = 2;
    private float boosterRemaining = 3;
    private float boosterTillRefill;
    public float boosterTime = 3;
    public float boosterRefillTime = 3;
    private float accelerationBooster;
    private float boosterSpeedForward;

    [Header("Side Boosters")]
    public float boosterSideSpeed = 50;
    private float boosterSideTime = 0;
    private float boosterSideCountDown = 3;
    private bool boostingSideways;

    [Header("Gun")]
    public int gunDamage = 2;

    [Header("Timer")]
    private float timer;

    public Rigidbody rb;
    public float carHP = 20;

    private RaycastHit hit;
    private float dis;
    private Vector3 dir;
    private Transform centerOfMass;

    public GameObject FL;
    public GameObject FR;
    public GameObject RL;
    public GameObject RR;

    public int damageMultiplier;
    public int speedMultiplier;
    public int accelerationMultiplier;
    public int hpMultiplier;
    public int boosters;
    public float boosterDecreaser;
    public float boosterIncreaser;

    public int upgradePoints;

    public bool getObjects = false;

    private bool engineRunning = false;
	public AudioSource meepSound;
	public AudioSource boosterSound;
    public AudioSource engine;
    public AudioSource idle;


    // Use this for initialization
    void Start() {
        jumpTime = 0.1f;
        jumpSaveTime = jumpTime;
        rb = GetComponent<Rigidbody>();
        centerOfMass = GameObject.Find("Center of mass").GetComponent<Transform>();
        rb.centerOfMass = centerOfMass.localPosition;

    }

    public void UpdateStats()
    {
        speedForward = speedForward + (speedMultiplier * 2);
        speedBackward = speedBackward + (speedMultiplier * 2);
        accelerationSpeed = accelerationSpeed + (accelerationMultiplier * 500);
        gunDamage = gunDamage + damageMultiplier;
        boosterSpeed = accelerationSpeed * boosterMultiplier;
        boosterSpeedForward = speedForward * 2;
        speedSaveForward = speedForward;
        accelerationSaveSpeed = accelerationSpeed;
        accelerationBooster = accelerationSpeed * 2;
        boosterTillRefill = 3 - boosterDecreaser;
        maxBoost = 3 + boosterIncreaser;
        
    }


    void FixedUpdate() {
        FL = GameObject.Find("WheelFL");
        FR = GameObject.Find("WheelFR");
        RL = GameObject.Find("WheelRL");
        RR = GameObject.Find("WheelRR");
        booster = GameObject.Find("Booster").GetComponent<ParticleSystem>();

        TimeStuff();
        JumpUp();
        BoostSide();
        Booster();
        MovementFwBw();
        MovementLeRi();
        FlipCar();
		Sounds ();
        
        turning = turning + 1;
        if (turning >= 360)
        {
            turning = 0;
        }

        transform.Rotate(0, movingLeRi * Time.deltaTime, 0);
    }

    void TimeStuff()
    {
        timer = Time.deltaTime;
        
        jumpCountDown = jumpCountDown + timer;
        boosterSideCountDown = boosterSideCountDown + timer;
        boosterTillRefill = boosterTillRefill + timer;
    }

    void JumpUp()
    {
        if (Input.GetKey(KeyCode.B) && jumpTime > 0)
        {
            transform.Translate(0,0.5f,0);

            jumpTime = jumpTime - Time.deltaTime;
            jumpCountDown = 0;
        }
        else if (Input.GetKeyUp(KeyCode.B) && jumpTime > 0)
        {
            jumpTime = 0;
        }
        else if (jumpCountDown >= JumpCountDowntime)
        {
            jumpTime = jumpSaveTime;
        }
    }

    void BoostSide()
    {
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E))
        {
            if (boosterSideCountDown >= 3 && boostingSideways == false)
            {
                boosterSideTime = boosterSideTime + timer;

                if (Input.GetKey(KeyCode.Q))
                {
                    transform.Translate(Vector3.left * boosterSideSpeed * Time.deltaTime);
                    if (boosterSideTime >= 0.2)
                    {
                        boosterSideTime = 0;
                        boostingSideways = true;
                    }
                }
                else if (Input.GetKey(KeyCode.E))
                {
                    transform.Translate(Vector3.right * boosterSideSpeed * Time.deltaTime);
                    if (boosterSideTime >= 0.2)
                    {
                        boosterSideTime = 0;
                        boostingSideways = true;
                    }
                }
            }
            else if (boosterSideCountDown >= 3)
            {
                boosterSideCountDown = 0;
                boostingSideways = false;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.E))
        {
            if (boosterSideTime > 0)
            {
                boosterSideTime = 0;
                boostingSideways = true;
            }
        }

    }

   void Booster()
    {
        if (Input.GetKey (KeyCode.LeftShift) && boosterRemaining > 0) 
		{
            rb.AddRelativeForce(Vector3.forward * 10000);

            speedForward = boosterSpeedForward;
			accelerationSpeed = boosterSpeed;
			booster.enableEmission = true;

			boosterRemaining = boosterRemaining - Time.deltaTime;
			boosterTillRefill = 0;
		}

        else
        {
            accelerationSpeed = accelerationSaveSpeed;
            speedForward = speedSaveForward;
            booster.enableEmission = false;
            if (boosterTillRefill >= boosterTime && boosterRemaining <= maxBoost)
            {
                boosterRemaining = boosterRemaining + Time.deltaTime * boosterRefillTime;
            }
        }
    }

    void MovementFwBw()
    {
        float torque = Input.GetAxis("Vertical") * accelerationSpeed;
        if (Input.GetKey(KeyCode.W) == true)
        {
            if (engineRunning == false)
            {
                engine.Play();
                idle.Stop();
                engineRunning = true;
            }

            if (rb.velocity.magnitude <= speedForward)
            {
                FL.GetComponent<CarWheels>().Move(torque);
                FR.GetComponent<CarWheels>().Move(torque);
            }
            else
            {
                FL.GetComponent<CarWheels>().Move(0);
                FR.GetComponent<CarWheels>().Move(0);
            }
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            if (rb.velocity.magnitude <= speedBackward)
            {
                FL.GetComponent<CarWheels>().Move(torque);
                FR.GetComponent<CarWheels>().Move(torque);
            }
            else
            {
                FL.GetComponent<CarWheels>().Move(0);
                FR.GetComponent<CarWheels>().Move(0);
            }
        }
        else
        {

            if (engineRunning == true)
            {
                idle.Play();
                engine.Stop();
                engineRunning = false;
            }


            FL.GetComponent<CarWheels>().Move(0);
            FR.GetComponent<CarWheels>().Move(0);
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {
            FL.GetComponent<CarWheels>().Brake(accelerationSpeed * 9);
            FR.GetComponent<CarWheels>().Brake(accelerationSpeed * 9);
        }
        else
        {
            FL.GetComponent<CarWheels>().Brake(0);
            FR.GetComponent<CarWheels>().Brake(0);
        }
    }

    void MovementLeRi()
    {
        float turnAngle = Input.GetAxis("Horizontal") * turnSpeed;
        FL.GetComponent<CarWheels>().Turn(turnAngle);
        FR.GetComponent<CarWheels>().Turn(turnAngle);
    }

    void FlipCar()
    {
        if (Vector3.Dot(transform.up, Vector3.down) > 0.5f && Input.GetKey(KeyCode.L))
        {
			transform.position = new Vector3(transform.position.x, transform.position.y + 2.0f, transform.position.z);
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
            speedForward = speedSaveForward;

        }
        else if (Vector3.Dot(transform.up, Vector3.down) > 0.5f)
        {
            //rb.velocity = 0;
        }
    }

	void Sounds()
	{
		if(Input.GetKeyDown(KeyCode.R))
		{
			meepSound.Play ();
		}

		if (Input.GetKeyDown (KeyCode.LeftShift) && boosterRemaining > 0) 
		{
			boosterSound.Play ();
		}
		
		if (Input.GetKeyUp (KeyCode.LeftShift)) 
		{
			boosterSound.Stop();
		}
	}
}
