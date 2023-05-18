using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class fizikyakalama : MonoBehaviour
{
    //[SerializeField] private GameObject bykure;
   
    private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.name == "bykure") { 
        Debug.Log("etkilesim var");
        Destroy(gameObject);
}
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name=="bykure")
        Debug.Log("etkilesim bitti");
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name=="bykure")
        Debug.Log("etkilesim sürüyor");
    }

}
