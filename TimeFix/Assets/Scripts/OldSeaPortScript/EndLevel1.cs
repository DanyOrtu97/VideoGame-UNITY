﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Controllo fine livello 1
public class EndLevel1 : MonoBehaviour
{

    public GameObject alertGUI;
    public GameObject gameController;
    public GameObject player;
    public GameObject otherPlayer;
    public GameObject cassa;
    private Transform tr;
    private bool onBoat = false;
    private int speed = 1;
    private float navigationTime;
    private void Start()
    {
        tr = player.gameObject.transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA") && onBoat == false)
        {
            alertGUI.gameObject.SetActive(true);
            alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per Salpare";

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]) && onBoat == false)
            {
                //solo se ha eseguito le operazioni necessari finisce il livello
                if (gameController.gameObject.GetComponent<GameController>().getCounterFood() == 3 && cassa.GetComponent<OpenLoot>().isOpenUp() == true&&otherPlayer.gameObject.GetComponent<Inventory>().checkItem("blueorbPorto"))
                {
                    onBoat = true;
                    navigationTime = Time.time;
                    tr.transform.position = new Vector3(24.31f, 2.53f, 46.91f);
                    tr.eulerAngles = new Vector3(0, 120, 0);
                    alertGUI.gameObject.SetActive(false);

                }
                else
                {
                    alertGUI.gameObject.GetComponent<Text>().text = "Ti servono 3 provviste di cibo per salpare";
                    if (cassa.GetComponent<OpenLoot>().isOpenUp() == false||otherPlayer.gameObject.GetComponent<Inventory>().checkItem("blueorbPorto"))
                    {
                        alertGUI.gameObject.GetComponent<Text>().text += " e potrebbe servire ancora il tuo aiuto a Remy";
                    }

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

    public bool isOnBoat()
    {
        return onBoat;
    }


    void Update()
    {
        if (onBoat)
        {
            if (Time.time - navigationTime < 40)//Gestione navigazione Barca, dopo 40 secondi si fermas
            {
                player.gameObject.SetActive(false);
                this.transform.Translate(Vector3.back * Time.deltaTime * speed); //muove in avanti la barca anche se c'è back
                tr.transform.position = this.transform.position; //fa muovere insieme barca e player 
                player.gameObject.SetActive(true);
            }
            else {
                player.gameObject.SetActive(false);
                tr.transform.position = this.transform.position;
                player.gameObject.SetActive(true);
            }
            
        }

    }
}