using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayUIShip : MonoBehaviour
{
    bool coreFound = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Default") && coreFound == false)
        {
            Destroy(collision.gameObject);
            Debug.Log("HIT");
        }
    }
}
