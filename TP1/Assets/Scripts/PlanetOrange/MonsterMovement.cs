using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public float speed;
    public int direction; // -1 : gauche | 1 : droite
    public float compteur;
    public GameObject player;
    public int damage;

    private void Start()
    {
        speed = 1f;
        compteur = 0;
        damage = 1;
    }

    private void Update()
    {
        Vector3 deplacement = new Vector2(direction * speed * Time.deltaTime, 0); //deplacement
        transform.position += deplacement;

        compteur += Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            player.GetComponent<PlayerHP>().TakeDamage(damage);
            
            //Debug.Log(damage);
            Debug.Log(player.GetComponent<PlayerHP>().GetHealth());
        }
    }

    public int GetDirection()
    {
        return direction;
    }
}
