using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += Vector3.forward * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += Vector3.left * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += Vector3.right * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position += Vector3.back * Time.deltaTime;

        }
    }
}
