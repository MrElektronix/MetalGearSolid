using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    [SerializeField]
    private Transform _object;
    //private bool _wall;

    //private Vector3 offset;
    private Vector3 _rotation;
    private Vector3 _targetPosition;
    private float _cameraSpeed;

	// Use this for initialization
	private void Start () {
        _cameraSpeed = 8f;
        //offset = transform.position - Object.transform.position;
        _rotation = transform.rotation.eulerAngles;
        transform.position = new Vector3(transform.position.x, 4.35f, -1.92f);
        _rotation.x = 30.0f;
        transform.rotation = Quaternion.Euler(_rotation);
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if (CheckTrigger.NearWall == false)
        {
            _targetPosition = new Vector3(transform.position.x, 4.35f, -1.92f);
            _rotation.x = 30.0f;
            //transform.rotation = Quaternion.Euler(rotation);
        } else
        {
            //transform.position = Object.transform.position + offset;
            _targetPosition = new Vector3(transform.position.x, 6f, -0.38f);
            _rotation.x = 90.0f;
            //transform.rotation = Quaternion.Euler(rotation);
        }

        if (CheckTrigger.NearStair)
        {
            _targetPosition = new Vector3(transform.position.x, 3.65f, 1.67f);
            _rotation.x = 30.0f;
            transform.LookAt(_object);
        }
        transform.position = Vector3.Lerp(transform.position, _targetPosition, Time.deltaTime * _cameraSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_rotation), Time.deltaTime * _cameraSpeed);
    }
}
