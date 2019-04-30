using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Suono e controllo apertura passaggio inferiore tramite collisione nelle piattaforme*/
public class PlatformControllerB : MonoBehaviour
{
    public bool on = false;
    public GameObject PlatrformA;
    public GameObject infoB;
    public Text textB;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerB"))
        {
            audio.Play();
        }
    }



    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("PlayerB"))
        {
            on = true;

            if (PlatrformA.GetComponent<PlatformControllerAA>().on)
            {
                infoB.gameObject.SetActive(true);
                textB.text = "Passaggio inferiore aperto per Liam";
                audio.enabled = false;
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            on = true;
            if (PlatrformA.GetComponent<PlatformControllerAA>().on)
            {
                infoB.gameObject.SetActive(true);
                textB.text = "Passaggio inferiore aperto per Liam";
                audio.enabled = false;
            }
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
