using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipControl : MonoBehaviour
{
    [SerializeField]
    GameObject Player, Camera;
    Rigidbody2D rb;

    bool isActivated;

    public void activateShip()
    {
        //Changer la caméra de parent
        Camera.transform.parent = this.gameObject.transform;
        Player.SetActive(false);
        isActivated = true;
    }

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   
    public void Update()
    {
        if (Input.GetButtonDown("Jump") && isActivated)
        {
            rb.AddForce(transform.up * 10);
        }
    }

   
}
