using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myscript : MonoBehaviour
{
    
    
    [SerializeField] private GameObject myobject;
    [SerializeField] private GameObject cube;
    [SerializeField] private float distance = 4;

    private GameObject myobjectclone;
    private GameObject myobjectclone2;
    private bool isGoingRight = true;
   
    void Start()
    {
        myobjectclone = Instantiate(myobject);
        myobjectclone2 = Instantiate(cube);
        myobjectclone.transform.position = new Vector3(5f,4f,4f);
        myobjectclone2.transform.position = new Vector3(2f, 1f, 4f);

        myobjectclone2.transform.rotation = Quaternion.Euler(90,90,90);



        StartCoroutine(MyCoroutine());
        //_currentTime = _timer;


    }


    private IEnumerator MyCoroutine()
    {

        while (true)
        {
            if (isGoingRight)
            {
                if (myobjectclone.transform.position.y < distance)
                {
                    myobjectclone.transform.position += Vector3.up * 0.005f;
                    myobjectclone.transform.rotation = Quaternion.Euler(new Vector3 (90,0,0));
                    myobjectclone2.transform.Rotate(20f*Time.deltaTime, 30f*Time.deltaTime, 10f*Time.deltaTime, Space.World);
                    //myobjectclone2.transform.LookAt(myobjectclone.transform);

                }
                else
                {
                    isGoingRight = false;
                }
            }
            else // sola gidiyorsa
            {
                if (myobjectclone.transform.position.y > -distance)
                {
                    myobjectclone.transform.position += Vector3.down * 0.005f;
                    myobjectclone.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
                    myobjectclone2.transform.Rotate(2f, 3f, 1f, Space.Self);
                    //myobjectclone2.transform.LookAt(myobjectclone.transform);

                }
                else
                {
                    isGoingRight = true;
                }
            }




        
           
            
        }
    }


    //private const float _timer = 1;
    //private float _currentTime;

    //private void Update()
    //{
    //    if (_currentTime > 0)
    //    {
    //        _currentTime -= Time.deltaTime;
    //    }
    //    else
    //    {
    //        var myobjectclone = Instantiate(myobject);
    //        myobjectclone.transform.position = new Vector3(offset, 0, 0);

    //        offset++;
    //        _currentTime = _timer;
    //    }
    //}
}
