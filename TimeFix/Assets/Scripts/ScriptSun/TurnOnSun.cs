using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnSun : MonoBehaviour
{
    public GameObject gameController;

    public void OnTriggerEnter(Collider other)
    {

        gameController.GetComponent<LevelComplete>().AddPlayer();
    
    }
    private void OnTriggerExit(Collider other)
    {
        gameController.GetComponent<LevelComplete>().RemovePlayer();
    }
}
