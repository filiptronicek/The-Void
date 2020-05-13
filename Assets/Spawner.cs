using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;
   
    void Start()
    {
        WaitSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerable WaitSpawner()
    {
        yield return new WaitForSeconds (startWait);

        while (!stop)
        {
          

            Vector3 spawnPosition = new Vector3(1, Random.Range(-spawnValues.y, spawnValues.y), 1);

            Instantiate (bulletPrefab, spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
