using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBaseMedioevo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SaveLoad>().Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
