using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDown : MonoBehaviour
{
    [SerializeField]
    private GameObject cam, player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y-3, cam.transform.position.z);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + 3, cam.transform.position.z);
    }

}
