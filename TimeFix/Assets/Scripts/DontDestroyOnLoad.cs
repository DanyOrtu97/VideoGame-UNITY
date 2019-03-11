using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DontDestroyOnLoad :NetworkBehaviour
{
    public static DontDestroyOnLoad instance;

    void Awake()
    {
        Debug.Log("Entrato");

        DontDestroyOnLoad(this.gameObject);
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
