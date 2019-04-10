using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroSunTemple : MonoBehaviour
{

    public GameObject introCanvas;
    public GameObject[] element;
    public GameObject testoInterazione;
    public GameObject testoTastoIntro;
    // Update is called once per frame
    private void Start()
    {
        testoInterazione.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per continuare";
    }
    void Update()
    {
        if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"])) {
            introCanvas.SetActive(false);
            this.GetComponent<Timer>().startTimer = true;
            foreach(GameObject item in element) {
                item.SetActive(true);
            }
        }
    }
}
