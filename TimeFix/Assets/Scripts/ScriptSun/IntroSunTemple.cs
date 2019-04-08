using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSunTemple : MonoBehaviour
{

    public GameObject introCanvas;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            introCanvas.SetActive(false);
            this.GetComponent<Timer>().startTimer = true;
        }
    }
}
