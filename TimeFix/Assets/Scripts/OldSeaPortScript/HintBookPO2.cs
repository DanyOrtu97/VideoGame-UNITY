using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HintBookPO2 : MonoBehaviour
{

    public GameObject alertGuiA;
    public GameObject panelGuiA;
    public GameObject alertGuiPanelA;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("PlayerA"))
        {
            alertGuiA.gameObject.SetActive(true);
            alertGuiA.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per leggere la pergamena";

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
                alertGuiPanelA.gameObject.GetComponent<Text>().text = "\t\t Miti e leggende vol. 3 \n Leggende raccontano che un apprendista del" +
                    " mago Merlino si integro' nella popolazione " +
                    "del villaggio di Colros mai rivelando i suoi poteri, " +
                    "alcuni dicono che ricevette dal suo maestro una sfera fonte di grandissima energia magica";
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

