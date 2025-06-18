using UnityEngine;

namespace Assets._Data.Script.UI
{
    public class PipeIncreatseScore : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                Score.Instance.UpdateScore();
            }
        }
    }
}
