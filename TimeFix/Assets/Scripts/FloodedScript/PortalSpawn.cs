using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawn : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PlayerA"))
        {
            player.gameObject.SetActive(false);
            player.transform.position = spawnPoint.transform.position;
            player.gameObject.SetActive(true);
        }
    }
}
