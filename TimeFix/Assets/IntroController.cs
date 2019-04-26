using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    private float startTime;
    public float targetTime;
    private bool lockCambioscena = false;
    // Start is called before the first frame update
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
