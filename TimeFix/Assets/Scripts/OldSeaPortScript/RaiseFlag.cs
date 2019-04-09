using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaiseFlag : MonoBehaviour
{

    public GameObject text;
    private Transform tr;
    public bool isRaised = false;

    // Start is called before the first frame update
    void Start()
    {
        tr = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            text.gameObject.SetActive(true);
            text.gameObject.GetComponent<Text>().text = "Premi E per alzare la bandiera";
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            text.gameObject.SetActive(true);
            text.gameObject.GetComponent<Text>().text = "Premi E per alzare la bandiera";
        }


        if (isRaised == false)
        {
            if (gameObject.CompareTag("flag3"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    tr.transform.position += new Vector3(0, 19.765f, 0);
                    isRaised = true;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    tr.transform.position += new Vector3(0, 2.75f, 0);
                    isRaised = true;
                }
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            text.gameObject.SetActive(false);
        }

    }

    public bool isRaiser(){
        return isRaised;
    }
}
