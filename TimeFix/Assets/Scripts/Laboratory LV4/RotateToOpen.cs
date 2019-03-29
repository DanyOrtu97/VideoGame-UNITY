using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateToOpen : MonoBehaviour
{
    public Text textA, textB;
    public GameObject infoA, infoB;
    private bool incrementa = false;
    private float degree;
    public float speed;

    // Start is called before the first frame update
    void Start()
	{
        degree = 0f;
        speed = 4f;
	}

	// Update is called once per frame
	void Update()
	{
        if (incrementa == true)
        {
            degree = (degree + 90) % 360;
            incrementa = false;
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, degree, 0), Time.deltaTime * speed);
        //transform.eulerAngles += new Vector3(0, degree, 0);
    }

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Premi R per ruotare";
            if (Input.GetKeyDown(KeyCode.R))
            {
                incrementa = true;
            }

        }

        if (collision.gameObject.CompareTag("PlayerB") )
        {
            
            infoB.gameObject.SetActive(true);
            textB.text = "Premi R per ruotare";
            if (Input.GetKeyDown(KeyCode.R))
            {
                incrementa = true;
            }
        }
    }

	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.CompareTag("PlayerA") )
		{
            
            infoA.gameObject.SetActive(true);

            textA.text = "Premi R per ruotare";

            if (Input.GetKeyDown(KeyCode.R))
            {
                incrementa = true;
            }
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            
            infoB.gameObject.SetActive(true);
            textB.text = "Premi R per ruotare";


            if (Input.GetKeyDown(KeyCode.R))
            {
                incrementa = true;
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
