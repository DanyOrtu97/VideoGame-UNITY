using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLevel1 : MonoBehaviour
{

    public GameObject alertGUI;
    public GameObject gameController;
    public GameObject player;
    private Transform tr;
    private bool onBoat = false;
    private int speed = 1;

    private void Start()
    {
        tr = player.gameObject.transform;   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA") && onBoat == false)
        {
            alertGUI.gameObject.SetActive(true);
            alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto E per Salpare";



        }



    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {

            if (Input.GetKeyDown(KeyCode.E) && onBoat == false)
            {
                if (gameController.gameObject.GetComponent<GameController>().getCounterFood() == 0)
                {
                    onBoat = true;
                    tr.gameObject.SetActive(false);
                    tr.transform.position = new Vector3(24.31f, 2.70f, 46.91f);
                    tr.gameObject.SetActive(true);
                    tr.eulerAngles = new Vector3(0, 120, 0);
                    alertGUI.gameObject.SetActive(false);

                }
                else
                {
                    alertGUI.gameObject.GetComponent<Text>().text = "Ti servono 3 provviste di cibo per salpare";
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


    void Update()
    {
        if (onBoat)
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * speed); //muove in avanti la barca anche se c'è back
            tr.gameObject.SetActive(false);
            tr.transform.position = this.transform.position; //fa muovere insieme barca e player 
            tr.gameObject.SetActive(true);
        }
        
    }
}
