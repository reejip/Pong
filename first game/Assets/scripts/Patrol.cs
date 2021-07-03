﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
     Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
        private bool IsFacingRight()
        {
            return transform.localScale.x > Mathf.Epsilon;
        }

    // Update is called once per frame
    void Update()
    {
      if(IsFacingRight())
      {
      rb.velocity = new Vector2( moveSpeed, 0f);
      }
      else
      {
            rb.velocity = new Vector2(-moveSpeed, 0f);

      }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), transform.localScale.y);
    }
}
