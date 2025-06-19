using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private List<Sprite> pipe;
    [SerializeField] private SpriteRenderer topSpriteRenderer;
    [SerializeField] private SpriteRenderer bottomSpriteRenderer;


    private void Update()
    {
        transform.position += (speed + Score.Instance.currentScore / 100) * Time.deltaTime * Vector3.left;
    }
    public void Render()
    {
        int index = Random.Range(0, pipe.Count);
        topSpriteRenderer.sprite = pipe[index];
        bottomSpriteRenderer.sprite = pipe[index];
    }
}
