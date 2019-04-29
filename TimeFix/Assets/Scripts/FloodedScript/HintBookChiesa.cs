using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintBookChiesa : MonoBehaviour
{

    public GameObject allertGuiA;
    public GameObject panelGuiA;
    public GameObject allertGuiPanelA;
    public GameObject allertGuiB;
    public GameObject panelGuiB;
    public GameObject allertGuiPanelB;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerA"))
        {
            allertGuiA.gameObject.SetActive(true);
            allertGuiA.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per leggere il libro";

        }
        if (other.gameObject.CompareTag("PlayerB"))
        {
            allertGuiB.gameObject.SetActive(true);
            allertGuiB.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per leggere il libro";

        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerA"))
        {

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                allertGuiA.gameObject.SetActive(false);
                panelGuiA.gameObject.SetActive(true);
                allertGuiPanelA.gameObject.GetComponent<Text>().text = "Sopra le cime delle montgne mi puoi trovare, in discoteca, sul drink, in riva al mare. Se la porta vuoi sbloccare, la trasformazione di uno dei 4 elementi dovrai indovinare.";
            }
        }
        if (other.gameObject.CompareTag("PlayerB"))
        {

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
            {
                allertGuiB.gameObject.SetActive(false);
                panelGuiB.gameObject.SetActive(true);
                allertGuiPanelB.gameObject.GetComponent<Text>().text = "Illumina la notte, riscalda le case, frutto di una scoperta alquanto primordiale. Se la porta vuoi sbloccare uno dei 4 elementi dovrai trovare.";
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerA"))
        {
            panelGuiA.gameObject.SetActive(false);
            allertGuiA.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("PlayerB"))
        {
            panelGuiB.gameObject.SetActive(false);
            allertGuiB.gameObject.SetActive(false);
        }
    }
}
