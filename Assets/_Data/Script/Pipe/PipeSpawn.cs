using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float maxTime = 1.7f;
    [SerializeField] private float heightRange = 12f;
    private float timer = 0;
    private List<GameObject> listPipe;
    private float deltaY = 1;

    private float minY = -4;
    private float maxY = 6;

    private float lastY = 0;
    private int maxContinuous = 3;
    private int currentContinuous = 1;
    private Vector3 spawnPos;
    private void Start()
    {
        listPipe = new List<GameObject>();
        lastY = Random.Range(minY, maxY);
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }
    }
    private GameObject GetPipe()
    {
        foreach (GameObject item in listPipe)
        {
            if (item.activeSelf == false)
            {
                return item;
            }
        }
        return default;
    }

    private void SpawnPipe()
    {
        SpawnOne(this.spawnPos);
        GetSpawnPosition();
        float random = Random.Range(0, 1 + GameManager.Instance.proportion);
        if (random <= 1 || currentContinuous > maxContinuous)// 
        {
            deltaY = 5;
            maxTime = 1.7f;
            currentContinuous = 1;
        }
        else
        {
            maxTime = 0.65f;
            deltaY = 1;
            currentContinuous++;
        }
    }
    private void SpawnOne(Vector3 spawnPos)
    {
        GameObject pipe = GetPipe();

        if (pipe == default)
        {
            pipe = Instantiate(pipePrefab, spawnPos, Quaternion.identity);

            listPipe.Add(pipe);
        }
        else
        {
            pipe.transform.position = spawnPos;
            pipe.SetActive(true);
        }
    }
    private void OnEnable()
    {
        GetSpawnPosition();
    }
    private void GetSpawnPosition()
    {
        float heigh = Random.Range(deltaY / 2, deltaY);
        float newY = Mathf.Clamp(lastY + Mathf.Sign(Random.Range(-1, 1)) * heigh, minY, maxY);
        lastY = newY;
        spawnPos = new(transform.position.x, lastY, 0);
    }
}
