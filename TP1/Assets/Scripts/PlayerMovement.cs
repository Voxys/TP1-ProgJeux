using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerBody;
    SpriteRenderer sprite;
    [SerializeField]
    public float speed;

    bool jump;

    public Animator animator;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        speed = 175f;
    }

    void Update()
    {
        //float movY = Input.GetAxis("Vertical") * speed;
        float movX = Input.GetAxisRaw("Horizontal") * speed;

        animator.SetFloat("Speed", Mathf.Abs(movX));

        if (movX < 0)
        {
            sprite.flipX = true;
        }
        else if (movX > 0)
        {
            sprite.flipX = false;
        }

        playerBody.velocity = new Vector3(movX * Time.deltaTime, playerBody.velocity.y, 0f);

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {     
        if (jump)
        {
            jump = false;
            playerBody.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            animator.SetTrigger("Jump");
        }
    }


}
