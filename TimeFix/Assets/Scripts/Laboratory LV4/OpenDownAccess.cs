using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDownAccess : MonoBehaviour
{
    public Text textA, textB;
    public GameObject infoA, infoB;
    private BoxCollider boxCollider;
    public GameObject PlatrformA, PlatrformB;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = gameObject.GetComponent<BoxCollider>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {

		if (PlatrformA.GetComponent<PlatformControllerAA>().on && PlatrformB.GetComponent<PlatformControllerB>().on)
		{
			boxCollider.isTrigger = true;
            textA.text = "Passaggio aperto";
            textB.text = "Passaggio aperto";
        }

	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio chiuso";
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Passaggio chiuso";
        }


    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true); ;
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
        }


    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
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
