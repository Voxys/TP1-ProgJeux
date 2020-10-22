using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsterSpawner : MonoBehaviour
{
    public GameObject spawner;
    public float intervalle;

    private void Start()
    {
        InvokeRepeating("Spawn", 0, intervalle);
    }

    void Spawn()
    {
        Instantiate(spawner, transform.position, Quaternion.identity);
    }
}
