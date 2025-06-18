using UnityEngine;
using UnityEngine.InputSystem;

public class GameOver : MonoBehaviour
{
    private void Update()
    {
        ClickHandle();
    }
    private void ClickHandle()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameManager.Instance.RestarGame();
        }
    }
}