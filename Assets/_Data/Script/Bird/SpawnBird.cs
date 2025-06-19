using System.Collections.Generic;
using UnityEngine;

public class SpawnBird : MonoBehaviour
{
    [SerializeField] private List<GameObject> listBird;

    private void Start()
    {
        int index = Random.Range(0, listBird.Count);
        Instantiate(listBird[index], transform);
    }
}
