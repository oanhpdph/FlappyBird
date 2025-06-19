using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private static Score instance;
    public static Score Instance => instance;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI highScoreText;

    public int currentScore = -1;
    private int highScore;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void GetHighScore()
    {
        highScoreText.text = highScore.ToString();
    }
    public void UpdateScore()
    {
        currentScore++;
        score.text = currentScore.ToString();
        UpdateHighScore();
        AudioManager.Instance.PlayAudioPoint();
    }
    private void UpdateHighScore()
    {
        if (currentScore > highScore)
        {
            highScoreText.text = currentScore.ToString();
        }
    }
}
