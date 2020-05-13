using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    public int xPos;
    public int zPos;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(bulletPrefab) as GameObject;
        a.transform.position = new Vector3(15, Random.Range(1.57f, 9.42f), -2);
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
