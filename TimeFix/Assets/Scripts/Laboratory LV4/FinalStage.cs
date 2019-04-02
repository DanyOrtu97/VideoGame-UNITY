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
            textA.text = "Impedisci a Liam e Remy di fare casini, usate i cubi magici con Z";
            //esplosione finale
            if (Input.GetKeyDown(KeyCode.K))
            {
                gameController.gameObject.GetComponent<Controller_Laboratory>().ExplosionA();
            }
        }


        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Impedisci a Liam e Remy di fare casini, usate i cubi magici con Z";
            //esplosione finale
            if (Input.GetKeyDown(KeyCode.Z))
            {
                gameController.gameObject.GetComponent<Controller_Laboratory>().ExplosionB();
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Impedisci a Liam e Remy di fare casini, usate i cubi magici con K";
            //esplosione finale
            if (Input.GetKeyDown(KeyCode.K))
            {
                gameController.gameObject.GetComponent<Controller_Laboratory>().ExplosionA();
            }
        }


        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Impedisci a Liam e Remy di fare casini, usate i cubi magici con K";
            //esplosione finale
            if (Input.GetKeyDown(KeyCode.Z))
            {
                gameController.gameObject.GetComponent<Controller_Laboratory>().ExplosionB();
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
