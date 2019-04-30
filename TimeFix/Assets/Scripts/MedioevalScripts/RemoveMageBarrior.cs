using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Barriera casa finale*/
public class RemoveMageBarrior : MonoBehaviour
{

    public InputField password;
    public Text alertGUI;
    BoxCollider box;

    void Start()
    {
        box = gameObject.GetComponent<BoxCollider>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            alertGUI.gameObject.SetActive(true);
            alertGUI.gameObject.GetComponent<Text>().text = "Un barriera magica blocca la strada, bisogna spezzarla";
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            alertGUI.gameObject.SetActive(true);
            alertGUI.text = "Un barriera magica blocca la strada, bisogna spezzarla";
            password.gameObject.SetActive(true);

            if (password.text.Equals("debarrier"))
            {
                alertGUI.gameObject.SetActive(false);

                box.isTrigger = true;

                password.gameObject.SetActive(false);
                password.text = "";
            }


        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            password.gameObject.SetActive(false);
            alertGUI.gameObject.SetActive(false);
        }

    }
}
