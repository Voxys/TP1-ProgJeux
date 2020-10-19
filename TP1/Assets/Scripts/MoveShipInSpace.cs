using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShipInSpace : MonoBehaviour
{
    Rigidbody2D shipBody;
    float speed;


    void Start()
    {
        shipBody = GetComponent<Rigidbody2D>();
        speed = 100f;      
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxisRaw("Horizontal");

        if (movX < 0 )
        {
            shipBody.MoveRotation(shipBody.rotation-5);
            Debug.Log("-");
        }

        else if(movX > 0)
        {
            shipBody.MoveRotation(shipBody.rotation+5);
            Debug.Log("+");
        }

        if (Input.GetButtonDown("Jump"))
        {
            shipBody.AddForce(transform.forward * 10);
            Debug.Log(shipBody.velocity.x);
        }
    }
}
