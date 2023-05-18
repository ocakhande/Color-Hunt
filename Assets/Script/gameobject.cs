using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SelectionBase]
public class gameobject : MonoBehaviour
{
    [SerializeField] private GameObject _myObject;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("myobject").GetComponent<ilkdosyam>().maas = 15;

        //_myObject.GetComponent<ilkdosyam>().maas = 15;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MaasArttir()
    {
        _myObject.GetComponent<ilkdosyam>().maas = 20;
        GetComponent<Transform>();
        

    }
}

public class BaskaClass : MonoBehaviour
{
    private gameobject gameObject;

    private void Start()
    {
        gameObject.MaasArttir();
    }
}