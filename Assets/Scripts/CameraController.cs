using System;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    private Transform _object;

    [SerializeField]
    private Transform[] _cameraViews;

    private Vector3 _rotation;
    private Vector3 _objectRotation;
    private Vector3 _targetPosition;

    private float _cameraSpeed;



    private void Start () {
        _cameraSpeed = 8f;
        SwitchCamera(0, 30f);
    }

    private void SwitchCamera(int indexOfCamera, float cameraRotation)
    {
        _targetPosition = new Vector3(_cameraViews[indexOfCamera].transform.position.x, _cameraViews[indexOfCamera].transform.position.y, _cameraViews[indexOfCamera].transform.position.z );
        _rotation.x = cameraRotation;
    }

    private void RotateObject(Component Object, string axis, float angle)
    {
        switch (axis)
        {
            case "x":
                _objectRotation.x = angle;
                break;
            case "y":
                _objectRotation.y = angle;
                break;
            case "z":
                _objectRotation.z = angle;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        Object.transform.rotation = Quaternion.Euler(_objectRotation);
    }

    private void FixedUpdate()
    {
        if (CheckTrigger.NearWall == false)
        {
            SwitchCamera(0, 30f);
        } else
        {
            SwitchCamera(1, 90f);
        }

        if (CheckTrigger.NearStair)
        {
            RotateObject(_object, "x" , -25f);
            SwitchCamera(2, 30f);
            transform.LookAt(_object);
        }
        else
        {
            RotateObject(_object, "x" , 30f);
        }
        transform.position = Vector3.Lerp(transform.position, _targetPosition, Time.deltaTime * _cameraSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_rotation), Time.deltaTime * _cameraSpeed);
    }
}
