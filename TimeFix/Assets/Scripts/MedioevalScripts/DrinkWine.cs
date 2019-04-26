using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DrinkWine : MonoBehaviour
{

    public GameObject alertGUI;
    private bool oneDrink = false;
 
    public GameObject fragment;
 
    

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerB"))
        {

            if (oneDrink == false)
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto  " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per bere vino";
            }



        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerB"))
        {
            if (oneDrink == false)
            {
                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
                {

                    alertGUI.gameObject.GetComponent<Text>().text = "1% alcol";
                    fragment.SetActive(true);
                    alertGUI.gameObject.SetActive(false);
                    oneDrink = true;




                }
            }



        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerB"))
        {
            alertGUI.gameObject.SetActive(false);
        }
    }
}
