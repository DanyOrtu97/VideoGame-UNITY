﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintsConsole : MonoBehaviour
{

	public GameObject hintA, hintB;
	public GameObject PlayerA, PlayerB;


	// Start is called before the first frame update
	void Start()
    {
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("PlayerA") && PlayerA.GetComponent<PlayerControllerA>().openHint)
		{
            Debug.Log("console");
			hintA.SetActive(true);
		}


		if (collision.gameObject.CompareTag("PlayerB") && PlayerB.GetComponent<PlayerControllerB>().openHint)
		{
			hintB.SetActive(true);
		}
	}

    private void OnCollisionStay(Collision collision)
    {
        if (PlayerA.GetComponent<PlayerControllerA>().openHint)
        {
            hintA.SetActive(true);
        }


        if (PlayerB.GetComponent<PlayerControllerB>().openHint)
        {
            hintB.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            hintA.SetActive(false);
        }


        if (collision.gameObject.CompareTag("PlayerB"))
        {
            hintB.SetActive(false);
        }
    }
}
