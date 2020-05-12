using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    private Rigidbody rb;
    public Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector2(-bulletSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(-bulletSpeed, 0);

        if(transform.position.x < -50f)
        {
            Destroy(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * bulletSpeed * Time.deltaTime));
    }
}
