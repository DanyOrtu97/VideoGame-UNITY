using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Gestione trigger di fine livello: hiont 12:30
public class TurnOnSun : MonoBehaviour
{
    public GameObject gameController;
    public string punto;
    public void OnTriggerEnter(Collider other)
    {

        gameController.GetComponent<LevelComplete>().AddPlayer(other.tag,punto);
    
    }
    private void OnTriggerExit(Collider other)
    {
        gameController.GetComponent<LevelComplete>().RemovePlayer(other.tag,punto);
    }
}
