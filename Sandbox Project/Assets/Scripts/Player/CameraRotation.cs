using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraRotation : MonoBehaviour {

    private GameObject targetObject;
    private GameObject targetEmpty;
    private Image buttonCrosshair;
    public bool moveMouseCrosshair = false;
    private Vector3 offset;
    public float distanceObject = -20.0f;
    public float xSpeed = 1.0f;
    public float ySpeed = 1.0f;
    private float mousePosx = 0.0f;
    private float mousePosy = 0.0f;
    private Vector3 distanceVector;
    public bool inGarage = true;

    // Use this for initialization
    
    void Start()
    {
        targetObject = GameObject.Find("car");
        targetEmpty = GameObject.Find("Right click Cam");
        buttonCrosshair = GameObject.Find("Crosshair").GetComponent<Image>();

        offset = targetObject.transform.position - transform.position;

        distanceVector = new Vector3(0.0f, 0.0f, distanceObject);
    }

    // Update is called once per frame
    void Update ()
    {
        RotateMouseCam();
        RotateCamera();
    }

    void RotateMouseCam()
    {
        if (inGarage == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1) && moveMouseCrosshair == false)
            {
                moveMouseCrosshair = true;
                buttonCrosshair.enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1) && moveMouseCrosshair == true)
            {
                moveMouseCrosshair = false;
                buttonCrosshair.enabled = false;
            }
        }
        else
        {
            moveMouseCrosshair = false;
        }
    }

    void RotateCamera()
    {
        if(moveMouseCrosshair == true)
        {

            Vector2 angles = transform.localEulerAngles;
            mousePosx = angles.x;
            mousePosy = angles.y;

            Rotate(mousePosx, mousePosy);

            RotateWithMouse();
        }
        else
        {
            RotateWithoutMouse();
        }
    }

    void RotateWithMouse()
    {
        mousePosx += Input.GetAxis("Mouse Y") * xSpeed;
        mousePosy += Input.GetAxis("Mouse X") * ySpeed;

        Rotate(mousePosx, mousePosy);
    }

    void RotateWithoutMouse()
    {
        float desiredAngle = targetObject.transform.localEulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = targetObject.transform.position - (rotation * offset);

        transform.LookAt(targetObject.transform);
    }

    void Rotate(float x, float y)
    {
        Quaternion rotation = Quaternion.Euler(x, y, 0.0f);

        Vector3 position = rotation * distanceVector + targetEmpty.transform.position;

        transform.rotation = rotation;
        transform.position = position;
    }
}
