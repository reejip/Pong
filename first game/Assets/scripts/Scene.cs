﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
  
public int index;
    void OnTriggerEnter2D(Collider2D col)
    {

    if (col.CompareTag("Player"))
    {
        SceneManager.LoadScene(index);
    }
    // Star is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}