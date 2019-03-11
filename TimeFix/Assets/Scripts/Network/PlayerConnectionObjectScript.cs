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
    // Use this for initialization
    void Start () {
        camHost= playerUnitHost.transform.FindChild("MainCameraHost").gameObject;
        camClient = playerUnitClient.transform.FindChild("MainCameraClient").gameObject;

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
        if (DataScript.playersObject.Count==0)
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
        }
       
    }
    
    
}
