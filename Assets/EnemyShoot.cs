using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyShoot : MonoBehaviour
{
    public float speed;
    public float damage;
    public Transform shootpos;
    public GameObject Bullet;
    private float startingHealth;
    private float enemy_health;
    player Player;
    Rigidbody2D rigidbody2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Instantiate(Bullet, shootpos.transform.position, transform.rotation);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) { SceneManager.LoadScene(0); }
    }
}