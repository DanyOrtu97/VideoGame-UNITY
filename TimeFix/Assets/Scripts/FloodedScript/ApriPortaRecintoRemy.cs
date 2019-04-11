using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApriPortaRecintoRemy : MonoBehaviour
{
    public GameObject gameController;
    public GameObject porta1_B, porta2_B;
    public GameObject porta1_A, porta2_A;

    public Text textB;
    public GameObject infoB;

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
        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Cancello chiuso! Trova la chiave";

            if (gameController.gameObject.GetComponent<ControllerFlooded>().IsOpenRecinto())
            {
                textB.text = "Premi U per aprire il cancello!";

                if (Input.GetKey(KeyCode.U))
                {
                    porta1_B.gameObject.SetActive(false);
                    porta2_B.gameObject.SetActive(false);
                    porta1_A.gameObject.SetActive(false);
                    porta2_A.gameObject.SetActive(false);
                    infoB.gameObject.SetActive(false);
                    this.gameObject.SetActive(false);

                }
            }
        }

    }

    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Cancello chiuso! Trova la chiave";

            if (gameController.gameObject.GetComponent<ControllerFlooded>().IsOpenRecinto())
            {
                textB.text = "Premi U per aprire il cancello!";

                if (Input.GetKey(KeyCode.U))
                {
                    porta1_B.gameObject.SetActive(false);
                    porta2_B.gameObject.SetActive(false);
                    porta1_A.gameObject.SetActive(false);
                    porta2_A.gameObject.SetActive(false);
                    infoB.gameObject.SetActive(false);
                    this.gameObject.SetActive(false);
                }
            }
        }

        
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerB"))
        {
            infoB.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
        
    }
}
