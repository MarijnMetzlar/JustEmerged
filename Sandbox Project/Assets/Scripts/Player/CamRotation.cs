using UnityEngine;
using System.Collections;

public class CamRotation : MonoBehaviour
{
    //private  bool mouseClickjudge = false;
    //public float cameraRotateSpeed = 1;
    // public GameObject bottom;

    //The target of the camera. The camera will always point to this object.
    public Transform _target;

    //The default distance of the camera from the target.
    public float _distance = 20.0f;
    public float highestRotation = 60;
    public float lowestRotation = -5;

    //The speed of the camera. Control how fast the camera will rotate.
    public float _xSpeed = 1f;
    public float _ySpeed = 1f;

    //The position of the cursor on the screen. Used to rotate the camera.
    private float _x = 15.0f;
    private float _y = 5.0f;
    private float carRoty;

    //Distance vector. 
    private Vector3 _distanceVector;

    /**
     * Move the camera to its initial position.
     */

    // Use this for initialization
    void Start()
    {
        _distanceVector = new Vector3(0.0f, 0.0f, -_distance);

        Vector2 angles = this.transform.localEulerAngles;
        _x = angles.x;
        _y = angles.y;

        //this.Rotate(_x, _y);

    }

    void FixedUpdate()
    {
        carRoty = _target.transform.rotation.y;
        this.RotateControls();
    }

    /**
 * Rotate the camera when the first button of the mouse is pressed.
 * 
 */
    void RotateControls()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (_x <= highestRotation && _x >= lowestRotation)
            {
                _x += Input.GetAxis("Mouse Y") * _xSpeed;
                _y += -Input.GetAxis("Mouse X") * _ySpeed;
            }
            if (_x > highestRotation)
            {
                _x = highestRotation;
            }
            if (_x < lowestRotation)
            {
                _x = lowestRotation;
            }

            //Debug.Log(_x);
            this.Rotate(_x, _y);
        }
        else
        {
            //_x = 10;
            //_y = carRoty * 60;
            this.Rotate(_x, _y);

            //Debug.Log(_y);
        }

        // sMoostening cam
    }

    /**
     * Transform the cursor mouvement in rotation and in a new position
     * for the camera.
     */
    void Rotate(float x, float y)
    {
        //Transform angle in degree in quaternion form used by Unity for rotation.
        Quaternion rotation = Quaternion.Euler(x, y, 0.0f);

        //The new position is the target position + the distance vector of the camera
        //rotated at the specified angle.
        Vector3 position = rotation * _distanceVector + _target.position;

        //Update the rotation and position of the camera.
        transform.rotation = rotation;
        transform.position = position;
    }
} //End class
