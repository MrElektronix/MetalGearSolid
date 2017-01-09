using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    [SerializeField]
    private GameObject Object;
    private bool wall;

    private Vector3 offset;
    private Vector3 rotation;
	// Use this for initialization
	void Start () {
        offset = transform.position - Object.transform.position;
        rotation = transform.rotation.eulerAngles;
        transform.position = new Vector3(transform.position.x, 3.48f, -4.29f);
        rotation.x = 30.0f;
        transform.rotation = Quaternion.Euler(rotation);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (WallDistance.nearWall == false)
        {
            transform.position = new Vector3(transform.position.x, 3.48f, -4.29f);
            rotation.x = 30.0f;
            transform.rotation = Quaternion.Euler(rotation);
        } else
        {
            transform.position = Object.transform.position + offset;
            rotation.x = 90.0f;
            transform.rotation = Quaternion.Euler(rotation);
        }
    } 
}
