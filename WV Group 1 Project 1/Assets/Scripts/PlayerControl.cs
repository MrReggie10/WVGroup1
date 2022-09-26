using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float runSpeed;
    public Rigidbody2D rb;

    private Vector2 moveSpeed;
    private float move;
    private float moveHorizontal;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        Debug.Log(moveHorizontal);
    }

    void Move()
    {
        moveSpeed = new Vector2(moveHorizontal * runSpeed, rb.velocity.y);
        rb.velocity = moveSpeed;
    }
}
