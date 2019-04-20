using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApriRecintoPortaLiam : MonoBehaviour
{
    public Text textA;
    public GameObject infoA;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Cancello chiuso! Solo Remy puo aprirlo";
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Cancello chiuso! Solo Remy puo aprirlo";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
        }

    }
}
