using System.Collections.Generic;
using UnityEngine;


public class Background : MonoBehaviour
{
    [SerializeField] private SpriteRenderer background;

    [SerializeField] private List<Sprite> listBackground;

    [SerializeField] private float maxTime = 30f;
    private float realTime = 0;
    private int index = 0;
    private void Update()
    {
        realTime += Time.deltaTime;
        if (realTime > maxTime)
        {
            realTime = 0;
            background.sprite = listBackground[index];
            index++;
            if (index == listBackground.Count)
            {
                index = 0;
            }
        }
    }
}
