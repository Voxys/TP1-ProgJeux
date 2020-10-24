using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipControlOrange : MonoBehaviour
{
    [SerializeField]
    GameObject Player, Camera;
    Rigidbody2D rb;

    bool isActivated;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {       
        if (Input.GetButtonDown("Jump") && isActivated)
        {
            rb.AddForce(transform.up * 20);
        }
    }

    public void ActivateShip()
    {
        Debug.Log("Activate ok");
        Camera.transform.parent = this.gameObject.transform;
        Debug.Log("Camera ok");
        Player.SetActive(false);
        Debug.Log("Player ok");
        isActivated = true;
    }
}

