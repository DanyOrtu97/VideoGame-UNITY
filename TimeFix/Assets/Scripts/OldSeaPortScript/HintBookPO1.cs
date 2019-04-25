using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HintBookPO1 : MonoBehaviour
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
                alertGuiPanelA.gameObject.GetComponent<Text>().text = "\t\t Lezione di magia base 3 \n L’incantesimo barrier e' uno dei piu'" +
                    " comuni incantesimi di protezione, i maghi da secoli lo utilizzano " +
                    "per non consentire l’accesso alle persone comuni";
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

