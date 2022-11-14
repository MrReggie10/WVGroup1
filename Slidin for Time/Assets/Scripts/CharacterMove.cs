using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector3 difference;
    [SerializeField] private GameObject pointer;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            pointer.transform.position = gameObject.transform.position + (difference * -1);
        }
        else
        {
            pointer.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if(Input.GetMouseButtonUp(0))
        {
            rb.velocity = difference * -6;
            Debug.Log(rb.velocity);
        }

    }

    void FixedUpdate()
    {
        rb.velocity -= rb.velocity * 0.1f;
    }
}
