using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalHint : MonoBehaviour
{

    public Text textA, textB;
    public GameObject infoA, infoB;
    public GameObject SecretAccess;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerA") && SecretAccess.gameObject.GetComponent<VerifyRotation>().UltimateStage())
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio per il Laboratorio aperto. Raccogliete TUTTI i cubi magici e correte! ";
        }

        if (other.CompareTag("PlayerB") && SecretAccess.gameObject.GetComponent<VerifyRotation>().UltimateStage())
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Passaggio per il Laboratorio aperto. Raccogliete TUTTI i cubi magici e correte! ";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA") )
        {
            infoA.gameObject.SetActive(false);
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
        }
    }
}
