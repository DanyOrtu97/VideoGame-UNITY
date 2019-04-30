﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccogliChiave : MonoBehaviour
{

    public GameObject gameController;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerB"))
        {
            this.gameObject.SetActive(false);
            gameController.gameObject.GetComponent<ControllerFlooded>().RaccogliChiave();
        }
    }
}
