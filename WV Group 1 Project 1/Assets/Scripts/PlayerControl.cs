using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float runSpeed;
    public Rigidbody2D rb;

    private float arrowInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        arrowInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        Vector2 velocity = new Vector2(arrowInput * runSpeed, rb.velocity.y);
        rb.velocity = velocity;
    }

}
