using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

/*Sblocco password*/
public class DoorPassword : MonoBehaviour
{
    public GameObject allertGuiB;
    public GameObject timer;
    public InputField passwordB;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerB"))
        {
            if (this.gameObject.GetComponent<DoorController>().isOpen == false)
            {
                allertGuiB.gameObject.SetActive(true);
                allertGuiB.gameObject.GetComponent<Text>().text = "Inserisci password";
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerB"))
        {
            if (this.gameObject.GetComponent<DoorController>().isOpen == false)
            {
                allertGuiB.gameObject.SetActive(true);
                allertGuiB.gameObject.GetComponent<Text>().text = "Inserisci password";

                passwordB.gameObject.SetActive(true);

                if (passwordB.text.Equals("kajec"))
                {
                    Debug.Log("Porta Aperta");
                    passwordB.gameObject.SetActive(false);
                    allertGuiB.gameObject.SetActive(false);
                    timer.gameObject.SetActive(false);
                    this.gameObject.GetComponent<DoorController>().isOpen = true;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerB"))
        {
            allertGuiB.gameObject.SetActive(false);
            passwordB.gameObject.SetActive(false);
        }
    }

}
