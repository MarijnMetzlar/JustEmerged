using UnityEngine;
using System.Collections;

public class RotateGuns : MonoBehaviour {

    public Transform targetPos;

    public ParticleSystem Bullets;

	// Use this for initialization
	void Start () {
	    
	}

    void Rotation()
    {
        transform.LookAt(targetPos);
    }

    void ShootGun()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Bullets.Emit(100);
        }
    }

    // Update is called once per frame
	void Update () {
        Rotation();
        ShootGun();
	}
}
