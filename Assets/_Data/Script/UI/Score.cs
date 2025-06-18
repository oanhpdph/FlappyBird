using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private static Score instance;
    public static Score Instance => instance;
    [SerializeField] private TextMeshProUGUI score;

    public int currentScore = -1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void UpdateScore()
    {
        currentScore++;
        score.text = currentScore.ToString();
        AudioManager.Instance.PlayAudioPoint();
    }
}
