using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformUp : MonoBehaviour
{
    private float speed;
    private bool movingDown;

    private void Start()
    {
        speed = 3;
    }
    private void Update()
    {
        if (transform.position.y < 8 && !movingDown)
        { 
            Vector3 moveUp = new Vector2(0, speed * Time.deltaTime); //deplacement
            transform.position += moveUp;
        }
        else
        {
            movingDown = true;
            Vector3 moveDown = new Vector2(0, speed * Time.deltaTime); //deplacement
            transform.position -= moveDown;

            if (transform.position.y < 4)
                movingDown = false;
        }
    }
}
