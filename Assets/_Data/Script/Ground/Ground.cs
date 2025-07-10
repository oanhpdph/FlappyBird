using UnityEngine;

namespace Assets._Data.Script
{
    public class Ground : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;
        public Vector2 startPosition;
        private IOutOfScreen outOfScreen;
        private void Start()
        {
            outOfScreen = new OutOfScreen();
            spriteRenderer = GetComponent<SpriteRenderer>();
            startPosition = transform.position;
            startPosition.x = 90;
        }
        private void Update()
        {
            if (outOfScreen.IsCompleteOutOfLeftScreen(spriteRenderer, Camera.main) == true)
            {
                transform.position = startPosition;
            }
            transform.position = transform.position + GameManager.Instance.speedPipe * Time.deltaTime * Vector3.left;
        }
    }
}