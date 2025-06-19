using UnityEngine;
using UnityEngine.InputSystem;

public class Fly : MonoBehaviour
{
    [SerializeField] private float velocity = 16f;
    [SerializeField] private float rotaionSpeed = 1f;
    private Rigidbody2D rb;
    private void Awake()
    {
        Time.timeScale = 0;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Tap();
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotaionSpeed);
    }

    private void Tap()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.velocity = Vector2.up * velocity;
            AudioManager.Instance.PlayAudioWing();

        }
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    GameManager.Instance.GameOver();
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
        AudioManager.Instance.PlayAudioHit();
    }
}
