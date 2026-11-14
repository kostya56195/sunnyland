using UnityEngine;

public class NPCWeapon : MonoBehaviour
{
    public GameObject bulletPrefab; // Префаб пули из папки Project
    public Transform shootPos;      // Точка, откуда летят пули
    public float fireRate = 0.2f;   // Скорость стрельбы (интервал между пулями)

    private float nextFireTime;
    private bool isShooting = false; // Флаг: стреляет ли оружие сейчас?
    void Start()
    {

    }

    void Update()
    {
        // GetKeyDown срабатывает ОДИН РАЗ в момент нажатия
        if (Input.GetKeyDown(KeyCode.F))
        {
          
        }

        // Если автострельба включена и пришло время для следующего выстрела
        if (isShooting && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate; // Таймер для следующего выстрела
        }
    }

    void Shoot()
    {
        if (bulletPrefab != null && shootPos != null)
        {
            Instantiate(bulletPrefab, shootPos.position, shootPos.rotation);
        }
    }
}