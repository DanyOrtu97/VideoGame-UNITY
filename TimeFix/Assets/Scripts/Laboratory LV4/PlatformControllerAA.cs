using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformControllerAA : MonoBehaviour
{
    public GameObject PlatrformB;
    public bool on = false;
    public GameObject infoA;
    public Text textA;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            Debug.Log("PlatformA");
            on = true;
            if (PlatrformB.GetComponent<PlatformControllerB>().on)
            {
                infoA.gameObject.SetActive(true);
                textA.text = "Passaggio aperto";
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            Debug.Log("PlatformA");
            on = true;
            if (PlatrformB.GetComponent<PlatformControllerB>().on){
                infoA.gameObject.SetActive(true);
                textA.text = "Passaggio aperto";
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            on = false;
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio chiuso";
        }
    }
}
