using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet mermiPrefab;
    [SerializeField] private Transform bulletSpawnPoint;
    


    bool bulletSpawned = false;
    private Bullet mermi;

    private bool canFire = true;


    public Color color;
    public List<Color> colors = new List<Color>();

    private void Start()
    {
        CreateBullet();
    }


    private IEnumerator CooldownRoutine()
    {
        canFire = false;

        yield return new WaitForSeconds(1);

        canFire = true;
    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0) && bulletSpawned)
        {
            AddForces();
            //StartCoroutine(CooldownRoutine());
        }

        if (Input.GetMouseButtonDown(0) && bulletSpawned==false)
        {
            CreateBullet();
        }

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += Camera.main.transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += -Camera.main.transform.right * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += Camera.main.transform.right * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= Camera.main.transform.forward * Time.deltaTime;

        }

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 1, gameObject.transform.position.z);
    }



    public int GenerateNumber()
    {
        return Random.Range(0, colors.Count);
    }
    public void CreateBullet()
    {
        bulletSpawned = true;
        mermi = Instantiate(mermiPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
        mermi.transform.parent = bulletSpawnPoint;
        mermi.GetComponent<MeshRenderer>().material.color = colors[GenerateNumber()];
        mermi.GetComponent<Rigidbody>().useGravity = false;
        mermi.GetComponent<Rigidbody>().isKinematic = true;
    }
    public void AddForces()
    {
        bulletSpawned = false;
        mermi.GetComponent<Rigidbody>().useGravity = true;
        mermi.GetComponent<Rigidbody>().isKinematic = false;
        mermi.GetComponent<Rigidbody>().AddForce(bulletSpawnPoint.forward * 1000);

    }
}

