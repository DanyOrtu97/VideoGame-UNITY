using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_UscitaLabirinto : MonoBehaviour
{

    public Text textA;
    public GameObject infoA;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "PortaleAperto!";
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "PortaleAperto!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
