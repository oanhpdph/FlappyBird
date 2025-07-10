using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void Update()
    {
        ClickHandle();
    }
    private void ClickHandle()
    {
        IOnClick onClick = new OnClick();
        if (onClick.OnClick())
            GameManager.Instance.RestarGame();
    }
}
