using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    AudioSource jumpSound;

    private void Start()
    {
        jumpSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Platform !");
        Rigidbody2D playerRigid = collision.gameObject.GetComponent<Rigidbody2D>();
        if(playerRigid != null && collision.relativeVelocity.y <= 0f) 
        {
            Vector2 newVelocity = playerRigid.velocity;
            if(gameObject.tag == "Platform_High")
            {
                jumpForce = 14;
                jumpSound.Play();
            }
            newVelocity.y = jumpForce;
            playerRigid.velocity = newVelocity;
        }
    }
}
