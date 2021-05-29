using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerExit2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "player")
        {
            transform.position += 2*Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;
        }

    }
}