using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Rotazione cabine*/
public class RotateToOpen : MonoBehaviour
{
    public Text textA, textB;
    public GameObject infoA, infoB;
    public GameObject SecretAccess;
    private bool incrementa = false;
    private float degree;
    public float speed;

    void Start()
    {
        degree = 0f;
        speed = 4f;
    }

    void Update()
    {
        if (incrementa == true)
        {
            degree = (degree + 90) % 360;

            if (this.gameObject.GetComponent<RotateToOpen>().CompareTag("battery1"))
            {
                SecretAccess.gameObject.GetComponent<VerifyRotation>().insertDegree(degree, 0);
            }

            else if (this.gameObject.GetComponent<RotateToOpen>().CompareTag("battery2"))
            {
                SecretAccess.gameObject.GetComponent<VerifyRotation>().insertDegree(degree, 1);
            }

            else if (this.gameObject.GetComponent<RotateToOpen>().CompareTag("battery3"))
            {
                SecretAccess.gameObject.GetComponent<VerifyRotation>().insertDegree(degree, 2);
            }


            incrementa = false;
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, degree, 0), Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per ruotare";
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                incrementa = true;
            }

        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {

            infoB.gameObject.SetActive(true);
            textB.text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per ruotare";
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
            {
                incrementa = true;
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {

            infoA.gameObject.SetActive(true);

            textA.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per ruotare";

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                incrementa = true;
            }
        }

        if (collision.gameObject.CompareTag("PlayerB"))
        {

            infoB.gameObject.SetActive(true);
            textB.text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per ruotare";


            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
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
