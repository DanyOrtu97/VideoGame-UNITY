using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseMagicBook : MonoBehaviour
{

    public GameObject allertGui;
    public InputField password;
    public GameObject controller;

    private void OnTriggerEnter(Collider other)
    {
        if (controller.gameObject.GetComponent<InserPasswordContemporary>().activeSphere == false)
        {
            if (other.gameObject.CompareTag("PlayerB") || other.gameObject.CompareTag("PlayerA"))
            {

                allertGui.gameObject.SetActive(true);
                allertGui.gameObject.GetComponent<Text>().text = "Pronuncia l'incantesimo";
            }
        }
        else
        {
            allertGui.gameObject.SetActive(false);
            password.gameObject.SetActive(false);
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (controller.gameObject.GetComponent<InserPasswordContemporary>().activeSphere == false)
        {
            if (other.gameObject.CompareTag("PlayerB") || other.gameObject.CompareTag("PlayerA"))
            {

                allertGui.gameObject.SetActive(true);
                allertGui.gameObject.GetComponent<Text>().text = "Pronuncia l'incantesimo";
                password.gameObject.SetActive(true);

            }
        }
        else {
            allertGui.gameObject.SetActive(false);
            password.gameObject.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (controller.gameObject.GetComponent<InserPasswordContemporary>().activeSphere == false)
        {
            if (other.gameObject.CompareTag("PlayerB") || other.gameObject.CompareTag("PlayerA"))
            {
                allertGui.gameObject.SetActive(false);
                password.text = "";
                password.gameObject.SetActive(false);
                
            }
        }
    }



}
