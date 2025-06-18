using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        transform.position += (speed + Score.Instance.currentScore / 100) * Time.deltaTime * Vector3.left;
    }
}
