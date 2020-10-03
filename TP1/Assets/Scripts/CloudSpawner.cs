using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;

    private void Start()
    {
        InvokeRepeating("Spawn", 0, 20f);
    }

    void Spawn()
    {
        Instantiate(cloud, transform.position, Quaternion.identity);
    }
}
