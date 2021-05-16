﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{   
    public float speed  = 150 ; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
        void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
