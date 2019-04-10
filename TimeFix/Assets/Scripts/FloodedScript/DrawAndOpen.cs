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
    public GameObject activeKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        passwordB.text = "";
        for (int i = 0; i < 9; i++)
        {
            Ligths[i].gameObject.GetComponent<Light>().enabled = false;
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Inserisci i numeri relativi alle luci che vuoi accendere divisi da spazi!";
            passwordB.gameObject.SetActive(true);

        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerB"))
        {
            
            

            infoB.gameObject.SetActive(true);
            textB.text = "Inserisci i numeri relativi alle luci che vuoi accendere divisi da spazi!";
            passwordB.gameObject.SetActive(true);

            inputLights = passwordB.text;
            

            if (passwordB.text.Equals("2 4 5 6 8") || passwordB.text.Equals("2 4 5 6 8 "))
            {
                activeKey.SetActive(true);
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                passwordB.gameObject.SetActive(false);
                infoB.gameObject.SetActive(false);
            }


            for (int i = 0; i < 9; i++)
            {
                if (inputLights.Contains((i + 1).ToString()))
                {
                    Ligths[i].gameObject.GetComponent<Light>().enabled = true;
                }
                else
                {
                    Ligths[i].gameObject.GetComponent<Light>().enabled = false;
                }
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
            passwordB.gameObject.SetActive(false);
        }
    }


   
}
