using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AggiustaNavicella : MonoBehaviour
{

    public GameObject gameController;
    public Text textB, textA;
    public GameObject infoB, infoA;
    public GameObject navicellaAggiustata;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Navicella rotta, Raccogli i pezzi per aggiustarla!";

            if (gameController.gameObject.GetComponent<InventarioFlooded>().isValidA())
            {
                textA.text = "Navicella rotta, Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per aggiustarla!";
                

                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
                {
                    navicellaAggiustata.SetActive(true);
                    infoA.gameObject.SetActive(false);
                    this.gameObject.SetActive(false);
                }

            }
            else
            {
                textA.text = "Tu o Remy non avete tutti i pezzi, trovateli!!";

            }
        }

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Navicella rotta, Raccogli i pezzi per aggiustarla!";

            if (gameController.gameObject.GetComponent<InventarioFlooded>().isValidB())
            {
                textB.text = "Navicella rotta, Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per aggiustarla!";

                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
                {
                    navicellaAggiustata.SetActive(true);
                    infoB.gameObject.SetActive(false);
                    this.gameObject.SetActive(false);
                    
                   
                }
                
            }
            else
            {
                textB.text = "Tu o Liam non avete tutti i pezzi, trovateli!!";

            }
        }


    }

    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Navicella rotta, Raccogli i pezzi per aggiustarla!";

            if (gameController.gameObject.GetComponent<InventarioFlooded>().isValidA())
            {
                 textA.text = "Navicella rotta, Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per aggiustarla!";
                

                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
                {
                    navicellaAggiustata.SetActive(true);
                    infoA.gameObject.SetActive(false);
                    this.gameObject.SetActive(false);
                }

            }
            else
            {
                textA.text = "Tu o Remy non avete tutti i pezzi, trovateli!!";

            }
        }
        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Navicella rotta, Raccogli i pezzi per aggiustarla!";

            if (gameController.gameObject.GetComponent<InventarioFlooded>().isValidB())
            {
               textB.text = "Navicella rotta, Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per aggiustarla!";

                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
                {
                    navicellaAggiustata.SetActive(true);
                    infoB.gameObject.SetActive(false);
                    this.gameObject.SetActive(false);
                    
                   
                }

            }
            else
            {
                textB.text = "Tu o Liam non avete tutti i pezzi, trovateli!!";

            }


        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {

            infoA.gameObject.SetActive(false);
        }

        if (other.CompareTag("PlayerB"))
        {

            infoB.gameObject.SetActive(false);
        }
    }

}
