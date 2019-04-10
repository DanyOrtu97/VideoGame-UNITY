using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenHomeUltimateDoor : MonoBehaviour
{
    public GameObject gameController;
    public GameObject porta1, porta2;
    public Text textB, textA;
    public GameObject infoB, infoA;
    public InputField passwordB, passwordA;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        passwordB.text = "";
        passwordA.text = "";

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Porta chiusa! Trova la password!";
            passwordB.gameObject.SetActive(true);

            if (passwordB.text.Equals("azibo"))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                passwordB.gameObject.SetActive(false);
                infoB.gameObject.SetActive(false);
                textB.text = "Porta aperta!";
                porta1.gameObject.SetActive(false);
                porta2.gameObject.SetActive(false);
            }


        }

        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Porta chiusa! Trova la password!";
            passwordA.gameObject.SetActive(true);

            if (passwordA.text.Equals("azibo"))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                passwordA.gameObject.SetActive(false);
                infoA.gameObject.SetActive(false);
                textA.text = "Porta aperta!";
                porta1.gameObject.SetActive(false);
                porta2.gameObject.SetActive(false);
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

            if (passwordB.text.Equals("azibo"))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                passwordB.gameObject.SetActive(false);
                infoB.gameObject.SetActive(false);
                textB.text = "Porta aperta!";
                porta1.gameObject.SetActive(false);
                porta2.gameObject.SetActive(false);
            }


        }

        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Porta chiusa! Trova la password!";
            passwordA.gameObject.SetActive(true);

            if (passwordA.text.Equals("azibo"))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                passwordA.gameObject.SetActive(false);
                infoA.gameObject.SetActive(false);
                textA.text = "Porta aperta!";
                porta1.gameObject.SetActive(false);
                porta2.gameObject.SetActive(false);
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
