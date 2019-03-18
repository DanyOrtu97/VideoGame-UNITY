using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
//gestisce lo spawn dei 2 player
public class PlayerConnectionObjectScript : NetworkBehaviour {

    public GameObject playerUnitHost;
    public GameObject playerUnitClient;
    private GameObject camHost;
    private GameObject camClient;
    [SyncVar]
    public bool ThisIsTheServerPlayer = false;
    // Use this for initialization
    void Start () {
        if (isLocalPlayer && isServer)
        {
            ThisIsTheServerPlayer = true;
        }


        camHost = playerUnitHost.transform.Find("MainCameraHost").gameObject;
        camClient = playerUnitClient.transform.Find("MainCameraClient").gameObject;

        if (isLocalPlayer == false)
        {
            camHost.SetActive(false);
            camClient.SetActive(false);
            return;
        }


        camClient.SetActive(true);
        camHost.SetActive(true);


        CmdSpawnMyUnit();
        /*camHost.SetActive(true);
        camClient.SetActive(true);

        if (isLocalPlayer==false) {

            if (DataScript.playersObject.Count == 0)
            {
                camHost.SetActive(false);
            }
            else
            {
                camClient.SetActive(false);
            }

            return;
        }

        camClient.SetActive(true);

        CmdSpawnMyUnit();
        */
    }
	
	// Update is called once per frame
	void Update () {
        if (isLocalPlayer == false)
        {
            return;
        }

    }

    [Command]
     void CmdSpawnMyUnit() {

        if (ThisIsTheServerPlayer)
        {
            GameObject go = Instantiate(playerUnitHost);
            DataScript.AddToUserList(go);
            go.transform.position = NetworkManager.singleton.GetStartPosition().position;//posizione iniziale
            NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
        }
        else
        {
            GameObject go = Instantiate(playerUnitClient);
            DataScript.AddToUserList(go);
            go.transform.position = NetworkManager.singleton.GetStartPosition().position;//posizione iniziale
            NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
        }
        /*if (DataScript.playersObject.Count==0)
        {

            GameObject go = Instantiate(playerUnitHost);
            DataScript.AddToUserList(go);
            go.transform.position = NetworkManager.singleton.GetStartPosition().position;//posizione iniziale
            NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
        }
        else {

            GameObject go = Instantiate(playerUnitClient);
            DataScript.AddToUserList(go);
            go.transform.position = NetworkManager.singleton.GetStartPosition().position;//posizione iniziale
            NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
        }*/

    }
    
    
}
