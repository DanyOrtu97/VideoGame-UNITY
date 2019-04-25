using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmashDoor : MonoBehaviour
{
    public GameObject alertGUI;
    private bool isOpen = false;
    public GameObject player;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {

            if (isOpen == false)
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per aprire";
            }

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            if (isOpen == false)
            {
                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
                {

                    if (player.gameObject.GetComponent<Inventory>().checkItem("axe"))
                    {
                        gameObject.SetActive(false);
                        alertGUI.gameObject.SetActive(false);
                    }
                    else
                    {
                        alertGUI.gameObject.GetComponent<Text>().text = "La porta e' bloccata, serve qualcosa per romperla";
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
