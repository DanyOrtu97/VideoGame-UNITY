using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Spawn per l'uscita di liam dal labiribto*/
public class PortalSpawn : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject player;
    public GameObject infoA;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PlayerA"))
        {
            player.gameObject.SetActive(false);//disabilitiamo momentaneamente il game object affinche lo script del movimento non interferisca
            player.transform.position = spawnPoint.transform.position;
            player.gameObject.SetActive(true);
            infoA.gameObject.SetActive(false);
        }
    }
}
