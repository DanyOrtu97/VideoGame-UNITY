using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OS.Demo.Stuff
{
    public class AutoDoorSensorOnlyLiam : MonoBehaviour
    {
        [SerializeField] private Animator anim;
        [SerializeField] private List<Transform> inTriggerZone;

        void Awake()
        {
            anim = GetComponent<Animator>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PlayerA"))
            {
                inTriggerZone.Add(other.transform);
                Open();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("PlayerA"))
            {
                inTriggerZone.Remove(other.transform);
            }

            if(this.gameObject.name != "DoorGame")
            {
                Close();
                this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
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
