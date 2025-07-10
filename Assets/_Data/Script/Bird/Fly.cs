using UnityEngine;

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
        IOnClick onClick = new OnClick();
        if (onClick.OnClick())
        {
            rb.velocity = Vector2.up * velocity;
            AudioManager.Instance.PlayAudioWing();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
        AudioManager.Instance.PlayAudioHit();
    }
}
