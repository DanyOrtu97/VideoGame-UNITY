using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataScript : NetworkBehaviour {
    public static GameObject currentScene;//tiene traccia della scena corrente
    public static List<GameObject> playersObject;//tiene tracia dei game object dei giocatori
    public static List<NetworkIdentity> playersIdentity;//tiene traccia dei networkIdentity dei giocatori

    // Use this for initialization
    public static int value=0;
    void Start () {
        playersObject = new List<GameObject>();
        playersIdentity = new List<NetworkIdentity>();
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(playersObject.Count);
	}
    
    public static void AddToUserList(GameObject id)
    {
        NetworkIdentity idIdentity = id.GetComponent<NetworkIdentity>();
        if (!playersIdentity.Contains(idIdentity))
        {
            playersIdentity.Add(idIdentity);
            playersObject.Add(id);

        }

    }
    public static void RemoveFromUserList()
    {

        playersIdentity = new List<NetworkIdentity>();
        playersObject= new List<GameObject>();
    
    }
}
