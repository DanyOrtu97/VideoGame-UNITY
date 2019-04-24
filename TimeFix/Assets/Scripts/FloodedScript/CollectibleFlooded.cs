using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleFlooded : MonoBehaviour
{
    public GameObject controller;
    public string nome;
    public float speed = 1f;
    public Vector3 rotationVector= new Vector3(0, 30, 0);
    private int contaA = 0, contaB = 0;
    public Text textB, textA;
    public GameObject infoB, infoA;

    private void Start()
    {
        rotationVector = new Vector3(0, 30, 0);
    }

    void FixedUpdate()
    {
        transform.Rotate(rotationVector * Time.deltaTime * speed);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {

            infoA.gameObject.SetActive(true);
            textA.gameObject.SetActive(true);
            textA.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per raccogliere il pezzo della nacivella!";

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                controller.gameObject.GetComponent<InventarioFlooded>().AddItem(nome, "A");
                controller.gameObject.GetComponent<ControllerFlooded>().collectibleA();
                this.gameObject.SetActive(false);

                if (controller.gameObject.GetComponent<InventarioFlooded>().isValidA())
                {
                    textA.text = "Ora che hai tutti i pezzi puoi aggiustare la navicella. Trovala!";
                }
                else
                {
                    textA.text = "";
                }
            }
               
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.gameObject.SetActive(true);
            textB.text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per raccogliere il pezzo della nacivella!";

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
            {
                controller.gameObject.GetComponent<InventarioFlooded>().AddItem(nome, "B");
                controller.gameObject.GetComponent<ControllerFlooded>().collectibleB();
                this.gameObject.SetActive(false);
                
                if (controller.gameObject.GetComponent<InventarioFlooded>().isValidB())
                {
                    textB.text = "Ora che hai tutti i pezzi puoi aggiustare la navicella. Trovala!";
                }
                else
                {
                    textB.text = "";
                }
            }

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {

            infoA.gameObject.SetActive(true);
            textA.gameObject.SetActive(true);
            textA.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per raccogliere il pezzo della nacivella!";

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                controller.gameObject.GetComponent<InventarioFlooded>().AddItem(nome, "A");
                controller.gameObject.GetComponent<ControllerFlooded>().collectibleA();
                this.gameObject.SetActive(false);

                if (controller.gameObject.GetComponent<InventarioFlooded>().isValidA())
                {
                    textA.text = "Ora che hai tutti i pezzi puoi aggiustare la navicella. Trovala!";
                }
                else
                {
                    textA.text = "";
                }
            }
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.gameObject.SetActive(true);
            textB.text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per raccogliere il pezzo della nacivella!";

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
            {
                controller.gameObject.GetComponent<InventarioFlooded>().AddItem(nome, "B");
                controller.gameObject.GetComponent<ControllerFlooded>().collectibleB();
                this.gameObject.SetActive(false);

                if (controller.gameObject.GetComponent<InventarioFlooded>().isValidB())
                {
                    textB.text = "Ora che hai tutti i pezzi puoi aggiustare la navicella. Trovala!";
                }
                else
                {
                    textB.text = "";
                }
            }
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerA"))
        {
            textA.text = "";
        }

        if (other.gameObject.CompareTag("PlayerB"))
        {
            textB.text = "";
        }

    }

}
