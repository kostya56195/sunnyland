using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float startingHealth;
    public float currentHealth;
    private bool dead;
    private float Damage;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = startingHealth;
        Damage = 1f;
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPCBullet"))
        {
            currentHealth = Mathf.Clamp(currentHealth - Damage,0,startingHealth);
        }
    }
    public void AddHealth(float _add)
    {
        currentHealth = Mathf.Clamp(currentHealth + _add, 0, startingHealth);
    }
}
