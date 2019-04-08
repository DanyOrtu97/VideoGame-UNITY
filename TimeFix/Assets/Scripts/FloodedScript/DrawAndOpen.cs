using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawAndOpen : MonoBehaviour
{
    public GameObject[] Ligths;
    private string inputLights;
    public Text textB;
    public GameObject infoB;
    public InputField passwordB;
    public GameObject passaggioSegreto;

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
            infoB.gameObject.SetActive(true);
            textB.text = "Inserisci i numeri relativi alle luci che vuoi accendere divisi da spazi!";
            passwordB.gameObject.SetActive(true);

        }
    }

    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Inserisci i numeri relativi alle luci che vuoi accendere divisi da spazi!";
            passwordB.gameObject.SetActive(true);

            inputLights = passwordB.text;

            if (passwordB.text.Equals("2 4 5 6 8"))
            {
                //apri passaggio segreto
            }


            for (int i=0; i<9; i++)
            {
                if (inputLights.Contains((i+1).ToString()))
                {
                    Ligths[i].gameObject.GetComponent<Light>().enabled = true;
                }
            }

        }

    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
            passwordB.gameObject.SetActive(false);
        }
    }
}
