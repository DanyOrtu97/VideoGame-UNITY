using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControllerB : MonoBehaviour
{
    public bool on = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            Debug.Log("Platform");
            on = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            on = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            on = false;
        }
    }
}
