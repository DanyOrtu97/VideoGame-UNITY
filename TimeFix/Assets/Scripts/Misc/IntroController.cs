using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controller Introduzione iniziale
public class IntroController : MonoBehaviour
{
    private float startTime;
    public float targetTime;
    private bool lockCambioscena = false;
    void Start()
    {
        startTime = Time.time;
    }

    private void FixedUpdate()
    {
        if (Time.time - startTime > targetTime&& !lockCambioscena) {
            lockCambioscena = true;
            this.gameObject.GetComponent<ChangeSceneAsync>().ChangeScene("Livello1DockThing");
        }
    }
}
