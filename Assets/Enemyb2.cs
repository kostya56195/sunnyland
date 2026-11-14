using UnityEngine;

public class Enemyb2 : MonoBehaviour
{
    [SerializeField] private float startingHealth = 1200f;
    [SerializeField] private float damagePerShot = 10f;

    private float enemy_health;
    private bool isDead = false;

    void Start()
    {
        enemy_health = startingHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet") && !isDead)
        {
            TakeDamage(damagePerShot);
            Destroy(collision.gameObject);
        }
    }

    public void TakeDamage(float _damage)
    {
        if (isDead) return;

        enemy_health -= _damage;

        Debug.Log("Здоровье врага: " + enemy_health);

        if (enemy_health <= 0)
        {
            isDead = true;

            if (CoinManager.instance != null)
            {
                CoinManager.instance.AddCoins(20);
            }

            Destroy(gameObject);
        }
    }
}