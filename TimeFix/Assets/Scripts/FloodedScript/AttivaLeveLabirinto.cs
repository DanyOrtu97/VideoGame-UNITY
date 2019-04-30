using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*Gestione leve per l'uscita del labirinto*/
public class AttivaLeveLabirinto : MonoBehaviour
{
    public GameObject luce1;
    public GameObject gameController;
    public Text textA;
    public GameObject infoA;
    private bool flagOneMove = false;
    private int conta = 0;

    void Update()
    {
        if (flagOneMove && conta<1)
        {
            flagOneMove = false;
            luce1.gameObject.GetComponent<Light>().enabled = true;
            this.gameObject.GetComponent<Light>().color = Color.yellow;
            gameController.gameObject.GetComponent<ControllerFlooded>().AddLight();
            this.gameObject.transform.position += new Vector3(0, -1, 0);

            conta++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PlayerA") && conta<1)
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Premi  " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per abbassare la leva!";

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                flagOneMove = true;
                

            }
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerA") && conta < 1)
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Premi  " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per abbassare la leva!";

            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                flagOneMove = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
        }

    }
}
