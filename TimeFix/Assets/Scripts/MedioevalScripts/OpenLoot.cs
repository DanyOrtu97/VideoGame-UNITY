using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenLoot : MonoBehaviour
{
    public Text alertGUI;
    public InputField password;
    private bool openUp = false;
    public GameObject content;
   

    

    

    public bool isOpenUp()
    {
        return openUp;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (openUp == false)
        {
            if (collision.gameObject.CompareTag("PlayerB") || collision.gameObject.CompareTag("PlayerA"))
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.text = "Pronuncia la magia per aprire la cassa";
                password.gameObject.SetActive(true);

                if (password.text.Equals("opvium"))
                {
                    //Apricassa
                    openUp = true;
                    alertGUI.gameObject.SetActive(false);
                    password.gameObject.SetActive(false);
                    password.text = "";
                }
            }
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (openUp == false)
        {
            if (collision.gameObject.CompareTag("PlayerB") || collision.gameObject.CompareTag("PlayerA"))
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.text = "Pronuncia la magia per aprire la cassa";
                password.gameObject.SetActive(true);

                if (password.text.Equals("opvium"))
                {
                    content.SetActive(true);
                    this.transform.eulerAngles += new Vector3(90, 0, 0);

                    openUp = true;

                    password.text = "";
                    alertGUI.gameObject.SetActive(false);
                    password.gameObject.SetActive(false);

                }

            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("PlayerB") || collision.gameObject.CompareTag("PlayerA"))
        {
            alertGUI.gameObject.SetActive(false);
            password.gameObject.SetActive(false);
        }
    }


}

