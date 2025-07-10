using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private List<Sprite> pipe;
    [SerializeField] private SpriteRenderer topSpriteRenderer;
    [SerializeField] private SpriteRenderer bottomSpriteRenderer;
    private IOutOfScreen outOfScreen;
    private void Start()
    {
        outOfScreen = new OutOfScreen();
    }
    private void Update()
    {
        transform.position += GameManager.Instance.speedPipe * Time.deltaTime * Vector3.left;
        if (outOfScreen.IsCompleteOutOfLeftScreen(topSpriteRenderer, Camera.main) && outOfScreen.IsCompleteOutOfLeftScreen(bottomSpriteRenderer, Camera.main))
        {
            gameObject.SetActive(false);
        }
    }
    public void Render()
    {
        int index = Random.Range(0, pipe.Count);
        topSpriteRenderer.sprite = pipe[index];
        bottomSpriteRenderer.sprite = pipe[index];
    }
}
