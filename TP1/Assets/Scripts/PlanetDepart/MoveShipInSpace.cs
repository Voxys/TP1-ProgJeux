using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveShipInSpace : MonoBehaviour
{
    Rigidbody2D shipBody;


    void Start()
    {
        shipBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxisRaw("Horizontal");

        if (movX < 0 )
        {
            shipBody.MoveRotation(shipBody.rotation+2);
        }

        else if(movX > 0)
        {
            shipBody.MoveRotation(shipBody.rotation-2);
        }

        if (Input.GetButtonDown("Jump"))
        {
            shipBody.AddForce(transform.forward * 10);
        }
    }

    //Transition vers planéte Orange
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Planet Orange")
        {
            SceneManager.LoadScene("Planet Orange");
        }
    }
}
