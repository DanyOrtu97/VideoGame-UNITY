using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalStage : MonoBehaviour
{

    public Text textA, textB;
    public GameObject infoA, infoB;
    public GameObject PlayerA, PlayerB;
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per utilizzare i cubi di energia per impedire a Liam e Remy del futuro di fare disastri!";

            //esplosione finale
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                gameController.gameObject.GetComponent<Controller_Laboratory>().Explosion();
            }
        }


        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per utilizzare i cubi di energia per impedire a Liam e Remy del futuro di fare disastri!";
            //esplosione finale
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
            {
                gameController.gameObject.GetComponent<Controller_Laboratory>().Explosion();
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per utilizzare i cubi di energia per impedire a Liam e Remy del futuro di fare disastri!";
            //esplosione finale
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                gameController.gameObject.GetComponent<Controller_Laboratory>().Explosion();
            }
        }


        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per utilizzare i cubi di energia per impedire a Liam e Remy del futuro di fare disastri!";
            //esplosione finale
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
            {
                gameController.gameObject.GetComponent<Controller_Laboratory>().Explosion();
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
