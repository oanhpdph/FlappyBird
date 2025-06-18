using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Data.Script.Pipe
{
    public class PipeSpawn : MonoBehaviour
    {
        [SerializeField] private GameObject pipePrefab;
        [SerializeField] private float maxTime = 2;
        [SerializeField] private float heightRange = 0.5f;
        private float timer = 0;
        private float realTime = 2;
        private List<GameObject> listPipe;
        private void Start()
        {
            listPipe = new List<GameObject>();
        }
        private void Update()
        {
            timer += Time.deltaTime;
            if (timer > realTime)
            {
                realTime = Random.Range(1.5f, maxTime);
                SpawnPipe();
                timer = 0;
            }
        }

        private void SpawnPipe()
        {
            GameObject pipe = GetPipe();
            Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(0, heightRange), 0);

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
            StartCoroutine(ResetPipe(pipe));
        }
        private IEnumerator ResetPipe(GameObject pipe)
        {
            yield return new WaitForSeconds(5f);
            pipe.SetActive(false);
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
    }
}