﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Controllo piattaforma Liam*/
public class PlatformControllerAA : MonoBehaviour
{
    public GameObject PlatrformB;
    public bool on = false;
    public GameObject infoA;
    public Text textA;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            audio.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            on = true;
            if (PlatrformB.GetComponent<PlatformControllerB>().on)
            {
                infoA.gameObject.SetActive(true);
                textA.text = "Passaggio inferiore aperto per Liam";
                audio.enabled = false;
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            on = true;
            if (PlatrformB.GetComponent<PlatformControllerB>().on)
            {
                infoA.gameObject.SetActive(true);
                textA.text = "Passaggio inferiore aperto per Liam";
                audio.enabled = false;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            on = false;
        }
    }
}
