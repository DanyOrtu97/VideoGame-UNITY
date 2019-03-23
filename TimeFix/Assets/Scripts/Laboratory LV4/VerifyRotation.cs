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


	// Start is called before the first frame update
	void Start()
    {
		boxCollider = gameObject.GetComponent<BoxCollider>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {


		if(battery1.transform.eulerAngles.y ==90 
			&& battery2.transform.eulerAngles.y == 180
			&& battery3.transform.eulerAngles.y == 90)
		{
			boxCollider.isTrigger = true;
		}
        else
        {
            boxCollider.isTrigger = false;
        }
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






}
