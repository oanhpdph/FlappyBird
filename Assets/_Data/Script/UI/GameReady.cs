using UnityEngine;
using UnityEngine.InputSystem;


public class GameReady : MonoBehaviour
{

    private void Update()
    {
        ClickHandle();
    }
    private void ClickHandle()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Score.Instance.UpdateScore();
            this.gameObject.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
}
