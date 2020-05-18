using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public float delay = 2f;
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
            

            movement.enabled = false;
            countdown -= Time.deltaTime;
            if (countdown <= 0f)
            {
                SceneManager.LoadScene("SampleScene");               
            }
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            Collided = true;
                      
        }
    }
}
