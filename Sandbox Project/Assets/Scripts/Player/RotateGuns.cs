using UnityEngine;
using System.Collections;

public class RotateGuns : MonoBehaviour {

    private GameObject CubePos;
    private GameObject turretPos;
    private CameraRotation cameraClick;

    public ParticleSystem Bullets;

	// Use this for initialization
	void Start () {
        cameraClick = GameObject.Find("Main Camera").GetComponent<CameraRotation>();
        turretPos = GameObject.Find("TurretPos");
        CubePos = GameObject.Find("CubePos");
    }

    void Rotation()
    {
        transform.LookAt(turretPos.transform);
    }

    void ShootGun()
    {
        /*if (cameraClick.moveMouseCrosshair == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Bullets.Emit(100);
            }
        }*/
    }

    // Update is called once per frame
	void Update () {
        
        Rotation();
        ShootGun();

	}
}
