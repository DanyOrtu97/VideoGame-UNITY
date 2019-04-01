using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockTwo : MonoBehaviour
{

    public Text textA, textB;
    public GameObject infoA, infoB;
    private bool controlRemy = false;
    private bool controlLiam = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Trovate il modo di aprire il passaggio per il piano inferiore!";
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Trovate il modo di aprire il passaggio per il piano inferiore!";
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Trovate il modo di aprire il passaggio per il piano inferiore. Ognuno in questa vita ha il proprio posto assegnato!";
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Trovate il modo di aprire il passaggio per il piano inferiore. Ognuno in questa vita ha il proprio posto assegnato!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            this.gameObject.SetActive(false);
        }

        if (other.CompareTag("PlayerB"))
        {
            this.gameObject.SetActive(false);
        }
    }


}
