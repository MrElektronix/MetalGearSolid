﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //private float speed = 2f;
    private Transform _pos;

    // Use this for initialization
    private void Start()
    {

    }


    private void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        //transform.Rotate(0, x, 0);
        transform.Translate(x, 0, z);
    }
}
	
	
	
