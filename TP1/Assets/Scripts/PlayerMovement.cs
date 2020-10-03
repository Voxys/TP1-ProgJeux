using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerBody;
    SpriteRenderer sprite;
    float speed;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        speed = 175f;
    }

    void Update()
    {
        float movX = Input.GetAxis("Horizontal") * speed;
        float movY = Input.GetAxis("Vertical") * speed;

        if (movX < 0)
        {
            sprite.flipX = true;
        }
        else if (movX > 0)
        {
            sprite.flipX = false;
        }

        playerBody.velocity = new Vector3(movX * Time.deltaTime, playerBody.velocity.y, 0f);

        if (Input.GetButtonDown("Jump") && playerBody.velocity.y == 0)
        {
            playerBody.AddForce(Vector3.up * 300f);
        }
    }
}
