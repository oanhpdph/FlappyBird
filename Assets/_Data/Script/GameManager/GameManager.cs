using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverCanvas;

    private static GameManager instance;
    public static GameManager Instance => instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 0f;
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
