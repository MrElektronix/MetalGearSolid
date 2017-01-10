using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 2f;
    private Transform pos;
    

    // Use this for initialization
    void Start()
    {
   
    }


    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //transform.Rotate(0, x, 0);
        transform.Translate(x, 0, z);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 4;
        }
        else
        {
            speed = 2;
        }
    }
}
	
	
