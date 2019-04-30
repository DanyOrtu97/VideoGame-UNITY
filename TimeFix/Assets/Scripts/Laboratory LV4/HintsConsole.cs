using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Hint console inferiore*/
public class HintsConsole : MonoBehaviour
{
    public Text textA;
    public GameObject infoA;
    public GameObject hintA;
    private bool isOpenA = false;


    // Update is called once per frame
    void Update()
    {
        if (isOpenA)
        {
            Debug.Log("Hint True");
            hintA.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            textA.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per leggere";
            infoA.gameObject.SetActive(true);

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                isOpenA = true;
            }

        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            textA.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per leggere";
            infoA.gameObject.SetActive(true);

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                isOpenA = true;
            }
        }

    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
            hintA.SetActive(false);
            isOpenA = false;
        }
    }
}
