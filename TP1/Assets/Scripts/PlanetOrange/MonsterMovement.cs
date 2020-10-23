using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public float speed;
    public int direction; // -1 : gauche | 1 : droite
    public GameObject player;
    public int damage;

    private void Start()
    {
        speed = 1f;
        damage = 1;
    }

    private void Update()
    {
        Vector3 deplacement = new Vector2(direction * speed * Time.deltaTime, 0); //deplacement
        transform.position += deplacement;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            Debug.Log("collision");
            player.GetComponent<PlayerHP>().TakeDamage(1);
        }
    }

    public int GetDirection()
    {
        return direction;
    }
}
