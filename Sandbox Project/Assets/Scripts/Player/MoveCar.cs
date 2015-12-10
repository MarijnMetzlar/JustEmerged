using UnityEngine;
using System.Collections;

public class MoveCar : MonoBehaviour {

    [Header("(Turn)Speed")]
    public float speedForward = 20;
    private float speedSaveforward;
    public float speedBackward = -20;
    public float speedMultiplier = 1;
    public float turnSpeed = 200;
    private float movingFwBw;
    private float movingLeRi;
    private float turning;

    [Header("Jumping")]
    public float jumpStrength= 10;
    private float jumpTime;
    private float jumpSaveTime;
    private float jumpCountDown = 0;
    public float JumpCountDowntime = 0;

    [Header("Wheels")]
    public Transform wheelFLTrans;
    public Transform wheelFRTrans;
    public Transform wheelRLTrans;
    public Transform wheelRRTrans;
    private float turnWheelLeftorRight;

    [Header("Boosters")]
    public ParticleSystem BoosterL;
    public ParticleSystem BoosterR;
    public float maxBoost = 5;
    private float boosterSpeed;
    public float boosterMultiplier = 3;
    private float boosterRemaining = 5;
    private float boosterTillRefill;
    public float boosterTime = 3;
    public float boosterRefillTime = 3;

    [Header("Side Boosters")]
    public float boosterSideSpeed = 80;
    private float boosterSideTime = 0;
    private float boosterSideCountDown = 3;

    private bool boostingSideways;

    [Header("Timer")]
    private float timer;

    // Use this for initialization
    void Start() {
        speedSaveforward = speedForward * speedMultiplier;
        boosterSpeed = speedSaveforward * boosterMultiplier * speedMultiplier;
        jumpTime = jumpStrength / 20;
        jumpSaveTime = jumpTime;
    }

    // Update is called once per frame
    void FixedUpdate() {
        TimeStuff();
        HandBrake();
        WheelRotation();
        JumpUp();
        BoostSide();

        turning = turning + 1;
        if (turning >= 360)
        {
            turning = 0;
        }

        transform.Translate(Vector3.forward * movingFwBw * Time.deltaTime);
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
            movingFwBw = boosterSpeed;
            MovementLeRi(true);
            BoosterL.Emit(500);
            BoosterR.Emit(500);

            boosterRemaining = boosterRemaining - Time.deltaTime;
            boosterTillRefill = 0;
        }
        else
        {
            if (boosterTillRefill >= boosterTime && boosterRemaining <= maxBoost)
            {
                boosterRemaining = boosterRemaining + Time.deltaTime * boosterRefillTime;
            }
        }
    }

    void HandBrake()
    {
        if(Input.GetKey(KeyCode.G))
        {
            movingFwBw = 0;
            MovementLeRi(true);
        }
        else
        {
            MovementFwBw();
            Booster();
            MovementLeRi(false);
        }
    }

    void WheelRotation()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            wheelFLTrans.localRotation = Quaternion.Euler(0, turnWheelLeftorRight + 90, 15 * turning * movingFwBw * Time.deltaTime * 1);
            wheelFRTrans.localRotation = Quaternion.Euler(0, turnWheelLeftorRight + 90, 15 * turning * movingFwBw * Time.deltaTime * 1);
        }
        else
        {
            wheelFLTrans.localRotation = Quaternion.Euler(0, turnWheelLeftorRight + 90, 15 * turning * movingFwBw * Time.deltaTime * 1);
            wheelFRTrans.localRotation = Quaternion.Euler(0, turnWheelLeftorRight + 90, 15 * turning * movingFwBw * Time.deltaTime * 1);
        }
        
        wheelRLTrans.localRotation = Quaternion.Euler(0, 90, 15 * turning * movingFwBw * Time.deltaTime -1);
        wheelRRTrans.localRotation = Quaternion.Euler(0, 90, 15 * turning * movingFwBw * Time.deltaTime -1);
    }

    void MovementFwBw()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            movingFwBw = speedForward * speedMultiplier;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            movingFwBw = speedBackward;
        }
        if (Input.GetKey(KeyCode.S) == false && Input.GetKey(KeyCode.W) == false)
        {
            movingFwBw = 0;
            movingLeRi = 0;
        }
    }

    void MovementLeRi(bool handbrakePressed)
    {
        if (Input.GetKey(KeyCode.D))
        {
            turnWheelLeftorRight = turnSpeed;

            if (Input.GetKey(KeyCode.S) && handbrakePressed == false || Input.GetKey(KeyCode.W) && handbrakePressed == false || Input.GetKey(KeyCode.LeftShift) && handbrakePressed == false)
            {
                movingLeRi = turnSpeed;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            turnWheelLeftorRight = -turnSpeed;

            if (Input.GetKey(KeyCode.S) && handbrakePressed == false || Input.GetKey(KeyCode.W) && handbrakePressed == false || Input.GetKey(KeyCode.LeftShift) && handbrakePressed == false)
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
