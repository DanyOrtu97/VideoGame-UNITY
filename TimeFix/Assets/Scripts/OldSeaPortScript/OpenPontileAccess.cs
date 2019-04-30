﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Apertura Pontile
public class OpenPontileAccess : MonoBehaviour
{

    public GameObject text;
    public GameObject flag1;
    public GameObject flag2;
    public GameObject flag3;
    BoxCollider box;

    void Start()
    {
        box = gameObject.GetComponent<BoxCollider>();
    }

    void FixedUpdate()
    {
        if (flag1.gameObject.GetComponent<RaiseFlag>().isRaiser() &&
            flag2.gameObject.GetComponent<RaiseFlag>().isRaiser() &&
            flag3.gameObject.GetComponent<RaiseFlag>().isRaiser())
        {
            box.isTrigger = true;


        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            text.gameObject.SetActive(true);
            text.gameObject.GetComponent<Text>().text = "Pontile chiuso";
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            text.gameObject.SetActive(true);
            text.gameObject.GetComponent<Text>().text = "Pontile chiuso";
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            text.gameObject.SetActive(false);
        }

    }
}
