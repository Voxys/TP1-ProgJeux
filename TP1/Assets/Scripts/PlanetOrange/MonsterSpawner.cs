using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject monster;
    private int direction;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 0);
        direction = monster.GetComponent<MonsterMovement>().GetDirection();    
    }

    void Spawn()
    {
        monster = Instantiate(monster, transform.position, Quaternion.identity);
     
        if(direction == -1)
            monster.transform.Rotate(0, 0, 90);
        else
            monster.transform.Rotate(0, 0, -90);
    }
}
