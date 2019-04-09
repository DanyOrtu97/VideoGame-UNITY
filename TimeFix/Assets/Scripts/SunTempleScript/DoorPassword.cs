using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DoorPassword : MonoBehaviour
{
    public GameObject allertGuiB;


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB")) {
            if (this.gameObject.GetComponent<DoorController>().isOpen == false)
            {
                allertGuiB.gameObject.SetActive(true);
                allertGuiB.gameObject.GetComponent<Text>().text = "Inserisci password";
            }
        }
        

    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Debug.Log("Porta Aperta");
                allertGuiB.gameObject.SetActive(false);
                this.gameObject.GetComponent<DoorController>().isOpen = true;
            }
        }
            
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            allertGuiB.gameObject.SetActive(false);
        }
    }
}
