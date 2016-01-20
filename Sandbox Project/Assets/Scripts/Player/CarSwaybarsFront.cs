using UnityEngine;
using System.Collections;

public class CarSwaybarsFront : MonoBehaviour {

    public WheelCollider WheelL;
    public WheelCollider WheelR;

    public float antiRoll = 5000.0f;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GameObject.Find("car").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        WheelL = GameObject.Find("WheelFL").GetComponent<WheelCollider>();
        WheelR = GameObject.Find("WheelFR").GetComponent<WheelCollider>();

        WheelHit hit;
        float travelL = 1.0f;
        float travelR = 1.0f;

        bool GroundedL = WheelL.GetGroundHit(out hit);
        if (GroundedL)
        {
            travelL = (-WheelL.transform.InverseTransformPoint(hit.point).y - WheelL.radius) / WheelL.suspensionDistance;
        }
        bool GroundedR = WheelR.GetGroundHit(out hit);
        if (GroundedR)
        {
            travelR = (-WheelR.transform.InverseTransformPoint(hit.point).y - WheelR.radius) / WheelR.suspensionDistance;
        }
        float antiRollForce = (travelL - travelR) * antiRoll;

        if (GroundedL)
        {
            rb.AddForceAtPosition(WheelL.transform.up * -antiRollForce, WheelL.transform.position);
        }
        if (GroundedR)
        {
            rb.AddForceAtPosition(WheelR.transform.up * antiRollForce, WheelR.transform.position);
        }
    }
}
