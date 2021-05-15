using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed;

    public Text scorerightText;
    public Text scoreleftText;
    int scoreRight;
    int scoreLeft;

    void Start()
    {
        Vector2 direction = new Vector2(speed, 0);
        GetComponent<Rigidbody2D>().velocity = direction;


    }
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
        if (col.gameObject.name == "RacketLeft")
        {
            Debug.Log("RacketLeft");
            float y = hitFactor(transform.position,
            col.transform.position,
            col.collider.bounds.size.y);

            Vector2 dir = new Vector2(2, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (col.gameObject.name == "RacketRight")
        {
            Debug.Log("RacketRight");
            float y = hitFactor(transform.position,
                col.transform.position,
                col.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }


        if (col.gameObject.name == "Wallright")
        {
            scoreLeft++;
            scorerightText.text = scoreLeft.ToString();


        }

        if (col.gameObject.name == "Wallleft")
        {
            scoreRight++;
            scorerightText.text = scoreRight.ToString();
        }






        }

    }














