using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTriggerCloud : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Clouds"))
        {
            Destroy(collision.gameObject);          
        }
    }
}
