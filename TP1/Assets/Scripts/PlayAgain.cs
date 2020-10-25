using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    [SerializeField]
    private GameObject player;   
    
    public void Restart() 
    {
        SceneManager.LoadScene("Planet");
        player.GetComponent<PlayerHP>().SetHealthDefault();
    }   
}
