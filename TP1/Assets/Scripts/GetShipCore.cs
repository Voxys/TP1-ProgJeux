using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetShipCore : MonoBehaviour
{
    bool asFoundShipCore = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            /*asFoundShipCore = true;
            Destroy(this.gameObject);*/
            Debug.Log("Yo");
        }
    }
}
