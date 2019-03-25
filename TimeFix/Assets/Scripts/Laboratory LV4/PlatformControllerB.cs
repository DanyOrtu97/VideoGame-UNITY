using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformControllerB : MonoBehaviour
{
    public bool on = false;
    public GameObject PlatrformA;
    public GameObject infoB;
    public Text textB;

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
        
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            Debug.Log("PlatformB");
            on = true;

            if (PlatrformA.GetComponent<PlatformControllerAA>().on){
                infoB.gameObject.SetActive(true);
                textB.text = "Passaggio aperto";
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            Debug.Log("PlatformB");
            on = true;
            if (PlatrformA.GetComponent<PlatformControllerAA>().on){
                infoB.gameObject.SetActive(true);
                textB.text = "Passaggio aperto";
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            on = false;
            infoB.gameObject.SetActive(true);
            textB.text = "Passaggio chiuso";
        }
    }
}
