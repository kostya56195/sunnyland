using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        // Перезапускаем текущий уровень
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}