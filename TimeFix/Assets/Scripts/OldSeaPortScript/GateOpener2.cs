using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpener2 : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject glass1;
    public GameObject glass2;
    public GameObject otherGate;
    private Transform tr;
    private bool controlClosure = false;



    // Start is called before the first frame update
    void Start()
    {
        tr = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (light1.gameObject.active && light2.gameObject.active && controlClosure == false)
        {
            tr.eulerAngles += new Vector3(0, 90, 0);
            controlClosure = true;
            light3.gameObject.SetActive(false);
            light4.gameObject.SetActive(false);
            glass1.gameObject.SetActive(false);
            glass2.gameObject.SetActive(false);

            if (otherGate.gameObject.transform.eulerAngles.z != 0)
            {
                Debug.Log(otherGate.gameObject.transform.eulerAngles.z);
                otherGate.transform.eulerAngles += new Vector3(0, -90, 0);
            }
        }

        else if (!light1.gameObject.active && !light2.gameObject.active && controlClosure)
        {
            controlClosure = false;
            tr.eulerAngles += new Vector3(0, -90, 0);

        }
    }
}

