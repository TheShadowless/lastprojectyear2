using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    void Awake() => Instance = this;

    public void GameOver()
    {
        Debug.Log("Game Over!");
        // Show Game Over UI
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
