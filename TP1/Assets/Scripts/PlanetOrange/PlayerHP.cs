using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    GameObject healthUI;
    static private int health = 100;
    static private bool isInvincible;
    private float isInvincibleTimer = 3;
    private float compteur;
    private float compteurMax;

    private void Start()
    {
        isInvincible = false;
        compteur = 0;
        compteurMax = 2;
    }

    private void Update()
    {
        healthUI.GetComponent<Text>().text = health.ToString();

        //Tant que le joueur est invisible car TakeDamage à été activé, compte en seconde
        if(isInvincible == true)
        {
            compteur += Time.deltaTime;
        }

        //Remet à 0 au bout du nombre de secondes désirées ( compteurMax )
        if (compteur >= compteurMax)
        {
            compteur = 0;
            isInvincible = false;
        }
    }
    
    //Est activé suite à une collision avec le joueur dans MonsterMovement 
    public void TakeDamage()
    {
        if (!isInvincible)
        {
            health -= 20;
            isInvincible = true;
        }    

        if (health <= 0)
            Die();

        //Debug.Log("Health: " + health + " isInvincibleTimer: " + isInvincibleTimer);
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