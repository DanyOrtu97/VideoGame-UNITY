using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DrinkWine : MonoBehaviour
{

    public GameObject alertGUI;
    private bool oneDrink = false;
 
    public GameObject fragment;
 
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {

            if (oneDrink == false)
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto E per bere vino";
            }



        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            if (oneDrink == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    alertGUI.gameObject.GetComponent<Text>().text = "1% alcol";
                    fragment.SetActive(true);
                    alertGUI.gameObject.SetActive(false);
                    oneDrink = true;
                  



                }
            }



        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            alertGUI.gameObject.SetActive(false);
        }
    }
}
