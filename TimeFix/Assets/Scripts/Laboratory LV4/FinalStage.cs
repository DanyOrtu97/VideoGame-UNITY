using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalStage : MonoBehaviour
{

    public Text textA, textB;
    public GameObject infoA, infoB;
    public GameObject PlayerA, PlayerB;


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
        if (other.CompareTag("PlayerA") && PlayerA.GetComponent<PlayerControllerA>().finalStage)
        {
            infoA.gameObject.SetActive(true);
            textA.text = "Impedisci a Liam e Remy di fare casini, esplodici tutto con K";
        }


        if (other.CompareTag("PlayerB") && PlayerB.GetComponent<PlayerControllerB>().finalStage)
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Impedisci a Liam e Remy di fare casini, esplodici tutto con Z";
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("PlayerA") && PlayerA.GetComponent<PlayerControllerA>().finalStage)
        {
            Debug.Log("Trigerrato");
            infoA.gameObject.SetActive(true);
            textA.text = "Impedisci a Liam e Remy di fare casini, esplodici tutto con K";
        }


        if (other.CompareTag("PlayerB") && PlayerB.GetComponent<PlayerControllerB>().finalStage)
        {
            infoB.gameObject.SetActive(true);
            textB.text = "Impedisci a Liam e Remy di fare casini, esplodici tutto con Z";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerA"))
        {
            infoA.gameObject.SetActive(true);
        }


        if (other.CompareTag("PlayerB"))
        {

            infoB.gameObject.SetActive(true);
        }
    }

}
