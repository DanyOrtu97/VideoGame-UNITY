using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//Triggera il gameContreoller per generare il cambio scena
public class CubeScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        NetworkIdentity current= collision.gameObject.GetComponent<NetworkIdentity>();
        if (current != null) {
            GameControllerScriptDefault.AddToUserList(current);
        }
        
    }
    private void OnCollisionExit(Collision collision)
    {
        NetworkIdentity current = collision.gameObject.GetComponent<NetworkIdentity>();
        if (current != null)
        {
            GameControllerScriptDefault.RemoveFromUserList(current);
        }

    }


}
