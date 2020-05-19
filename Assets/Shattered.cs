using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shattered : MonoBehaviour
{
    public float delay = 1f;
    float countdown;
    bool Collided = false;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        if (Collided)
        {
            countdown -= Time.deltaTime;
            if (countdown <= 0f)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Floor")
        {
            Collided = true;           
        }
    }
}

