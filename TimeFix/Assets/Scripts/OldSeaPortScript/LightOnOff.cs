using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightOnOff : MonoBehaviour
{

    public GameObject light;
    public GameObject glass;
    public GameObject alertGUI;
    private bool flagModifica=false;

    private void Update()
    {
        if(flagModifica==true){
            if (light.gameObject.active == true)
            {
                light.gameObject.SetActive(false);
                glass.gameObject.SetActive(false);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per accendere";
            }
            else
            {
                light.gameObject.SetActive(true);
                glass.gameObject.SetActive(true);
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per spegnere";
            }
            flagModifica = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerA")){
            alertGUI.gameObject.SetActive(true);


            if (light.gameObject.active == true)
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per spegnere";

            if (light.gameObject.active == false)
                alertGUI.gameObject.GetComponent<Text>().text = "Premi il tasto " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per accendere";
        }



    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerA")){
            if(flagModifica==false){
                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
                {
                    flagModifica = true;
                }
            }

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            alertGUI.gameObject.SetActive(false);
        }
    }
}
