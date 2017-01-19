using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    [SerializeField]
    private GameObject Object;
    private bool wall;

    //private Vector3 offset;
    private Vector3 rotation;
    private Vector3 targetPosition;
    private float cameraSpeed;

	// Use this for initialization
	void Start () {
        cameraSpeed = 8f;
        //offset = transform.position - Object.transform.position;
        rotation = transform.rotation.eulerAngles;
        transform.position = new Vector3(transform.position.x, 3.48f, -4.29f);
        rotation.x = 30.0f;
        transform.rotation = Quaternion.Euler(rotation);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (CheckTrigger.nearWall == false)
        {
            targetPosition = new Vector3(transform.position.x, 3.48f, -4.29f);
            rotation.x = 30.0f;
            //transform.rotation = Quaternion.Euler(rotation);
        } else
        {
            //transform.position = Object.transform.position + offset;
            targetPosition = new Vector3(transform.position.x, 6f, -4.29f);
            rotation.x = 90.0f;
            //transform.rotation = Quaternion.Euler(rotation);
        }
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * cameraSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(rotation), Time.deltaTime * cameraSpeed);
    }
}
