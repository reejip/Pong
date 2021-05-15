using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text scorerightText;
    public Text scoreleftText;
    int scoreRight;
    int scoreLeft;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Wallright")
        {
            scoreLeft++;
            scoreleftText.text = scoreLeft.ToString();
        }


        if (col.gameObject.name == "Wallleft")

        {
            scoreRight++;
            scorerightText.text = scoreLeft.ToString();
        }
    }
} 







