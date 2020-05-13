using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(bulletPrefab) as GameObject;
        Random.Range(-screenBounds.x, screenBounds.x);
    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
