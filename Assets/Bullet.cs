using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{

    public float speed;
    public float damage;
    private GameObject player;
    public Enemy enemy;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        damage = 2;
        player = GameObject.FindWithTag("Player");
        if (player.transform.localScale.x > 0)
        {
            rb.linearVelocity = transform.right * speed;
        }
        else
        {
            rb.linearVelocity = -transform.right * speed;
        }
    }
}


  