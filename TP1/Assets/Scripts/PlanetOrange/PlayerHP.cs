using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    private int health = 5;
    private bool isInvinsible;

    private void Start()
    {
        isInvinsible = false;    
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        SceneManager.LoadScene("Planet");
    }

    public int GetHealth()
    {
        return health;
    }

}
