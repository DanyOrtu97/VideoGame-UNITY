using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerifyRotation : MonoBehaviour
{
    public Text textA, textB;
    public GameObject infoA, infoB;
	public GameObject battery1, battery2, battery3;
	private BoxCollider boxCollider;
    private float[] degrees = {-1,-1,-1};  

	// Start is called before the first frame update
	void Start()
    {
		boxCollider = gameObject.GetComponent<BoxCollider>();
	}

    // Update is called once per frame
    void Update()
    {

	
	}


	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("PlayerA") )
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
            infoA.gameObject.SetActive(true);
            textA.text = "Passaggio chiuso";
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Passaggio chiuso";
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


    public void insertDegree(float degree, int i)
    {
        degrees[i] = degree;

        Debug.Log(degrees[0] +" "+degrees[1] + " " + degrees[2]);

        if (degrees[0] == 90 && degrees[1] == 180 && degrees[2] == 90)
        {
            boxCollider.isTrigger = true;
        }
        else
        {
            boxCollider.isTrigger = false;
        }
    }



}
