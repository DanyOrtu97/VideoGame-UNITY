using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HintBookMD1 : MonoBehaviour
{
    
    public GameObject alertGuiB;
  
    public GameObject panelGuiB;
    public GameObject alertGuiPanelB;



    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("PlayerB"))
        {
            alertGuiB.gameObject.SetActive(true);
            alertGuiB.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per leggere il libro";

        }
    }
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.CompareTag("PlayerB"))
        {

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
            {
                alertGuiB.gameObject.SetActive(false);
                panelGuiB.gameObject.SetActive(true);
                alertGuiPanelB.gameObject.GetComponent<Text>().text = "\t\t Lezione di magia base 2 \n Un " +
                    "semplice ed efficace metodo per contrastare un " +
                    "incantesimo e' l’utilizzo del prefisso “de”, talvolta puo' non funzionare " +
                    "contro incantesimi di alto livello"
;
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("PlayerB"))
        {
            panelGuiB.gameObject.SetActive(false);
            alertGuiB.gameObject.SetActive(false);
        }
    }
}
