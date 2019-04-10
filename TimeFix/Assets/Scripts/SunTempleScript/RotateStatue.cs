using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RotateStatue : MonoBehaviour
{

    public GameObject allertGuiA;
    public GameObject allertGuiB;
    public GameObject gameController;
    public float speed;
    private bool incrementa = false;
    private float degree;

    private void Start()
    {
        degree = 0;
    }
    private void Update()
    {
        if (incrementa == true) {
            degree = (degree + 90) % 360;
            
            if (degree == 90)
            {
                gameController.GetComponent<OpenTempleDoor>().AddStatue(this.gameObject.tag);
            }
            else {
                gameController.GetComponent<OpenTempleDoor>().RemoveStatue(this.gameObject.tag);
            }
            incrementa = false;
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(-90, 0, degree), Time.deltaTime * speed);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA")) {
            allertGuiA.gameObject.GetComponent<Text>().text =  "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per ruotare la statua" ;
            allertGuiA.gameObject.SetActive(true);
        }
        if (collision.gameObject.CompareTag("PlayerB")) {
            allertGuiB.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per ruotare la statua";
            allertGuiB.gameObject.SetActive(true);
        }
        

    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                incrementa = true;
            }
        }
        if (collision.gameObject.CompareTag("PlayerB"))
        {

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
            {
                incrementa = true;
            }
        }
        

    }
    public void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("PlayerA"))
        {
            allertGuiA.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            allertGuiB.gameObject.SetActive(false);
        }
        
    }

}
