using UnityEngine;


public class GameReady : MonoBehaviour
{
    private void Update()
    {
        ClickHandle();
    }
    private void ClickHandle()
    {
        IOnClick onClick = new OnClick();
        if (onClick.OnClick())
        {
            Score.Instance.GetHighScore();
            Score.Instance.UpdateScore();
            this.gameObject.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
}
