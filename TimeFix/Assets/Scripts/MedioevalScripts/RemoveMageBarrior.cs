using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RemoveMageBarrior : MonoBehaviour
{
   
    public InputField password;
    public Text alertGUI;



    BoxCollider box; //Blocco del pontile

    // Start is called before the first frame update
    void Start()
    {
        box = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

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
