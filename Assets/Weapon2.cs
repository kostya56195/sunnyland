using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    public Transform shootpos;
    public GameObject Bullet;
    void Start()
    {
    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) || Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bullet, shootpos.transform.position, transform.rotation);
        }
    }
}