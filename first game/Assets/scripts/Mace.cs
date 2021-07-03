using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace : MonoBehaviour
{

private Vector3 StartPos;
    // Start is called before the first frame update
    void Start()
    {
      StartPos = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = StartPos + 2*new Vector3(0f, Mathf.Sin(Time.time), 0f);
    }
}
