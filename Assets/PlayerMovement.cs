using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float movement = 0f;
    Rigidbody2D rigidbodyP;
    Animator animator;
    SpriteRenderer spriteRenderer;
    float bounds;

    // Start is called before the first frame update
    void Start()
    {
        speed = 7f;
        rigidbodyP = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        bounds = Camera.main.orthographicSize * Screen.width / Screen.height;       
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rigidbodyP.velocity;
        velocity.x = movement;
        rigidbodyP.velocity = velocity;
    }


    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Velocity", rigidbodyP.velocity.y);
        movement = Input.GetAxis("Horizontal") * speed;
        if(movement < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (movement > 0)
        {
            spriteRenderer.flipX = false;
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -bounds, bounds), transform.position.y, transform.position.z);
    }
}
