using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactivateShip : MonoBehaviour
{
    [SerializeField]
    GameObject ship, UI;
    bool readyToGo;
    bool collision;

    private void Start()
    {
        readyToGo = false;
        collision = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && readyToGo && collision == true)
        {
            Debug.Log("Enter ship");
            ship.GetComponent<SpaceShipControlOrange>().ActivateShip();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer("Default") && readyToGo == true)
        {
            UI.SetActive(true);
            SetCollisionTrue();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UI.SetActive(false);
        SetCollisionFalse();
    }

    public void SetReadyToGo()
    {
        readyToGo = true;
    }

    public void SetCollisionTrue()
    {
        collision = true;
    }

    public void SetCollisionFalse()
    {
        collision = false;
    }
}
