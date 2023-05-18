using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformislemleri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
        Debug.Log(transform.rotation);
        Debug.Log(transform.localScale);

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(1f, 0f, 0f));
    }
}
