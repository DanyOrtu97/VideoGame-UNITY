using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Gestione apertura porta finale tramite password*/
public class OpenHomeUltimateDoor : MonoBehaviour
{
    public GameObject gameController;
    public GameObject porta1, porta2;
    public Text textB, textA;
    public GameObject infoB, infoA;
    public InputField passwordB, passwordA;


    private void OnTriggerEnter(Collider other)
    {
        passwordB.text = "";
        passwordA.text = "";

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Porta chiusa! Trova la password!";
            passwordB.gameObject.SetActive(true);

            if (passwordB.text.Equals("ghiaccio"))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                passwordB.gameObject.SetActive(false);
                infoB.gameObject.SetActive(false);
                textB.text = "Porta aperta!";
                porta1.gameObject.GetComponent<DoorControllerLeft>().isOpen = true;
                porta2.gameObject.GetComponent<DoorController>().isOpen = true;
            }


        }

        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Porta chiusa! Trova la password!";
            passwordA.gameObject.SetActive(true);

            if (passwordA.text.Equals("fuoco"))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                passwordA.gameObject.SetActive(false);
                infoA.gameObject.SetActive(false);
                textA.text = "Porta aperta!";
                porta1.gameObject.GetComponent<DoorControllerLeft>().isOpen = true;
                porta2.gameObject.GetComponent<DoorController>().isOpen = true;
            }


        }

    }

    private void OnTriggerStay(Collider other)
    {


        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Porta chiusa! Trova la password!";
            passwordB.gameObject.SetActive(true);

            if (passwordB.text.Equals("ghiaccio"))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                passwordB.gameObject.SetActive(false);
                infoB.gameObject.SetActive(false);
                textB.text = "Porta aperta!";
                porta1.gameObject.GetComponent<DoorControllerLeft>().isOpen = true;
                porta2.gameObject.GetComponent<DoorController>().isOpen = true;
            }


        }

        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Porta chiusa! Trova la password!";
            passwordA.gameObject.SetActive(true);

            if (passwordA.text.Equals("fuoco"))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                passwordA.gameObject.SetActive(false);
                infoA.gameObject.SetActive(false);
                textA.text = "Porta aperta!";
                porta1.gameObject.GetComponent<DoorControllerLeft>().isOpen = true;
                porta2.gameObject.GetComponent<DoorController>().isOpen = true;
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

        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
            passwordA.gameObject.SetActive(false);
        }
    }


}
