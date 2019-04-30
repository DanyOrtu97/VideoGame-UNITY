using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Apertura generica porte*/
public class OpenDoorFlooded : MonoBehaviour
{
    public Text textA, textB;
    public GameObject infoA, infoB;
    private GameObject door;
    public InputField passwordA, passwordB;
    private bool open = false;

    private void OpenDoor() {
        door.gameObject.GetComponent<DoorController>().isOpen = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Digitare la password per entrare!";
            passwordA.gameObject.SetActive(true);

        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Digitare la password per entrare!";
            passwordB.gameObject.SetActive(true);

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Digitare la password per entrare!";
            passwordA.gameObject.SetActive(true);

            if (passwordA.text.Equals("password"))
            {
                textA.text = "Passaggio aperto!";
                open = true;
                OpenDoor();
            }

        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Digitare la password per entrare!";
            passwordB.gameObject.SetActive(true);

            if (passwordB.text.Equals("password"))
            {
                textA.text = "Passaggio aperto!";
                open = true;
                OpenDoor();
            }

        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
            passwordA.gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
            passwordB.gameObject.SetActive(false);
        }
    }



}
