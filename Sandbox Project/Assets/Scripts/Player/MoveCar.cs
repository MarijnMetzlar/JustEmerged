using UnityEngine;
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
    public float jumpStrength = 10;
    public float JumpCountDowntime = 2;
    private float jumpTime;
    private float jumpSaveTime;
    private float jumpCountDown = 0;

    [Header("Wheels")]
    public Transform wheelFLTrans;
    public Transform wheelFRTrans;
    public Transform wheelRLTrans;
    public Transform wheelRRTrans;
    private float turnWheelLeftorRight;

    [Header("Boosters")]
    public ParticleSystem BoosterL;
    public ParticleSystem BoosterR;
    public float maxBoost = 3;
    private float boosterSpeed;
    public float boosterMultiplier = 2;
    private float boosterRemaining = 3;
    private float boosterTillRefill;
    public float boosterTime = 3;
    public float boosterRefillTime = 3;
    private float accelerationBooster;

    [Header("Side Boosters")]
    public float boosterSideSpeed = 50;
    private float boosterSideTime = 0;
    private float boosterSideCountDown = 3;
    private bool boostingSideways;

    [Header("Gun")]
    public int gunDamage = 2;

    [Header("Timer")]
    private float timer;

    private Rigidbody rb;
    public float carHP = 20;

    // Use this for initialization
    void Start() {
        boosterSpeed = speedForward * boosterMultiplier;
        speedSaveForward = speedForward;
        accelerationSaveSpeed = accelerationSpeed;
        accelerationBooster = accelerationSpeed * 2;
        jumpTime = jumpStrength / 20;
        jumpSaveTime = jumpTime;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        TimeStuff();
        WheelRotation();
        JumpUp();
        BoostSide();
        Booster();
        MovementFwBw();
        MovementLeRi();

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
        if (Input.GetKey(KeyCode.Space) && jumpTime > 0)
        {
            transform.Translate(Vector3.up * jumpStrength * Time.deltaTime);

            jumpTime = jumpTime - Time.deltaTime;
            jumpCountDown = 0;
        }
        else if (Input.GetKeyUp(KeyCode.Space) && jumpTime > 0)
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
        //Debug.Log("booster remaining + " + boosterRemaining);
        //Debug.Log("booster till refill + " + boosterTillRefill);
        if (Input.GetKey(KeyCode.LeftShift) && boosterRemaining > 0)
        {
            speedForward = boosterSpeed;
            accelerationSpeed = accelerationBooster;
            BoosterL.Emit(500);
            BoosterR.Emit(500);

            boosterRemaining = boosterRemaining - Time.deltaTime;
            boosterTillRefill = 0;
        }
        else
        {
            accelerationSpeed = accelerationSaveSpeed;

            if (boosterTillRefill >= boosterTime && boosterRemaining <= maxBoost)
            {
                boosterRemaining = boosterRemaining + Time.deltaTime * boosterRefillTime;
            }
        }
    }

    void WheelRotation()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            wheelFLTrans.localRotation = Quaternion.Euler(15 * turning * rb.velocity.magnitude * Time.deltaTime * -1, turnWheelLeftorRight, 0);
            wheelFRTrans.localRotation = Quaternion.Euler(15 * turning * rb.velocity.magnitude * Time.deltaTime * -1, turnWheelLeftorRight, 0);
        }
        else
        {
            wheelFLTrans.localRotation = Quaternion.Euler(15 * turning * rb.velocity.magnitude * Time.deltaTime * 1, turnWheelLeftorRight, 0);
            wheelFRTrans.localRotation = Quaternion.Euler(15 * turning * rb.velocity.magnitude * Time.deltaTime * 1, turnWheelLeftorRight, 0);
        }
        
        wheelRLTrans.localRotation = Quaternion.Euler(15 * turning * rb.velocity.magnitude * Time.deltaTime - 1, 0, 0);
        wheelRRTrans.localRotation = Quaternion.Euler(15 * turning * rb.velocity.magnitude * Time.deltaTime - 1, 0, 0);
    }

    void MovementFwBw()
    {
        //Debug.Log(rb.velocity.magnitude);
        if (Input.GetKey(KeyCode.W) == true)
        {
            if (rb.velocity.magnitude <= speedForward)
            {
                rb.AddRelativeForce(Vector3.forward * accelerationSpeed, ForceMode.Acceleration);
            }
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            if (rb.velocity.magnitude <= speedBackward)
            {
                rb.AddRelativeForce(Vector3.forward * -accelerationSpeed, ForceMode.Acceleration);
            }
        }
        if (Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S) == false)
        {
            if (rb.velocity.magnitude > speedSaveForward)
            {
                speedForward = rb.velocity.magnitude;
            }
        }
    }

    void MovementLeRi()
    {
        if (Input.GetKey(KeyCode.D))
        {
            turnWheelLeftorRight = turnSpeed;

            if (rb.velocity.magnitude > 0.1 || rb.velocity.magnitude < -0.1)
            {
                movingLeRi = turnSpeed;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            turnWheelLeftorRight = -turnSpeed;

            if (rb.velocity.magnitude < -0.1 || rb.velocity.magnitude > 0.1)
            {
                movingLeRi = -turnSpeed;
            }
        }
        if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)
        {
            turnWheelLeftorRight = 0;
            movingLeRi = 0;
        }
    }
}
