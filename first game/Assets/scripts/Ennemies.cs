using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ennemies : MonoBehaviour
{
    public int index;
 void OnCollisionEnter2D(Collision2D col)
 {
        SceneManager.LoadScene(index);
 }
  
}
