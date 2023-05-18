using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilkdosyam : MonoBehaviour
{
    public int yas;
    public int maas;
    public string isim;
    public string[] cocuklar; 
    void Start()
    {
     
        Debug.Log(isim);
        Debug.Log(yas);
        Debug.Log(maas);
        foreach (string s in cocuklar)
        {
            Debug.Log(s);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
