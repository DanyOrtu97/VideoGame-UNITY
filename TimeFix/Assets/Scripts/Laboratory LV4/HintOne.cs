using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintOne : MonoBehaviour
{
    public Text textA;
    public GameObject infoA;

    // Start is called before the first frame update
    void Start()
    {
        infoA.gameObject.SetActive(true);
        textA.text = "Trova il tuo amico Remy!";
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
            textA.text = "Trova il tuo amico Remy!";
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Trova il tuo amico Remy!";
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
