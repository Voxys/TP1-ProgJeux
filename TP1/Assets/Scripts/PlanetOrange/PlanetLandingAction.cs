using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetLandingAction : MonoBehaviour
{
    [SerializeField]
    GameObject UI, Player, Camera;
    bool exitShipRequested;
    private void Start()
    {
        UI.SetActive(false);
        Player.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Input E");
            Camera.transform.parent = Player.transform;
            Player.SetActive(true);
            UI.SetActive(false);
            this.gameObject.GetComponent<Rigidbody2D>().simulated = false;
            // -> Probléme de collision, je désactive donc le rigidbody du vaisseau jusqu'a la prochaine activation
            
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
