﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bird : MonoBehaviour
{
    public float speed = 5f;

    [SerializeField]

    Rigidbody2D rb2b;
    private float flapForce = 200f;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "grond")
        {
            Debug.Log("hit");
        }

        void OnTriggerExit2D(Collider2D Col)
        {
            if (Col.gameObject.tag == "player")
            {
                transform.position += Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;
            }

        }








        // Start is called before the first frame update
        void Start()
        {
            rb2b = GetComponent<Rigidbody2D>();

            rb2b.velocity = Vector2.right * speed * Time.deltaTime;




        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2b.velocity = Vector2.right * speed * Time.deltaTime;

                rb2b.AddForce(Vector2.up * flapForce);
            }
        }





    }
}
