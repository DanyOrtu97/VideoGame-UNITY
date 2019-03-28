﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LV4_OpenUpAccess : MonoBehaviour
{
    public Text textA, textB;
    public GameObject infoA, infoB;
    private BoxCollider boxCollider;
    public GameObject boxColliderDown;
    public InputField passwordA, passwordB;
    private bool openUp = false;


	// Start is called before the first frame update
	void Start()
    {
        boxCollider = gameObject.GetComponent<BoxCollider>();
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (openUp)
        {
            boxCollider.isTrigger = true;
            boxColliderDown.gameObject.GetComponent<BoxCollider>().isTrigger = true;

        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Digitare la password per entrare!";
            passwordA.gameObject.SetActive(true);

            if (passwordA.text.Equals("serpente"))
            {
                textA.text = "Passaggio aperto!";
                openUp = true;
            }
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Digitare la password per entrare!";
            passwordB.gameObject.SetActive(true);

            if (passwordB.text.Equals("serpente"))
            {
                textA.text = "Passaggio aperto!";
                openUp = true;
            }

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Digitare la password per entrare!";
            passwordA.gameObject.SetActive(true);

            if (passwordA.text.Equals("serpente"))
            {
                textA.text = "Passaggio aperto!";
                openUp = true;
            }

        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Digitare la password per entrare!";
            passwordB.gameObject.SetActive(true);

            if (passwordB.text.Equals("serpente"))
            {
                textA.text = "Passaggio aperto!";
                openUp = true;
            }

        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
            passwordA.gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
            passwordB.gameObject.SetActive(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio aperto";
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Passaggio aperto";
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio aperto";
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Passaggio aperto";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
        }
    }

}

