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

    public void Brake(float value)
    {
        wc.brakeTorque = value;
    }

	// Update is called once per frame
	public void Turn (float value)
    {
        wc.steerAngle = value;
        tire.localEulerAngles = new Vector3(0, wc.steerAngle * 2, 0);
        tire.Rotate(wc.rpm / 60 * 360 * Time.deltaTime, 0, 0);
	}
}