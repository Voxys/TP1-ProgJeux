using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed;
    public float left;
    public float compteur; 
    
    void Start()
    {
        speed = 1f;
        left = -1;
        compteur = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deplacement = new Vector2(left * speed * Time.deltaTime, 0); //deplacement
        transform.position += deplacement;

        compteur += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Limit"))
        {
            Debug.Log("Cloud hit wall");
        }


    }
}
