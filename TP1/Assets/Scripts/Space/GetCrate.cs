using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetCrate : MonoBehaviour
{
    [SerializeField]
    GameObject UI, UICompteur;
    static public int compteur;
   
    private void Start()
    {
        UI.SetActive(false);
        compteur = 3;
    }

    private void Update()
    {
        UICompteur.GetComponent<Text>().text = compteur.ToString() + " / 6";
        Debug.Log("OK");
        if (Input.GetKeyDown(KeyCode.E) && UI.activeInHierarchy)
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            UI.SetActive(false);
            compteur++;

            if (compteur == 6)
            {
                SceneManager.LoadScene("Victory");
            }
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            UI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UI.SetActive(false);

        if (this.gameObject.GetComponent<Renderer>().enabled == false)
            this.gameObject.SetActive(false);
    }
}
