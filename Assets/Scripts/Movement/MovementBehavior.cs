﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementBehavior : MonoBehaviour
{
    public float Speed = 2;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, Speed) * Time.deltaTime;
    }
}
