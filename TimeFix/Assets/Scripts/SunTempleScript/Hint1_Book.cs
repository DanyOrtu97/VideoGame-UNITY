﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint1_Book : MonoBehaviour
{
    public GameObject allertGuiA;
    public GameObject allertGuiB;
    public GameObject panelGuiA;
    public GameObject panelGuiB;
    public GameObject allertGuiPanelA;
    public GameObject allertGuiPanelB;


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            allertGuiA.gameObject.SetActive(true);
            allertGuiA.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per leggere il libro";

        }
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            allertGuiB.gameObject.SetActive(true);
            allertGuiB.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per leggere il libro";

        }


    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                allertGuiA.gameObject.SetActive(false);
                panelGuiA.gameObject.SetActive(true);
                allertGuiPanelA.gameObject.GetComponent<Text>().text = "Helios, antica roccaforte dell'impero Romano," +
                    " è una dei tanti borghi ormai abbandonati. Situata nel kazakistan, la città è completamente deserta dal 1930. [altro indizio per scoprire la password]" +
                    "Azibo 21-12-1935";
            }
        }
        if (collision.gameObject.CompareTag("PlayerB"))
        {

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
            {
                allertGuiB.gameObject.SetActive(false);
                panelGuiB.gameObject.SetActive(true);
                allertGuiPanelB.gameObject.GetComponent<Text>().text = "Helios, antica roccaforte dell'impero Romano," +
                    " è una dei tanti borghi ormai abbandonati. Situata nel kazakistan, la città è completamente deserta dal 1930. [altro indizio per scoprire la password]" +
                    "Azibo 21-12-1935";
            }
        }


    }
    public void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("PlayerA"))
        {
            panelGuiA.gameObject.SetActive(false);
            allertGuiA.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            panelGuiB.gameObject.SetActive(false);
            allertGuiB.gameObject.SetActive(false);
        }

    }

}