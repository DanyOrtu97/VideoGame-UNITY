using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoorMD : MonoBehaviour
{

    public GameObject alertGUI;
    private bool isOpen = false;
    public GameObject doorController;

  

     private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerB")){
            


            if (isOpen == false)
            {
                alertGUI.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto  " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per aprire";
            }
                

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            if (isOpen == false)
            {
                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
                {

                    //this.gameObject.transform.eulerAngles += new Vector3(0, 90, 0);
                    doorController.gameObject.GetComponent<DoorControllerLeft>().isOpen = true;
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
