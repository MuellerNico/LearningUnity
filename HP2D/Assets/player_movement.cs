using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 2000;
    Vector2 velocity;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        rb.position += velocity.normalized * speed * Time.deltaTime;      
    }
}
