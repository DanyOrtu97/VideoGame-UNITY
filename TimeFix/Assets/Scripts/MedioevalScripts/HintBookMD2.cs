using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Libro indizio*/
public class HintBookMD2 : MonoBehaviour
{

    public GameObject alertGuiB;
    public GameObject panelGuiB;
    public GameObject alertGuiPanelB;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("PlayerB"))
        {
            alertGuiB.gameObject.SetActive(true);
            alertGuiB.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per leggere la pergamena";

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
                alertGuiPanelB.gameObject.GetComponent<Text>().text = "\t\t Miti e leggende vol. 1 \n Si narra " +
                    "che nel porto di Colros, i marinai, " +
                    "alzassero le bandiere del drago rosso per portare buon auspicio alla spedizione";
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
