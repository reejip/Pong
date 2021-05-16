using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    int Sum(int a, int b)
    {
        return a + b;
    }
    int prod(int a, int b)
    {
        return a + b;
    }
    float Div(float a, float b)
    {
        if (b == 0)
        {
            Debug.Log("error");
            return 0;
        }
        return a / b;
    }
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Sum(9,7));
        Debug.Log(prod(5,5));
        Debug.Log(Div(10,2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
