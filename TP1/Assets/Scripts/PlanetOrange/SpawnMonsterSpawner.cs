using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsterSpawner : MonoBehaviour
{
    public GameObject spawner;
    public float intervalle;
    public int departTime;

    private void Start()
    {
        InvokeRepeating("Spawn", departTime, intervalle);
    }

    void Spawn()
    {
        Instantiate(spawner, transform.position, Quaternion.identity);
    }
}
