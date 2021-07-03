using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform reejipTransform;
    Vector3 range;

    void Awake()
    {
        range = transform.position - reejipTransform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(range.x + reejipTransform.position.x, transform.position.y, range.z + reejipTransform.position.z); 

    }
}
