using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateToOpen : MonoBehaviour
{
    public Text textA, textB;
    public GameObject infoA, infoB;
    private Transform transform;
	private bool checkCollision = false;
	private BoxCollider boxCollider;

	// Start is called before the first frame update
	void Start()
	{
		transform = gameObject.GetComponent<Transform>();
		boxCollider = gameObject.GetComponent<BoxCollider>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		
	}

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Premi I per ruotare";


            if (Input.GetKeyDown(KeyCode.I))
            {
                if (transform.eulerAngles.y == 270)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
                else
                {
                    transform.eulerAngles += new Vector3(0, 90, 0);
                }

            }

        }

        if (collision.gameObject.CompareTag("PlayerB") )
        {
            
            infoB.gameObject.SetActive(true);
            textB.text = "Premi R per ruotare";
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (transform.eulerAngles.y == 270)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
                else
                {
                    transform.eulerAngles += new Vector3(0, 90, 0);
                }
            }
        }
    }

	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.CompareTag("PlayerA") )
		{
            
            infoA.gameObject.SetActive(true);

            textA.text = "Premi I per ruotare";

            if (Input.GetKeyDown(KeyCode.I))
			{
				if (transform.eulerAngles.y == 270)
				{
                    transform.eulerAngles = new Vector3(0,0,0);
				}
				else
				{
                    transform.eulerAngles += new Vector3(0, 90, 0);
				}

            }
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            
            infoB.gameObject.SetActive(true);
            textB.text = "Premi R per ruotare";
            if (Input.GetKeyDown(KeyCode.R) )
            {
                if (transform.eulerAngles.y == 270)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
                else
                {
                    transform.eulerAngles += new Vector3(0, 90, 0);
                }
            }
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
