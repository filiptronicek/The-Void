using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    private Rigidbody rb;
    public Vector3 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-bulletSpeed, 0);
        moveCharacter(movement);
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(-bulletSpeed, 0);

        if(transform.position.x < -10f)
        {
            Destroy(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector3 direction)
    {
        rb.MovePosition((Vector3)transform.position + (direction * bulletSpeed * Time.deltaTime));
    }
}
