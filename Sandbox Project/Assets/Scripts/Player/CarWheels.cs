using UnityEngine;
using System.Collections;

public class CarWheels : MonoBehaviour {

    private Transform tire;
    private WheelCollider wc;

	// Use this for initialization
	void Start () {
        wc = GetComponent<WheelCollider>();
        tire = transform.FindChild("WheelTire");
	}
	
    public void Move(float value)
    {
        wc.motorTorque = value;
    }

	// Update is called once per frame
	public void Turn (float value)
    {
        wc.steerAngle = value;
	}
}