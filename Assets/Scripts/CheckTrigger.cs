using UnityEngine;

public class CheckTrigger : MonoBehaviour {
    public static bool NearWall;
    public static bool NearStair;

    private void Start()
    {
        NearWall = false;
        NearStair = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("walltrigger"))
        {
            NearWall = true;
        }
        if (other.gameObject.CompareTag("stairtrigger"))
        {
            NearStair = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("walltrigger"))
        {
            NearWall = false;
        }
        if (other.gameObject.CompareTag("stairtrigger"))
        {
            NearStair = false;
        }
    }


}
