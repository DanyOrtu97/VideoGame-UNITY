using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoorMD : MonoBehaviour
{

    public GameObject alertGUI;
    private bool isOpen = false;
   

  

     private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerB")){
            


            if (isOpen == false)
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto E per aprire";
            }
                

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            if (isOpen == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    this.gameObject.transform.eulerAngles += new Vector3(0, 90, 0);
                    isOpen = true;
                    alertGUI.SetActive(false);

                }          
            }
        }   
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            alertGUI.gameObject.SetActive(false);
        }
    }

}
