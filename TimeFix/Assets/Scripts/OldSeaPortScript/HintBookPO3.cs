using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HintBookPO3 : MonoBehaviour
{

    public GameObject alertGuiA;

    public GameObject panelGuiA;
    public GameObject alertGuiPanelA;



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("PlayerA"))
        {
            alertGuiA.gameObject.SetActive(true);
            alertGuiA.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per leggere il libro";

        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("PlayerA"))
        {

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                alertGuiA.gameObject.SetActive(false);
                panelGuiA.gameObject.SetActive(true);
                alertGuiPanelA.gameObject.GetComponent<Text>().text = "\t\t Lezione di magia avanzata 5 \n L’incantesimo “opvium” viene utilizzato dai " +
                    "maghi come sostituto alle chiavi, alcuni" +
                    " ritengono che sia stato inventato per i maghi sbadati che perdevano continuamente le chiavi di casa per strada";


            }
        }

    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("PlayerA"))
        {
            panelGuiA.gameObject.SetActive(false);
            alertGuiA.gameObject.SetActive(false);
        }
    }
}

