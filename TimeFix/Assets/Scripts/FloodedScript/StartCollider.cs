using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Collider iniziale per indicare l'obiettivo del livello*/
public class StartCollider : MonoBehaviour
{
    public Text textA, textB;
    public GameObject infoA, infoB;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Liam e' intrappolato nel labirinto, trova un metodo per farlo uscire!";
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Aiuta Remy ad uscire dal recinto!";
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Liam e' intrappolato nel labirinto, trova un metodo per farlo uscire!";
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Aiuta Remy ad aprire il recinto per Liam del futuro!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
