using System;
using System.Collections;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerCollision : MonoBehaviour
{
    public GameObject replacement;
    public GameObject deathMenu;
    public GameObject Score;
    public TextMeshProUGUI HighScore;
    
    public PlayerMovement movement;
    public float delay = 1f;
    float countdown;
    bool Collided = false;
    public ParticleSystem particlePrefab = null;


    private void Start()
    {
        countdown = delay;
    }

    private void Update()
    {
        if (Collided)
        {
            GameObject.Instantiate(replacement, transform.position, transform.rotation);

            Destroy(gameObject);

            deathMenu.SetActive(true);
            Score.SetActive(false);

            
            HighScore.text = PlayerPrefs.GetInt("highScore") + "";
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            Collided = true;

            Explosion();            
        }

        
    }
    public void Explosion()
    {
        Instantiate(particlePrefab, transform.position, Quaternion.identity);
    }
}
