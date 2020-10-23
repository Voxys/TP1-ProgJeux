using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    private int health = 5;
    private bool isInvincible;
    private float isInvincibleTimer = 0;

    private void Start()
    {
        isInvincible = false;
    }

    public void TakeDamage(int damage)
    {
        if (isInvincible != true)
        {
            health -= 1;
            isInvincible = true;
        }

        else if (isInvincibleTimer <= 0 && isInvincible == true)
            isInvincible = false;


        if (health <= 0)
            Die();

        if (isInvincible)
             isInvincibleTimer -= 1 * Time.deltaTime;

        Debug.Log(health);
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