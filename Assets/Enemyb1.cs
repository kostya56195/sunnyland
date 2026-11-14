using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Enemyb1 : MonoBehaviour
{
    [SerializeField] private float startingHealth = 1200f; // Начальное здоровье (например, 30)
    [SerializeField] private float damagePerShot = 8f;  // Урон от одного выстрела (30 / 10 = 3 выстрела)


    private float enemy_health;
    private float damage;
    void Start()
    {
        // Инициализируем здоровье максимальным значением при старте
        enemy_health = startingHealth;
        damage = 6f;

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверяем столкновение с пулей
        if (collision.CompareTag("Bullet"))
        {
            // Наносим урон
            TakeDamage(damagePerShot);

            // Уничтожаем объект пули, чтобы она не летела дальше (опционально)
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }

    public void TakeDamage(float _damage)
    {
        // Вычитаем урон и ограничиваем здоровье в пределах от 0 до startingHealth
        enemy_health = Mathf.Clamp(enemy_health - _damage, 0, startingHealth);

        // Проверяем смерть после каждого получения урона
        if (enemy_health <= 0)
        {
            Die();
            if (CoinManager.instance != null)
            {
                CoinManager.instance.AddCoins(20);
            }
        }
    }

    private void Die()
    {
        // Логика смерти врага
        Destroy(gameObject);
    }
}