using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildBarca : MonoBehaviour
{

    public GameObject alertGUI;
    public GameObject gameController;
    public GameObject barca;
    public GameObject player;
    BoxCollider box;

    private void Start()
    {
        box = gameObject.GetComponent<BoxCollider>();
    }

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
                    player.gameObject.GetComponent<Inventory>().removeItemByType("barca");
                    box.isTrigger = true;
                }
                else
                {
                    alertGUI.gameObject.GetComponent<Text>().text = "Non hai i pezzi necessari";
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
