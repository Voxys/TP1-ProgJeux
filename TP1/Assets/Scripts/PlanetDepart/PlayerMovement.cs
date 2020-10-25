using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerBody;
    SpriteRenderer sprite;
    [SerializeField]
    public float speed;
    public Animator animator;
    public int compteur;
    bool canJump;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        speed = 175f;
        compteur = 0;
        canJump = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && playerBody.velocity.y == 0 || Input.GetButtonDown("Jump") && compteur == 1 || Input.GetButtonDown("Jump") && canJump && compteur == 0)
        {
            playerBody.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            animator.SetTrigger("Jump");
            compteur++;
        }

        if (compteur > 1)
            compteur = 0;
    }

    private void FixedUpdate()
    {
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canJump = false;
    }
}
