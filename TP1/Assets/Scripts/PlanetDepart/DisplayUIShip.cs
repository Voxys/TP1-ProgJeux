using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayUIShip : MonoBehaviour
{
    [SerializeField]
    GameObject UI, UI2, Hint, ShipCore, Etincelle1, Etincelle2, Repaired;

    bool hasShipCore = false;
    bool shipRepaired = false;
    int compteur = 0;

    private void Start()
    {
        UI.SetActive(false);
        UI2.SetActive(false);
        Hint.SetActive(false);
        Repaired.SetActive(false);
    }

    private void Update()
    {
        hasShipCore = ShipCore.GetComponent<GetShipCore>().GetShipCoreState();

        //Affiche les indications si le coeur du vaisseau n'a pas encore été trouvé
        if (Input.GetKeyDown(KeyCode.E) && UI.activeInHierarchy && !hasShipCore)
        {
            Hint.SetActive(true);
        }

        //Permet d'entrer dans le vaisseau seulement une fois la réparation effectuée
        if (Input.GetKeyDown(KeyCode.E) && shipRepaired)
        {
            Debug.Log("Enter ship");
            this.gameObject.GetComponent<SpaceShipControl>().activateShip();
        }

        //Désactive l'info bulle de départ et active celle d'entrer dans le vaisseau
        if (Input.GetKeyDown(KeyCode.E) && (UI.activeInHierarchy || UI2.activeInHierarchy) && hasShipCore)
        {
            shipRepaired = true;

            Etincelle1.SetActive(false);
            Etincelle2.SetActive(false);
            Repaired.SetActive(true);
            UI.SetActive(false);
            UI2.SetActive(true);           
        }

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            UI.SetActive(true);
        }              
    }

    //Desactive les UI en s'éloignant de l'objet
    private void OnTriggerExit2D(Collider2D collision)
    {
        UI.SetActive(false);
        Hint.SetActive(false);
        Repaired.SetActive(false);
        UI2.SetActive(false);
    }
}
