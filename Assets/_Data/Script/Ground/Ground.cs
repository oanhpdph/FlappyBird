using UnityEngine;

namespace Assets._Data.Script
{
    public class Ground : MonoBehaviour
    {
        [SerializeField] private float speed = 3.0f;
        [SerializeField] private float width = 10f;
        private SpriteRenderer spriteRenderer;

        private Vector2 startSize;
        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            startSize = new Vector2(spriteRenderer.size.x, spriteRenderer.size.y);
        }
        private void Update()
        {
            spriteRenderer.size = new Vector2(spriteRenderer.size.x + speed * Time.deltaTime, spriteRenderer.size.y);
            if (spriteRenderer.size.x > width)
            {
                spriteRenderer.size = startSize;
            }
        }
    }
}