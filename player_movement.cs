using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float JumpForce;
    // [SerializeField] private float speed = 0f;
    public bool isCollided = false;
    public int score = 0;
    
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpForce);
        }

        // if (Input.GetKey(KeyCode.D))
        // {
        //     rb.AddForce(Vector2.right * speed * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.A))
        // {
        //     rb.AddForce(Vector2.left * speed * Time.deltaTime);
        // }
    }

   
}
