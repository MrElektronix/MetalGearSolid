using UnityEngine;
using System.Collections;

public class CheckTrigger : MonoBehaviour {
    public static bool nearWall;

    void Start()
    {
        nearWall = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("walltrigger"))
        {
            nearWall = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("walltrigger"))
        {
            nearWall = false;
        }
    }


}
