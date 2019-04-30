using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Apertura seconda porta solo se le luci sono accese e l'altra non è aperta
public class GateOpener2 : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject glass1;
    public GameObject glass2;
    public GameObject otherGate;

    private bool controlClosure = false;
    public GameObject doorControl;


    void FixedUpdate()
    {

        if (light1.gameObject.active && light2.gameObject.active && controlClosure == false)
        {
            doorControl.gameObject.GetComponent<DoorControllerLeft>().isOpen = true;
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
            doorControl.gameObject.GetComponent<DoorControllerLeft>().isOpen = false;
        }
    }
}

