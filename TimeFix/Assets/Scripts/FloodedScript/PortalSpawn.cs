using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalSpawn : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject player;
    public GameObject infoA;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PlayerA"))
        {
            player.gameObject.SetActive(false);
            player.transform.position = spawnPoint.transform.position;
            player.gameObject.SetActive(true);
            infoA.gameObject.SetActive(false);
        }
    }
}
