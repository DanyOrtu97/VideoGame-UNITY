using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FineLivelloFlooded : MonoBehaviour
{
    public GameObject controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerA"))
        {
            controller.gameObject.GetComponent<ControllerFlooded>().AddNavicella("PlayerA");

        }
        if (other.gameObject.CompareTag("PlayerB"))
        {
            controller.gameObject.GetComponent<ControllerFlooded>().AddNavicella("PlayerB");

        }
    }
}
