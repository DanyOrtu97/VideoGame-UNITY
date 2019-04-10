using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintExtra_Stone : MonoBehaviour
{
    public GameObject controller;
    public GameObject allertGuiA;
    public GameObject allertGuiB;
    public GameObject panelGuiA;
    public GameObject panelGuiB;
    public GameObject allertGuiPanelA;
    public GameObject allertGuiPanelB;
    public Vector3 newPosition;

    

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            allertGuiA.gameObject.SetActive(true);
            allertGuiA.gameObject.GetComponent<Text>().text = "Premi "+ InputAssign.keyDictInteractString["PlayerAInteract"] + " per spostare";

        }
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            allertGuiB.gameObject.SetActive(true);
            allertGuiB.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per spostare";

        }


    }
    
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                allertGuiA.gameObject.SetActive(false);
                
                if (controller.gameObject.GetComponent<InventorySunTemple>().isValid())
                {
                    StartCoroutine(MoveFunction());
                }
                else {
                    panelGuiA.gameObject.SetActive(true);
                    allertGuiPanelA.gameObject.GetComponent<Text>().text = "Il masso e' troppo pesante, servirebbe una leva...";
                }
                
            }
        }
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
            {
                allertGuiB.gameObject.SetActive(false);
                if (controller.gameObject.GetComponent<InventorySunTemple>().isValid())
                {
                    StartCoroutine(MoveFunction());
                }
                else
                {
                    panelGuiB.gameObject.SetActive(true);
                    allertGuiPanelB.gameObject.GetComponent<Text>().text = "Il masso e' troppo pesante, servirebbe una leva...";
                }
            }
        }


    }
    public void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("PlayerA"))
        {
            panelGuiA.gameObject.SetActive(false);
            allertGuiA.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            panelGuiB.gameObject.SetActive(false);
            allertGuiB.gameObject.SetActive(false);
        }

    }

    IEnumerator MoveFunction()
    {
        float timeSinceStarted = 0f;
        while (true)
        {
            timeSinceStarted += Time.deltaTime;
            
            this.gameObject.transform.localPosition = Vector3.Lerp(this.gameObject.transform.localPosition, newPosition, timeSinceStarted);

            // If the object has arrived, stop the coroutine
            if (this.gameObject.transform.localPosition == newPosition)
            {
                yield break;
            }

            // Otherwise, continue next frame
            yield return null;
        }
    }

}
