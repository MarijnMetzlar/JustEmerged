using UnityEngine;
using System.Collections;

public class RotateGuns : MonoBehaviour {

    private GameObject crosshair;
    private CameraRotation cameraClick;

    public ParticleSystem Bullets;

	private bool Sound = false;
	public AudioSource GunSound;
	public AudioSource LaserSound;

	// Use this for initialization
	void Start () {
        crosshair = GameObject.Find("Crosshair");
        cameraClick = GameObject.Find("Main Camera").GetComponent<CameraRotation>();
	}

    void Rotation()
    {
        transform.LookAt(crosshair.transform);
    }

    void ShootGun()
    {
        if (cameraClick.moveMouseCrosshair == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Bullets.Emit(100);
				//sounds need to switch after one click!
				if(Sound == false)
				{
					GunSound.Play();
					Sound = true;

				}
				else
				{
					LaserSound.Play();
					Sound = false;
				}
            }
        }
    }

    // Update is called once per frame
	void Update () {
        Rotation();
        ShootGun();

	}
}
