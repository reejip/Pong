using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
public float minY;
public float maxY;
public float distance;
void OnTriggerEnter2D(Collider2D coll)
{
    if(coll.tag == "Obstacle")
    {

    float obstacleY = Random.Range(minY, maxY);
    Vector3 spawnPosition = new Vector3(transform.position.x + distance, obstacleY, 0);
    coll.gameObject.transform.position = spawnPosition;
    }
}
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

