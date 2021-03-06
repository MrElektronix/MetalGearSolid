﻿using UnityEngine;

public class CheckTrigger : MonoBehaviour {
    public static bool NearWall;
    public static bool NearStair;
    public static bool NearHallway;

    private void Start()
    {
        NearWall = false;
        NearStair = false;
        NearHallway = false;
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
        if (other.gameObject.CompareTag("hallwaytrigger"))
        {
            NearHallway = true;
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
        if (other.gameObject.CompareTag("hallwaytrigger"))
        {
            NearHallway = false;
        }
    }
}
