using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform tf;
    public float moveSpeed = 15f;

    float maxHeight = 2.25f;
    float minHeight = -2.2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = tf.position;

        if(Input.GetKey(key:KeyCode.W))
        {
            pos.y += moveSpeed * Time.deltaTime;  
        }


        if (Input.GetKey(key: KeyCode.S))
        {
            pos.y -= moveSpeed * Time.deltaTime;  
        }


        tf.position = pos;
    }
}
