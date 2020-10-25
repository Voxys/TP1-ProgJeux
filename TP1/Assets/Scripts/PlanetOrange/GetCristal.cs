using UnityEngine;
using UnityEngine.UI;

public class GetCristal : MonoBehaviour
{
    [SerializeField]
    GameObject UI, UICompteur, dialogueCristal, triggerReactivate;
    static public int compteur;

    private void Start()
    {
        UI.SetActive(false);
        dialogueCristal.SetActive(false);
        compteur = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && UI.activeInHierarchy)
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            UI.SetActive(false);
            compteur++;
            Debug.Log("Compteur: " + compteur);
            UICompteur.GetComponent<Text>().text = compteur.ToString() + " / 6";

            if (compteur == 3)
            {
                //Je passe par l'ui "button e" du vaisseau pour utiliser son box collider car le box collider du vaisseau en isTrigger le fait traverser
                triggerReactivate.GetComponent<ReactivateShip>().SetReadyToGo();
                dialogueCristal.SetActive(true);
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
        dialogueCristal.SetActive(false);

        if(this.gameObject.GetComponent<Renderer>().enabled == false)
            this.gameObject.SetActive(false);
    }

    public int GetCompteur()
    {
        return compteur;
    }
}
