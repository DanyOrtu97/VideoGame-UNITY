using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildBarca : MonoBehaviour
{

    public GameObject alertGUI;
    public GameObject gameController;
    public GameObject barca;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            alertGUI.gameObject.SetActive(true);
            alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto E per costruire la barca";

           
            
        }



    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (gameController.gameObject.GetComponent<GameController>().getCounterBarca() == 3)
                {
                    barca.gameObject.SetActive(true);
                    this.gameObject.SetActive(false);
                    alertGUI.gameObject.SetActive(false);
                }
                else
                {
                    alertGUI.gameObject.GetComponent<Text>().text = "Non hai i componenti, ti serve la vela, l'albero e lo scafo";
                }
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            alertGUI.gameObject.SetActive(false);
        }
    }


}
