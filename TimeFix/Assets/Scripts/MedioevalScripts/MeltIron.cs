using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeltIron : MonoBehaviour
{
    public GameObject alertGUI;
    private bool isDoneIron = false;
    public GameObject gameController;
    private bool gotIron = false;
    private bool shutdown = false;
    public GameObject player;
    public GameObject hotIron;
    private BoxCollider box;


    private void Start()
    {
        box = gameObject.GetComponent<BoxCollider>();
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
           
            if (isDoneIron == false)
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto E per fondere il ferro";
            }

            if (isDoneIron == true)
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto E per prendere il ferro riscaldato";
            }

        }
    }

    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("PlayerB"))
        {




            if (isDoneIron == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (gameController.gameObject.GetComponent<GameController2>().getCounterIron() == 2)
                    {
                        
                        isDoneIron = true;
                        //rimuovi item??
                        player.gameObject.GetComponent<Inventory>().removeItemByType("iron");

                    }
                    else
                    {
                        alertGUI.gameObject.GetComponent<Text>().text = "Ti servono due pezzi di ferro";
                    }
                }
            }


            if (isDoneIron == true && gotIron == false && shutdown == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (gameController.gameObject.GetComponent<GameController2>().getCounterTool() == 1)
                    {
                        alertGUI.gameObject.GetComponent<Text>().text = "Ferro lavorato ottenuto";
                        gotIron = true;

                        player.gameObject.GetComponent<Inventory>().removeItemByType("tool");
                        gameController.gameObject.GetComponent<GameController2>().setCounterIron();
                        hotIron.SetActive(true);
                        shutdown = true;
                        box.isTrigger = true;

                    }
                    else
                    {
                        alertGUI.gameObject.GetComponent<Text>().text = "Ti serve un attrezzo per prendere il ferro";
                    }
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

    public bool getFinishState()
    {
        return shutdown;
    }

}

   



