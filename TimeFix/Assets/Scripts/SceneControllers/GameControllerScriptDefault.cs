using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
//Gestisce la traszione tra scene
public class GameControllerScriptDefault : NetworkBehaviour {

    public static List<NetworkIdentity> listaUtenti;
    private int changeScene=0;
    // Use this for initialization
    void Start () {
        listaUtenti = new List<NetworkIdentity>();
	}
	
	// Update is called once per frame
	void Update () {

        if (listaUtenti.Count == 1)
        {
            
            DataScript.RemoveFromUserList();

            NetworkManager.singleton.ServerChangeScene("Livello2");
            
        }

    }
    public static void AddToUserList(NetworkIdentity id)
    {
        if (!listaUtenti.Contains(id))
        {
            listaUtenti.Add(id);

        }
    }
    public static void RemoveFromUserList(NetworkIdentity id)
    {
        if (listaUtenti.Contains(id))
        {
            listaUtenti.Remove(id);
        }
    }
}
