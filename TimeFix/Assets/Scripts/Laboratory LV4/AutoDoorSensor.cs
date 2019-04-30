﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Apertura porte liam remy*/
namespace OS.Demo.Stuff
{
    public class AutoDoorSensor : MonoBehaviour
    {
        [SerializeField] private Animator anim;
        [SerializeField] private List<Transform> inTriggerZone;

        void Awake()
        {
            anim = GetComponent<Animator>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PlayerA") || other.CompareTag("PlayerB"))
            {
                inTriggerZone.Add(other.transform);
                Open();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("PlayerA") || other.CompareTag("PlayerB"))
            {
                inTriggerZone.Remove(other.transform);
            }

            CheckNeedClose();
        }

        private void CheckNeedClose()
        {
            if (inTriggerZone.Count < 1)
            {
                Close();
            }
        }

        public void Open()
        {
            if (anim != null)
            {
                anim.SetBool("Open", true);
            }
        }

        public void Close()
        {
            if (anim != null)
            {
                anim.SetBool("Open", false);
            }
        }
    }
}
