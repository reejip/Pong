using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float gravity = 0f;
    // Update is called once per frame
    Vector2 speed;

    void Start()
    {
        Vector2 speed = new Vector2(1, 1);
        GetComponent<Rigidbody2D>().velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        gravity = Input.GetAxis("Vertical") * -1;
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
}

