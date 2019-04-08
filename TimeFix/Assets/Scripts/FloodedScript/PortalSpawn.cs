using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawn : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject player;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //player.gameObject.transform.position = spawnPoint.gameObject.transform.position;
            player.gameObject.SetActive(false);
            player.transform.position=spawnPoint.transform.position;
            player.gameObject.SetActive(true);
            Debug.Log(spawnPoint.transform.position + " seconda " + player.transform.position);
            
        }
    }
}
