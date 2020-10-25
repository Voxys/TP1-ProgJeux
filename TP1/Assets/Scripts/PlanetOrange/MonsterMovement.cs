using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public float speed;
    public int direction; // -1 : gauche | 1 : droite
    public GameObject player;

    private void Start()
    {
        speed = 1f;
    }

    private void Update()
    {
        Vector3 deplacement = new Vector2(direction * speed * Time.deltaTime, 0); //deplacement
        transform.position += deplacement;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("collision");
            player.GetComponent<PlayerHP>().TakeDamage();
        }
    }

    public int GetDirection()
    {
        return direction;
    }
}
