using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroSunTemple : MonoBehaviour
{

    public GameObject introCanvas;
    public GameObject[] element;
    public GameObject testoInterazione;
    public GameObject cameraCinematic;
    public GameObject cameraIntro;
    private float timeStart;
    private int lockStart = 0;
    public float delay;
    // Update is called once per frame
    private void Start()
    {
        this.gameObject.GetComponent<SaveLoad>().Save();
        timeStart = Time.time;
        testoInterazione.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per continuare";
    }
    void FixedUpdate()
    {
        if (Time.time - timeStart > delay && lockStart < 2)
        {
            lockStart = 1;
            introCanvas.SetActive(true);
            if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
            {
                lockStart = 2;
                introCanvas.SetActive(false);
                cameraIntro.SetActive(false);
                this.GetComponent<Timer>().startTimer = true;
                foreach (GameObject item in element)
                {
                    item.SetActive(true);
                }


            }

        }
    }
}
