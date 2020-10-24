using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetLandingAction : MonoBehaviour
{
    [SerializeField]
    GameObject UI, Player, Camera;
    bool exitShipRequested;
    bool shipExited;

    private void Start()
    {
        UI.SetActive(false);
        Player.SetActive(false);
        shipExited = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !shipExited)
        {
            Debug.Log("Input E");
            Camera.transform.parent = Player.transform;
            Player.SetActive(true);
            UI.SetActive(false);
            shipExited = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            UI.SetActive(true);
        }
    }
}
