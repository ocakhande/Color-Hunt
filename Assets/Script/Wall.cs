using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Wall : MonoBehaviour
{


    [SerializeField] TMP_Text counterText;
    [SerializeField] private GameObject smokePrefab;
    [SerializeField] private ParticleSystem dollarPrefab;



    int counter = 0;


    void Start()
    {
        counterText.text = counter + "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            var smoke = Instantiate(smokePrefab, other.gameObject.transform.position, other.gameObject.transform.rotation);
            ParticleSystem ps = smoke.GetComponent<ParticleSystem>();
            var main = ps.main;


            if (other.gameObject.GetComponent<Renderer>().material.color == gameObject.GetComponent<Renderer>().material.color)
            {
                var dollar = Instantiate(dollarPrefab, other.transform.position, other.gameObject.transform.rotation);

                ChangeCounterText();
            }
            else
            {
                main.startColor = Color.black;
            }

            Destroy(other.gameObject);
        }
    }


    public void ChangeCounterText()
    {
        counter++;
        counterText.text = counter + "";

    }
}