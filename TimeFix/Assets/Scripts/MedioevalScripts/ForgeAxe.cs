using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ForgeAxe : MonoBehaviour
{
    public GameObject alertGUI;
    public GameObject gameController;
    private bool isForged;
    public GameObject axe;
    public GameObject player;
    



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            if (isForged == false)
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per forgiare un'ascia";
            }

            

        }
    }


    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("PlayerB"))
        {

            if (isForged == false)
            {
                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
                {
                    if (gameController.gameObject.GetComponent<GameController2>().getCounterHammer() == 1
                        && gameController.gameObject.GetComponent<GameController2>().getCounterIron() == 3)
                    {
                        player.gameObject.GetComponent<Inventory>().removeItemByType("hotiron");
                        player.gameObject.GetComponent<Inventory>().removeItemByType("hammer");
                        alertGUI.gameObject.GetComponent<Text>().text = "Ascia ottenuta";
                        axe.SetActive(true);
                        isForged = true;

                        

                    }
                    else
                    {
                        alertGUI.gameObject.GetComponent<Text>().text = "Ti serve un attrezzo per lavorare il ferro";
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




}
