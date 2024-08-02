using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // Oyunu durdur
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Oyunu yeniden ba�lat
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Ge�erli sahneyi yeniden y�kle
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f; // Oyunu yeniden ba�lat
        SceneManager.LoadScene("MainMenu"); // Ana men� sahnesini y�kle
    }
}
