using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{
    public float speed;
    public int direction; // -1 : gauche | 1 : droite
    public float compteur;

    private void Start()
    {
        compteur = 0;
    }

    private void Update()
    {
        Vector3 deplacement = new Vector2(direction * speed * Time.deltaTime, 0); //deplacement
        transform.position += deplacement;

        compteur += Time.deltaTime;
    }
}
