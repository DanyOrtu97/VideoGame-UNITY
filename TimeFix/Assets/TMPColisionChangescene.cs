using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMPColisionChangescene : MonoBehaviour
{
    public GameObject controller;
    public bool oneTime = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (oneTime == true) {
            controller.gameObject.GetComponent<ChangeSceneAsync>().ChangeScene("Livello2SunTemple");
            oneTime = false;
        }
        
    }
}
