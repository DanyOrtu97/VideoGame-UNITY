using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Indizio libro*/
public class HintBookMD3 : MonoBehaviour
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
                alertGuiPanelB.gameObject.GetComponent<Text>().text = "\t\t Lezione di magia avanzata 3 \n Maghi di citta' lontane hanno sviluppato un " +
                    "incantesimo per lo spostamento di " +
                    "importanti oggetti incantati, pronunciando “transferto” riuscivano in questo intento. Tuttavia essendo una magia " +
                    "complicata richiede abilita' di esecuzione di entrambi i maghi ";

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
