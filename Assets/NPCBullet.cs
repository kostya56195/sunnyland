using UnityEngine;

public class NPCBullet : MonoBehaviour
{
    public float speed = 10f;
    public float damage = 2f;
    public Transform shootpos;
    private NPCBullet npc_bullet;
    public GameObject Enemyb1;
    public float lifetime = 3f; // Время жизни пули, чтобы они не копились в памяти бесконечно

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Задаем скорость в левую сторону сразу при создании пули
        rb.linearVelocity = Vector2.left * speed;
        damage = 1;


        // Уничтожить пулю через lifetime секунд, если она ни во что не попала
        Destroy(gameObject, lifetime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Проверяем столкновение с игроком
        if (collision.gameObject.CompareTag("Player"))
        {
           Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(npc_bullet, shootpos.transform.position, transform.rotation);
        }
        Destroy(gameObject, 2f);
    }
}