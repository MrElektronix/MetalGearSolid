using UnityEngine;

public class WallDistance : MonoBehaviour {

    [SerializeField]
    private GameObject wall;

    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - wall.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = wall.transform.position + offset;
    }
}
