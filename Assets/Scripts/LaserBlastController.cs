﻿using UnityEngine;
using System.Collections;

public class LaserBlastController : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 0.5f * Time.deltaTime;
    }
}
