using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Rotazione e raccolta dei cubi collectible*/
public class RotateCollectible : MonoBehaviour
{
    private float speed = 5f;
    public GameObject gameController;
    public Text textA, textB;
    public GameObject infoA, infoB;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * speed);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PlayerA") && gameController.gameObject.GetComponent<Controller_Laboratory>().getIndiceA() < 5)
        {
            gameController.gameObject.GetComponent<Controller_Laboratory>().collectibleA();
            this.gameObject.SetActive(false);
        }
        else if (other.CompareTag("PlayerA") && gameController.gameObject.GetComponent<Controller_Laboratory>().getIndiceA() >= 5)
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Massima capienza raggiunta";
        }



        if (other.CompareTag("PlayerB") && gameController.gameObject.GetComponent<Controller_Laboratory>().getIndiceB() < 5)
        {
            gameController.gameObject.GetComponent<Controller_Laboratory>().collectibleB();
            this.gameObject.SetActive(false);
        }
        else if (other.CompareTag("PlayerB") && gameController.gameObject.GetComponent<Controller_Laboratory>().getIndiceB() >= 5)
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Massima capienza raggiunta";
        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(false);
        }

        if (other.CompareTag("PlayerB")){
            infoB.gameObject.SetActive(false);
        }
    }





}
